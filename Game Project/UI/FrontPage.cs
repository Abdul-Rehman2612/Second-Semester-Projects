using EZInput;
using Game_Project.Properties;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.Windows.Forms;
namespace Game_Project
{
    public partial class FrontPage : Form
    {
        Player player = new Player();
        Enemy Enemy = new Enemy();

        public FrontPage()
        {
            InitializeComponent();

        }
        private void FrontPage_Load(object sender, EventArgs e)
        {
            player.CreatePlayer(this);
            Enemy.CreateEnemy(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.MovePlayer(this);
            Enemy.MoveEnemy(player);
            player.MoveFire(this, Enemy);
            Enemy.EnemyAttack(player);
        }
    }
}
