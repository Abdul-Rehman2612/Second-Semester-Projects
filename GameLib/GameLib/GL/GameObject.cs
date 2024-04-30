using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLib.GL
{
    public class GameObject
    {
        protected PictureBox pictureBox;
        protected int speed;
        public GameObject() { }
        public GameObject(Form form, Image image, int x, int y, int speed)
        {
            pictureBox = new PictureBox();
            pictureBox.BackColor = Color.White;
            pictureBox.Height = image.Height;
            pictureBox.Width = image.Width;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = image;
            pictureBox.Location = new Point(x, y);
            pictureBox.Top = y;
            pictureBox.Left = x;
            this.speed = speed;
            form.Controls.Add(pictureBox);
        }
        public GameObject(Panel p, Image image, int x, int y, int speed)
        {
            pictureBox = new PictureBox();
            pictureBox.BackColor = Color.White;
            pictureBox.Height = image.Height;
            pictureBox.Width = image.Width;
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
            pictureBox.Width = (int)(pictureBox.Width * form.ClientSize.Width / 1370.0);
            pictureBox.Height = (int)(pictureBox.Height * form.ClientSize.Height / 749.0);
        }
        public void UpdateSize(Panel panel)
        {
            pictureBox.Width = (int)(pictureBox.Width * panel.ClientSize.Width / 1370.0);
            pictureBox.Height = (int)(pictureBox.Height * panel.ClientSize.Height / 749.0);
        }
    }
}
