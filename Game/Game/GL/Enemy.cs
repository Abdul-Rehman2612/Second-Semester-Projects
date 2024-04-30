using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game.GL
{
    public abstract class Enemy : GameObject
    {
        protected string direction;
        public Enemy(Form form, Image image, int x, int y, int speed, string direction) : base(form, image, x, y, speed)
        {
            this.direction=direction;
        }
        public Enemy(Panel panel, Image image, int x, int y, int speed, string direction) : base(panel, image, x, y, speed)
        {
            this.direction=direction;
        }
        public abstract void Move(Form form);
        public abstract void Move(Panel panel);
    }
}
