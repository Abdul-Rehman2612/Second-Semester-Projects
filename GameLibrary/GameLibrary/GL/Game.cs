using EZInput;
using GameLibrary.GL.Collision;
using GameLibrary.GL.Enum;
using GameLibrary.GL.Fire;
using GameLibrary.GL.Interfaces;
using GameLibrary.GL.Movement;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GameLibrary.GL
{
    public class Game
    {
        private static Game instance;
        private Form container;
        private Panel container1;
        private List<GameObject> gameObjects;
        ICollision collision = new Collisions();
        private static string GameStatus;
        private Game(Form container)
        {
            this.container = container;
            gameObjects = new List<GameObject>();
            GameStatus="Play";
        }
        private Game(Panel container1)
        {
            this.container1 = container1;
            gameObjects = new List<GameObject>();
            GameStatus="Play";
        }
        public static Game GetInstance(Form container)
        {
            if (instance == null)
            {
                instance = new Game(container);
            }
            return instance;
        }
        public static Game GetInstance(Panel container1)
        {
            if (instance == null)
            {
                instance = new Game(container1);
            }
            return instance;
        }
        public void AddGameObject(Image img, int x, int y, IMovement movement)
        {
            GameObject gameObject;
            if (movement is HorizontalMovement || movement is VerticalMovement || movement is ZigZagMovement)
            {
                gameObject = new GameObject(img, x, y, movement, ObjectType.Enemy);
            }
            else if (movement is KeyMovements)
            {
                gameObject = new GameObject(img, x, y, movement, ObjectType.Player);
            }
            else if (movement is FireMovement)
            {
                gameObject = new GameObject(img, x, y, movement, ObjectType.Bullet);
            }
            else
            {
                gameObject = new GameObject(img, x, y, movement, ObjectType.Wall);
            }
            if (container != null)
            {
                container?.Controls.Add(gameObject.GetPictureBox());
            }
            else if(container1 != null)
            {
                container1?.Controls.Add(gameObject.GetPictureBox());
            }
            gameObjects.Add(gameObject);
        }
        public void PauseGame()
        {
            GameStatus="Pause";
        }
        public void ResumeGame()
        {
            GameStatus="Play";
        }
        public void UpdateGame()
        {
            if (GameStatus == "Play")
            {
                UpdateObjects();
                CheckCollisions();
                Fire();
            }
        }
        private void Fire()
        {
            if(Keyboard.IsKeyPressed(Key.W))
            {
                FirePlayer(Direction.Up);
            }
            if(Keyboard.IsKeyPressed(Key.S))
            {
                FirePlayer(Direction.Down);
            }
            if(Keyboard.IsKeyPressed(Key.D))
            {
                FirePlayer(Direction.Right);
            }
            if(Keyboard.IsKeyPressed(Key.A))
            {
                FirePlayer(Direction.Left);
            }
        }
        private void CheckCollisions()
        {
            List<GameObject> objectsToRemove = new List<GameObject>();
            for (int i = 0; i < gameObjects.Count; i++)
            {
                for (int j = i + 1; j < gameObjects.Count; j++)
                {
                    if (gameObjects[i].GetObjectType() != gameObjects[j].GetObjectType())
                    {
                        if (collision.CheckCollisions(gameObjects[i], gameObjects[j]))
                        {
                            Action action = collision.CheckCollisionAction(gameObjects[i], gameObjects[j]);
                            if (action == Action.RemoveBullet)
                            {
                                if (gameObjects[i].GetObjectType() == ObjectType.Bullet)
                                    objectsToRemove.Add(gameObjects[i]);

                                if (gameObjects[j].GetObjectType() == ObjectType.Bullet)
                                    objectsToRemove.Add(gameObjects[j]);
                            }
                            else if (action == Action.RemoveEB)
                            {
                                objectsToRemove.Add(gameObjects[i]);
                                objectsToRemove.Add(gameObjects[j]);
                            }
                            else if (action == Action.RemovePlayer)
                            {
                                if (gameObjects[i].GetObjectType() == ObjectType.Player)
                                    objectsToRemove.Add(gameObjects[i]);
                                if (gameObjects[j].GetObjectType() == ObjectType.Player)
                                    objectsToRemove.Add(gameObjects[j]);
                            }
                        }
                    }
                }
            }
            foreach (GameObject obj in objectsToRemove)
            {
                Control parent = obj.GetPictureBox().Parent;
                if (parent != null)
                {
                    parent.Controls.Remove(obj.GetPictureBox());
                }
                obj.GetPictureBox().Dispose();
                gameObjects.Remove(obj);
            }
        }
        public void FirePlayer(Direction direction)
        {
            int left = 0, top = 0;
            foreach (GameObject gameobject in gameObjects)
            {
                if (gameobject.GetObjectType() == ObjectType.Player)
                {
                    if(direction==Direction.Up)
                    {
                        left=gameobject.GetPictureBox().Left;
                        top=gameobject.GetPictureBox().Top;
                    }
                    if(direction== Direction.Down)
                    {
                        left=gameobject.GetPictureBox().Left;
                        top=gameobject.GetPictureBox().Top+gameobject.GetPictureBox().Height;
                    }
                    if(direction==Direction.Left)
                    {
                        left=gameobject.GetPictureBox().Left-15;
                        top = gameobject.GetPictureBox().Top + gameobject.GetPictureBox().Height / 3;
                    }
                    if (direction==Direction.Right)
                    {
                        left = gameobject.GetPictureBox().Left + gameobject.GetPictureBox().Width;
                        top = gameobject.GetPictureBox().Top + gameobject.GetPictureBox().Height / 3;
                    }
                    break;
                }
            }
            if (container!=null)
            {
                AddGameObject(Resource1.bullet, left, top, new FireMovement(20, direction));
            }
            else if (container1!=null)
            {
                AddGameObject(Resource1.bullet, left, top, new FireMovement(20, direction));
            }
        }
        public void UpdateObjects()
        {
            if (gameObjects.Count>0)
            {
                foreach (GameObject gameObject in gameObjects)
                {
                    gameObject.Update();
                }
            }
        }
    }
}
