using System.Drawing;
using System.Windows.Forms;


namespace Game_Project
{
    internal class Enemy
    {
        private int X;
        private int Y;
        private string Direction;
        private ProgressBar Health = new ProgressBar();
        private PictureBox MyEnemy = new PictureBox();

        public Enemy(int x, int y, PictureBox player)
        {
            this.X = x;
            this.Y = y;
            this.MyEnemy = player;
        }
        public Enemy()
        {

        }
        public void Decresehealth(Form form)
        {
            if (Health.Value == 0)
            {
                MyEnemy.Visible = false;
                form.Controls.Remove(MyEnemy);
                MyEnemy.Dispose();
                MessageBox.Show("you win");
                form.Hide();
                NextForm nextfrom = new NextForm();
                nextfrom.Show();
            }
            else
            {

                Health.Value -= 5;
            }

        }

        public void EnemyAttack(Player player)
        {

            if (this.Direction == "S")
            {
                this.MyEnemy.Image = Properties.Resources.EnemyAttack;
                player.DecreseHealth();

            }
            else
            {
                this.MyEnemy.Image = Properties.Resources.Enemy1;
            }
        }
        public void MoveEnemy(Player player)
        {
            int playerCenterX = player.GetMyPlayer().Left + player.GetMyPlayer().Width / 2;
            int enemyCenterX = this.MyEnemy.Left + this.MyEnemy.Width / 2;

            if (playerCenterX < enemyCenterX)
            {
                this.Direction = "L";
            }
            else if (playerCenterX > enemyCenterX)
            {
                this.Direction = "R";
            }



            if (this.Direction == "L" && this.MyEnemy.Left > player.GetMyPlayer().Right)
            {
                this.MyEnemy.Left -= 5;
            }
            else if (this.Direction == "R" && this.MyEnemy.Right < player.GetMyPlayer().Left)
            {
                this.MyEnemy.Left += 5;
            }
            else
            {
                this.Direction = "S";
            }


        }
        public void CreateEnemy(Form form)
        {

            this.MyEnemy.Size = new Size(70, 90);
            this.Direction = "L";
            this.MyEnemy.SizeMode = PictureBoxSizeMode.StretchImage;
            this.MyEnemy.BackColor = Color.Transparent;
            this.MyEnemy.Location = new System.Drawing.Point(form.ClientSize.Width - this.MyEnemy.Width - 20, form.ClientSize.Height - MyEnemy.Height - 30);
            this.MyEnemy.Image = Properties.Resources.Enemy1;
            form.Controls.Add(this.MyEnemy);


            Health.Value = 100;
            Health.Location = new System.Drawing.Point(638, 9);

            form.Controls.Add(this.Health);
        }
        public int GetX() { return this.X; }
        public void SetX(int x) { this.X = x; }
        public int GetY() { return this.Y; }
        public void SetY(int y) { this.Y = y; }

        public PictureBox GetMyEnemy() { return this.MyEnemy; }
        public void SetMyEnemy(PictureBox player) { this.MyEnemy = player; }
    }
}
