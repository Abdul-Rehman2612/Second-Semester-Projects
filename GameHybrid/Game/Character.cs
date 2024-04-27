using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    abstract class Character
    {
        protected PictureBox pictureBox;
        protected int speed;
        public Character() { }
        public Character(Form form, Image image, int x, int y, int speed)
        {
            pictureBox = new PictureBox();
            pictureBox.BackColor = Color.White;
            pictureBox.Height = 50;
            pictureBox.Width = 50;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = image;
            pictureBox.Location = new Point(x, y);
            pictureBox.Top = y;
            pictureBox.Left = x;
            this.speed = speed;
            form.Controls.Add(pictureBox);
        }
        public Character(Panel p, Image image, int x, int y, int speed)
        {
            pictureBox = new PictureBox();
            pictureBox.BackColor = Color.White;
            pictureBox.Height = 50;
            pictureBox.Width = 50;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = image;
            pictureBox.Location = new Point(x, y);
            pictureBox.Top = y;
            pictureBox.Left = x;
            this.speed = speed;
            p.Controls.Add(pictureBox);
        }
        public PictureBox GetPictureBox() { return pictureBox; }
        public void UpdateSize(Form form)
        {
            pictureBox.Width = (int)(50 * form.ClientSize.Width / 1370.0);
            pictureBox.Height = (int)(50 * form.ClientSize.Height / 749.0);
        }
        public void UpdateSize(Panel panel)
        {
            pictureBox.Width = (int)(50 * panel.ClientSize.Width / 1370.0);
            pictureBox.Height = (int)(50 * panel.ClientSize.Height / 749.0);
        }
    }
}
