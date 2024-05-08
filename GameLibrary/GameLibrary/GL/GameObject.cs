using GameLibrary.GL.Enum;
using GameLibrary.GL.Interfaces;
using System.Drawing;
using System.Windows.Forms;

namespace GameLibrary.GL
{
    public class GameObject
    {
        protected PictureBox pictureBox;
        protected IMovement movement;
        protected ObjectType objectType;
        public GameObject() { }
        public GameObject(Image image, int x, int y, IMovement movement, ObjectType objectType)
        {
            pictureBox = new PictureBox
            {
                BackColor = Color.Transparent,
                Height = image.Height,
                Width = image.Width,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = image,
                Location = new Point(x, y),
                Top = y,
                Left = x
            };
            this.movement=movement;
            this.objectType=objectType;
        }
        public void Update()
        {
            if (objectType!=ObjectType.Wall && movement!=null)
            {
                pictureBox.Location = movement.Move(pictureBox.Location);
            }
        }
        public void SetPictureBox()
        {
            pictureBox.Visible = false;
        }
        public ObjectType GetObjectType() { return objectType; }
        public PictureBox GetPictureBox() { return pictureBox; }
    }
}
