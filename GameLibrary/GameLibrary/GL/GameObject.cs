using GameLibrary.GL.Movement;
using System.Drawing;
using System.Windows.Forms;

namespace GameLibrary.GL
{
    public class GameObject
    {
        protected PictureBox pictureBox;
        protected IMovement movement;
        public GameObject() { }
        public GameObject(Image image, int x,int y,IMovement movement)
        {
            pictureBox = new PictureBox
            {
                BackColor = Color.White,
                Height = image.Height,
                Width = image.Width,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = image,
                Location = new Point(x,y),
                Top = y,
                Left = x
            };
            this.movement=movement;
        }
        public void Update()
        {
            if (movement != null)
            {
                pictureBox.Location = movement.Move(pictureBox.Location);
            }
        }
        public PictureBox GetPictureBox() { return pictureBox; }
    }
}
