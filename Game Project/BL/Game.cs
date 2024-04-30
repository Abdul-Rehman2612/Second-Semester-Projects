using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Game_Project
{
    internal class Game
    {
        private float gravity;
        private Form form;
        private List<GameObject> gameObjects;

        public Game(float gravity, Form form)
        {
            this.gravity = gravity;
            this.form = form;
            this.gameObjects = new List<GameObject>();
        }

        public void addGameObject(Image image, int x, int y, bool fallUnderGravity)
        {
            GameObject gameObject = new GameObject(image, x, y, fallUnderGravity);
            gameObjects.Add(gameObject);
        }

        public void update()
        {
            foreach (GameObject gameObject in gameObjects)
            {
                if (gameObject.FallUnderGravity)
                {
                    gameObject.Y += gravity; // Apply gravity
                }
                // Perform other game logic here, like collision detection, etc.
            }
            // Update UI if necessary
            form.Invalidate(); // Trigger form redraw
        }
    }
}

