using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    internal class HorizontalEnemy: Enemy
    {
        public HorizontalEnemy(Form form, Image image, int x, int y, int speed):base(form,image,x,y,speed,"Right")
        {
        }
        public override void Move(Form form)
        {
            if (pictureBox.Left + pictureBox.Width + speed < form.ClientSize.Width && direction == "Right")
            {
                pictureBox.Left += speed;
            }
            else if (pictureBox.Left + pictureBox.Width + speed >= form.ClientSize.Width && direction == "Right")
            {
                direction="Left";
            }
            if (pictureBox.Left - speed > 0 && direction == "Left")
            {
                pictureBox.Left -= speed;
            }
            else if (pictureBox.Left - speed <=0 && direction == "Left")
            {
                direction="Right";
            }
        }
    }
}
