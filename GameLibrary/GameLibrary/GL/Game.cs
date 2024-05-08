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
        private Label playerScore;
        private Label EnemyCount;
        private int enemyCount = 0;
        private int score=0;
        private Game(Form container)
        {
            this.container = container;
            gameObjects = new List<GameObject>();
            GameStatus="Play";
            playerScore= new Label
            {
                Top=10,
                Left=1250,
                BackColor=Color.Teal,
                ForeColor=Color.White
            };
            container.Controls.Add(playerScore);
            EnemyCount= new Label
            {
                Top=50,
                Left=1250,
                BackColor=Color.Teal,
                ForeColor=Color.White
            };
            container.Controls.Add(EnemyCount);
        }
        private int bulletCount()
        {

            int count = 0;
            foreach (GameObject obj in gameObjects)
            {
                if (obj.GetObjectType()==ObjectType.Bullet)
                {
                    count++;
                }
            }
            return count;
        }
        private Game(Panel container1)
        {
            this.container1 = container1;
            gameObjects = new List<GameObject>();
            GameStatus = "Play";
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
                enemyCount++;
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
                gameObject = new GameObject(img, x, y, movement, ObjectType.Reward);
            }
            if (container != null)
            {
                container?.Controls.Add(gameObject.GetPictureBox());
            }
            else if (container1 != null)
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
        public string UpdateGame()
        {
            if (GameStatus == "Play")
            {
                UpdateObjects();
                CheckCollisions();
                Fire();
                WinCheck();
                playerScore.Text="Score: "+ score.ToString();
                EnemyCount.Text="Enemy Count: "+ enemyCount.ToString();
            }
            return GameStatus;
        }
        private void Fire()
        {
            if (Keyboard.IsKeyPressed(Key.W)) FirePlayer(Direction.Up);
            if (Keyboard.IsKeyPressed(Key.X)) FirePlayer(Direction.Down);
            if (Keyboard.IsKeyPressed(Key.D)) FirePlayer(Direction.Right);
            if (Keyboard.IsKeyPressed(Key.A)) FirePlayer(Direction.Left);
            if (Keyboard.IsKeyPressed(Key.Q)) FirePlayer(Direction.DiagUpLeft);
            if (Keyboard.IsKeyPressed(Key.E)) FirePlayer(Direction.DiagUpRight);
            if (Keyboard.IsKeyPressed(Key.Z)) FirePlayer(Direction.DiagDownLeft);
            if (Keyboard.IsKeyPressed(Key.C)) FirePlayer(Direction.DiagDownRight);
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
                                if (gameObjects[i].GetObjectType() == ObjectType.Bullet) objectsToRemove.Add(gameObjects[i]);
                                if (gameObjects[j].GetObjectType() == ObjectType.Bullet) objectsToRemove.Add(gameObjects[j]);
                            }
                            else if (action == Action.RemoveEB)
                            {
                                objectsToRemove.Add(gameObjects[i]);
                                objectsToRemove.Add(gameObjects[j]);
                                enemyCount--;
                            }
                            else if (action == Action.RemoveEnemy)
                            {
                                if (gameObjects[i].GetObjectType() == ObjectType.Enemy) objectsToRemove.Add(gameObjects[i]);
                                if (gameObjects[j].GetObjectType() == ObjectType.Enemy) objectsToRemove.Add(gameObjects[j]);
                                enemyCount--;
                            }
                            else if (action == Action.IncreaseScore)
                            {
                                if (gameObjects[i].GetObjectType() == ObjectType.Reward) objectsToRemove.Add(gameObjects[i]);
                                if (gameObjects[j].GetObjectType() == ObjectType.Reward) objectsToRemove.Add(gameObjects[j]);
                                score+=1;
                            }
                            else if (action == Action.RemovePlayer)
                            {
                                if (gameObjects[i].GetObjectType() == ObjectType.Player) objectsToRemove.Add(gameObjects[i]);
                                if (gameObjects[j].GetObjectType() == ObjectType.Player) objectsToRemove.Add(gameObjects[j]);
                                GameStatus="Lose";
                            }
                        }
                    }
                }
            }

            foreach (GameObject obj in objectsToRemove)
            {
                Control parent = obj.GetPictureBox().Parent;

                if (parent != null) parent.Controls.Remove(obj.GetPictureBox());

                obj.GetPictureBox().Dispose();
                gameObjects.Remove(obj);
            }
        }
        public void WinCheck()
        {
            int count=0;
            foreach(GameObject obj in gameObjects)
            {
                if(obj.GetObjectType()==ObjectType.Enemy)
                {
                    count++;
                }
            }
            if(count==0)
            {
                GameStatus="Win";
            }
        }
        public void FirePlayer(Direction direction)
        {
            if (bulletCount()<=12)
            {
                int left = 0, top = 0;
                Image img = null;

                foreach (GameObject gameobject in gameObjects)
                {
                    if (gameobject.GetObjectType() == ObjectType.Player)
                    {
                        if (direction == Direction.Up) { img = Resource1.UBullet; left = gameobject.GetPictureBox().Left; top = gameobject.GetPictureBox().Top; }
                        if (direction == Direction.Down) { img = Resource1.DBullet; left = gameobject.GetPictureBox().Left; top = gameobject.GetPictureBox().Top + gameobject.GetPictureBox().Height; }
                        if (direction == Direction.Left) { img = Resource1.LBullet; left = gameobject.GetPictureBox().Left - 25; top = gameobject.GetPictureBox().Top + gameobject.GetPictureBox().Height / 3; }
                        if (direction == Direction.Right) { img = Resource1.RBullet; left = gameobject.GetPictureBox().Left + gameobject.GetPictureBox().Width; top = gameobject.GetPictureBox().Top + gameobject.GetPictureBox().Height / 3; }
                        if (direction == Direction.DiagUpLeft) { img = Resource1.DULBullet; left = gameobject.GetPictureBox().Left - img.Width; top = gameobject.GetPictureBox().Top - img.Height; break; }
                        if (direction == Direction.DiagUpRight) { img = Resource1.DURBullet; left = gameobject.GetPictureBox().Left + gameobject.GetPictureBox().Width; top = gameobject.GetPictureBox().Top - img.Height; break; }
                        if (direction == Direction.DiagDownLeft) { img = Resource1.DDLBullet; left = gameobject.GetPictureBox().Left - img.Width; top = gameobject.GetPictureBox().Top + gameobject.GetPictureBox().Height; break; }
                        if (direction == Direction.DiagDownRight) { img = Resource1.DDRBullet; left = gameobject.GetPictureBox().Left + gameobject.GetPictureBox().Width; top = gameobject.GetPictureBox().Top + gameobject.GetPictureBox().Height; break; }
                    }
                }
                if (container != null) AddGameObject(img, left, top, new FireMovement(20, direction));
                else if (container1 != null) AddGameObject(img, left, top, new FireMovement(20, direction));
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
