using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Project
{
    internal class Bullet
    {
        private string Direction;
        private PictureBox BulletPicture = new PictureBox();
      
        public PictureBox GetBulletPicture() { return this.BulletPicture; }
        public  void CreateBullet(Form form , PictureBox playerPictureBox)
        {
            BulletPicture.Image = Properties.Resources.Bullet;
            BulletPicture.SizeMode = PictureBoxSizeMode.StretchImage;

            BulletPicture.Size = BulletPicture.Image.Size;
            BulletPicture.BackColor = Color.Transparent;
            BulletPicture.Location = new System.Drawing.Point(playerPictureBox.Right, playerPictureBox.Top + playerPictureBox.Height / 2 - 30);
            form.Controls.Add(BulletPicture);
        }
        public bool MoveBullet(Form form , Enemy enmey)
        {

            this.BulletPicture.Left += 10;

                if (this.BulletPicture.Left > form.ClientSize.Width)
                {
                  return false;
                 
                }
            return true;
        }
    }
}
