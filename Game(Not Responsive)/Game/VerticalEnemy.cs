﻿using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    internal class VerticalEnemy : Enemy
    {
        public VerticalEnemy(Form form, Image image, int x, int y, int speed) : base(form, image, x, y, speed,"Up")
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

    }
}