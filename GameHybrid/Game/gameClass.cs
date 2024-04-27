using System.Collections.Generic;
using System.Windows.Forms;

namespace Game
{
    internal class GameClass
    {
        Player player;
        List<Enemy> enemies;
        public GameClass()
        {
            enemies = new List<Enemy>();
        }
        public void AddPlayer(Player player)
        {
            this.player=player;
        }
        public void AddCharacter(Enemy enemy)
        {
            enemies.Add(enemy);
        }
        public void UpdateGame(Form form,Keys key)
        {
            player.Move(form,key);
            player.UpdateSize(form);
            foreach (Enemy e in enemies)
            {
                if (!player.GetPictureBox().Bounds.IntersectsWith(e.GetPictureBox().Bounds))
                {
                    e.Move(form);
                }
                e.UpdateSize(form);
            }
        }
        public void UpdateGame(Panel panel, Keys key)
        {
            player.Move(panel, key);
            player.UpdateSize(panel);
            foreach (Enemy e in enemies)
            {
                if (!player.GetPictureBox().Bounds.IntersectsWith(e.GetPictureBox().Bounds))
                {
                    e.Move(panel);
                }
                e.UpdateSize(panel);
            }
        }
    }
}
