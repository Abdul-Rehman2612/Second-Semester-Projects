using GameLibrary.GL.Movement;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EZInput;
namespace GameLibrary.GL
{
    public class Game
    {
        private static Game instance;
        private Form container;
        private Panel container1;
        private List<GameObject> gameObjects;
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
            GameObject gameObject = new GameObject(img, x, y, movement);
            if (container != null)
            {
                container.Controls.Add(gameObject.GetPictureBox());
            }
            else
            {
                container1?.Controls.Add(gameObject.GetPictureBox());
            }
            gameObjects.Add(gameObject);
        }
        private void ChangeGameStatus()
        {
            if(Keyboard.IsKeyPressed(Key.P) && GameStatus=="Play")
            {
                GameStatus="Pause";
            }
            else if(Keyboard.IsKeyPressed(Key.P) && GameStatus=="Pause")
            {
                GameStatus="Play";
            }
        }
        public void UpdateGame()
        {
            ChangeGameStatus();
            if (GameStatus=="Play")
            {
                UpdateObjects();
            }
        }
        public void UpdateObjects()
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update();
            }
        }
    }
}
