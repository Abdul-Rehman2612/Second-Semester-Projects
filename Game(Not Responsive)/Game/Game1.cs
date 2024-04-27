﻿using System;
using System.Windows.Forms;
using EZInput;

namespace Game
{
    public partial class Game1 : Form
    {
        static string gameStatus = "Play";
        GameClass game = new GameClass();

        public Game1()
        {
            InitializeComponent();
            game.AddPlayer(new Player(this, Resource1.P, 100, this.Height - 400, 10));
            game.AddCharacter(new HorizontalEnemy(this, Resource1.P, 300, 400, 10));
            game.AddCharacter(new VerticalEnemy(this, Resource1.P, 0, 0, 10));
            WindowState = FormWindowState.Maximized;
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
            if (gameStatus == "Play")
            {
                game.UpdateGame(this, GetPressedKey());
            }

            if (Keyboard.IsKeyPressed(Key.P) && gameStatus == "Play")
            {
                
                gameStatus = "Paused";
            }

            if (Keyboard.IsKeyPressed(Key.P) && gameStatus == "Paused")
            {
                gameStatus = "Play";
            }
        }
        private Keys GetPressedKey()
        {
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                if (Keyboard.IsKeyPressed((Key)key))
                {
                    return key;
                }
            }
            return Keys.None;
        }
    }
}
