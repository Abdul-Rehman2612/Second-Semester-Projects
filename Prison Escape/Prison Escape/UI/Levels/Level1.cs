using System;
using System.Windows.Forms;
using GameLibrary.GL;
using Prison_Escape.Utility;
using System.Drawing;
using GameLibrary.GL.Movement;

namespace Prison_Escape.UI
{
    public partial class Level1 : Form
    {
        Game game;
        public Level1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private void Level1_Load(object sender, EventArgs e)
        {
            game = Game.GetInstance(GamePage);
            Point Boundary= new Point(GamePage.Width,GamePage.Height);
            MessageBox.Show($"{GamePage.Width}{ GamePage.Height}","Error");
            game.AddGameObject(Resource1.Player, 10, 10, new HorizontalMovement(10, Boundary, Resource1.Player.Width, "Left"));
            game.AddGameObject(Resource1.Player, 10, 10, new VerticalMovement(10, Boundary, Resource1.Player.Width, "Up"));
            game.AddGameObject(Resource1.Player, 1, 1, new ZigZagMovement(20,20, Boundary, Resource1.Player.Width,Resource1.Player.Height, "DiagUpRight"));
            game.AddGameObject(Resource1.Player, 10, 10, new KeyMovements(10, Boundary, Resource1.Player.Width, Resource1.Player.Height));
            Play();
        }
        private void Play()
        {
            timer1 = new Timer
            {
                Interval = 01
            };
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            game.UpdateGame();
        }

        private void GamePage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
