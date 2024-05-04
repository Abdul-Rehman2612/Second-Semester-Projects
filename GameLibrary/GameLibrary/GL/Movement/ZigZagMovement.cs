using System;
using System.Drawing;

namespace GameLibrary.GL.Movement
{
    public class ZigZagMovement : IMovement
    {
        private readonly int speedX;
        private readonly int speedY;
        private readonly Point boundary;
        private readonly int width;
        private readonly int height;
        private string direction;

        public ZigZagMovement(int speedX, int speedY, Point boundary, int width, int height, string direction)
        {
            this.speedX = speedX;
            this.speedY = speedY;
            this.boundary = boundary;
            this.width = width;
            this.height = height;
            this.direction = direction;
            CheckDirection();
        }
        private void CheckDirection()
        {
            if (direction != "DiagUpRight" && direction != "DiagUpLeft" && direction != "DiagDownRight" && direction != "DiagDownLeft")
            {
                direction = "DiagDownRight";
            }
        }
        public Point Move(Point location)
        {
            if (direction == "DiagUpRight" && location.X + width + speedX < boundary.X && location.Y - speedY > 0)
            {
                location.X+=speedX;
                location.Y-=speedY;
                return location;
            }
            if (direction == "DiagUpLeft" && location.X - speedX > 0 && location.Y - speedY > 0)
            {
                location.X-=speedX;
                location.Y-=speedY;
                return location;
            }
            if (direction == "DiagDownRight" && location.X + width + speedX < boundary.X && location.Y + height + speedY < boundary.Y)
            {
                location.X+=speedX;
                location.Y+=speedY;
                return location;
            }
            if (direction == "DiagDownLeft" && location.X - speedX > 0 && location.Y + height + speedY < boundary.Y)
            {
                location.X-=speedX;
                location.Y+=speedY;
                return location;
            }
            ChangeDirection(location);
            return location;
        }
        private void ChangeDirection(Point p)
        {
            if (direction == "DiagUpRight")
            {
                if (p.X + width + speedX < boundary.X && p.Y - speedY < 0)
                {
                    direction = "DiagDownRight";
                }
                if (p.X + width + speedX > boundary.X && p.Y - speedY > 0)
                {
                    direction = "DiagUpLeft";
                }
            }
            if (direction == "DiagUpLeft")
            {
                if (p.X - speedX > 0 && p.Y - speedY < 0)
                {
                    direction = "DiagDownLeft";
                }
                if (p.X - speedX < 0 && p.Y - speedY > 0)
                {
                    direction = "DiagUpRight";
                }
            }
            if (direction == "DiagDownLeft")
            {
                if (p.X - speedX > 0 && p.Y + height + speedY > boundary.Y)
                {
                    direction = "DiagUpLeft";
                }
                if (p.X - speedX < 0 && p.Y + height + speedY < boundary.Y)
                {
                    direction = "DiagDownRight";
                }
            }
            if (direction == "DiagDownRight")
            {
                if (p.X + width + speedX > boundary.X && p.Y + height + speedY < boundary.Y)
                {
                    direction = "DiagDownLeft";
                }
                if (p.X + width + speedX < boundary.X && p.Y + height + speedY > boundary.Y)
                {
                    direction = "DiagUpRight";
                }
            }
        }
    }
}
