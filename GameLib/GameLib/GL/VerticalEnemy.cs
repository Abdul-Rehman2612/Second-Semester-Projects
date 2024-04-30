using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameLib.GL
{
    public class VerticalEnemy : Enemy
    {
        public VerticalEnemy(Form form, Image image, int x, int y, int speed) : base(form, image, x, y, speed, "Up")
        {
        }
        public VerticalEnemy(Panel panel, Image image, int x, int y, int speed) : base(panel, image, x, y, speed, "Up")
        {
        }
        public override void Move(Form form)
        {
            if (pictureBox.Top + pictureBox.Height + speed < form.ClientSize.Height && direction == "Down")
            {
                pictureBox.Top += speed;
            }
            else if (pictureBox.Top + pictureBox.Height + speed >= form.ClientSize.Height && direction == "Down")
            {
                direction = "Up";
            }
            if (pictureBox.Top - speed > 0 && direction == "Up")
            {
                pictureBox.Top -= speed;
            }
            else if (pictureBox.Top - speed <= 0 && direction == "Up")
            {
                direction = "Down";
            }
        }
        public override void Move(Panel panel)
        {
            if (pictureBox.Top + pictureBox.Height + speed < panel.ClientSize.Height && direction == "Down")
            {
                pictureBox.Top += speed;
            }
            else if (pictureBox.Top + pictureBox.Height + speed >= panel.ClientSize.Height && direction == "Down")
            {
                direction = "Up";
            }
            if (pictureBox.Top - speed > 0 && direction == "Up")
            {
                pictureBox.Top -= speed;
            }
            else if (pictureBox.Top - speed <= 0 && direction == "Up")
            {
                direction = "Down";
            }
        }
    }
}
