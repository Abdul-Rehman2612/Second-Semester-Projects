using GameLibrary.GL.Enum;
using GameLibrary.GL.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.GL.Fire
{
    public class FireMovement : IMovement
    {
        private int Speed;
        private Direction Direction;
        public FireMovement(int speed, Direction direction)
        {
            this.Speed = speed;
            this.Direction = direction;
        }
        public Point Move(Point location)
        {
            if (Direction == Direction.Left)
                location.X -= Speed;
            else if (Direction == Direction.Right)
                location.X += Speed;
            else if (Direction == Direction.Up)
                location.Y -= Speed;
            else if (Direction == Direction.Down)
                location.Y += Speed;
            return location;
        }
    }
}