using System;
using System.Windows.Forms;
using GameLibrary.GL;
using System.Drawing;
using GameLibrary.GL.Movement;
using GameLibrary.GL.Enum;
using Prison_Escape.UI.GameStates;

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
            game=null;
            game = Game.GetInstance(this);
            Point Boundary = new Point(Width,Height);
            game.AddGameObject(Resource1.Enemy1, 101, 105, new HorizontalMovement(10, Boundary, Resource1.Enemy1.Width, Direction.Left));
            game.AddGameObject(Resource1.Enemy2, 203, 201, new VerticalMovement(10, Boundary, Resource1.Enemy2.Width, Direction.Right));
            game.AddGameObject(Resource1.Enemy3, 207, 307, new ZigZagMovement(10, 6, Boundary, Resource1.Enemy3.Width, Resource1.Enemy3.Height, Direction.DiagUpRight));
            game.AddGameObject(Resource1.GPlayer, 10, 10, new KeyMovements(10, Boundary, Resource1.GPlayer.Width, Resource1.GPlayer.Height));
            Play();
        }
        private void Play()
        {
            timer1 = new Timer
            {
                Interval = 30
            };
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            string gameStatus=game.UpdateGame();
            if(gameStatus=="Lose")
            {
                timer1.Stop();
                Hide();
                LoseGame loseGame = new LoseGame();
                loseGame.Show();
            }
            if(gameStatus=="Win")
            {
                timer1.Stop();
                Hide();
                WinGame winGame = new WinGame();
                winGame.Show();
            }
        }
    }
}
