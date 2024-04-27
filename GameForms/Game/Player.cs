using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    internal class Player : Character
    {
        public Player()
        {

        }
        public Player(Form form, Image image, int x, int y, int speed) : base(form, image, x, y, speed)
        {
        }
        public void Move(Form form, Keys key)
        {
            switch (key)
            {
                case Keys.Left:
                    if (pictureBox.Left - speed > 0)
                        pictureBox.Left -= speed;
                    break;
                case Keys.Right:
                    if (pictureBox.Right + speed < form.ClientSize.Width)
                        pictureBox.Left += speed;
                    break;
                case Keys.Up:
                    if (pictureBox.Top - speed > 0)
                        pictureBox.Top -= speed;
                    break;
                case Keys.Down:
                    if (pictureBox.Bottom + speed < form.ClientSize.Height)
                        pictureBox.Top += speed;
                    break;
            }
        }

    }
}
