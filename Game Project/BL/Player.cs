using EZInput;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Project
{
    internal class Player
    {
        private int X;
        private int Y;
        private ProgressBar Health = new ProgressBar();
        private PictureBox MyPlayer = new PictureBox();
        List<Bullet> MyBullet = new List<Bullet>();
        public Player(int x, int y, PictureBox player)
        {
            this.X = x;
            this.Y = y;
            this.MyPlayer = player;
        }
        public Player()
        {

        }
        public ProgressBar GetHealth() { return this.Health; }
        public void SetHealth(int health) { this.Health.Value = health; }
        public void DecreseHealth()
        {
            if (Health.Value - 1 < 0)
            {
                MessageBox.Show("You loss");

                NextForm nextfrom = new NextForm();
                nextfrom.Show();

            }
            else
            {
                this.Health.Value -= 1;
            }
        }
        public List<Bullet> GetMyBullet() { return this.MyBullet; }

        public void MoveFire(Form form, Enemy enemy)
        {
            for (int i = MyBullet.Count - 1; i >= 0; i--)
            {
                bool check = MyBullet[i].MoveBullet(form, enemy);
                if (check == false)
                {
                    form.Controls.Remove(MyBullet[i].GetBulletPicture());
                    MyBullet[i].GetBulletPicture().Dispose();
                    MyBullet.RemoveAt(i);
                }

                if (MyBullet[i].GetBulletPicture().Bounds.IntersectsWith(enemy.GetMyEnemy().Bounds))
                {
                    enemy.Decresehealth(form);
                }
            }


        }
        public void CreatePlayer(Form form)
        {

            MyPlayer.Image = Properties.Resources.Player;
            MyPlayer.Size = new Size(70, 90);
            this.X = 20;
            this.Y = form.ClientSize.Height - MyPlayer.Height - 30;
            MyPlayer.Location = new System.Drawing.Point(X, Y);
            MyPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            MyPlayer.BackColor = Color.Transparent;
            form.Controls.Add(MyPlayer);


            this.Health.Value = 100;

            Health.Location = new System.Drawing.Point(166, 9);
            form.Controls.Add(Health);


        }
        public void MovePlayer(Form form)
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                MyPlayer.Left += 10;
            }
            else if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                MyPlayer.Left -= 10;
            }
            else if (Keyboard.IsKeyPressed(Key.Space))
            {
                Bullet bullet = new Bullet();
                bullet.CreateBullet(form, this.MyPlayer);
                MyBullet.Add(bullet);
            }

        }
        public int GetX() { return this.X; }
        public void SetX(int x) { this.X = x; }
        public int GetY() { return this.Y; }
        public void SetY(int y) { this.Y = y; }

        public PictureBox GetMyPlayer() { return this.MyPlayer; }
        public void SetMyPlayer(PictureBox player) { this.MyPlayer = player; }
    }
}
