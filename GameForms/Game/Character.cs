﻿using System;
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
            pictureBox = new PictureBox
            {
                BackColor = Color.White,
                Height = 50,
                Width = 50,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = image,
                Location = new Point(x, y),
                Top = y,
                Left = x
            };
            this.speed = speed;
            form.Controls.Add(pictureBox);
        }
        public PictureBox GetPictureBox() { return pictureBox; }
        public void UpdateSize(Form form)
        {
            pictureBox.Width = (int)(50 * form.ClientSize.Width / 1370.0);
            pictureBox.Height = (int)(50 * form.ClientSize.Height / 749.0);
        }
    }
}