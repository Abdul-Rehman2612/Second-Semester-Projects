using GameLibrary.GL.Enum;
using System.Drawing;
using GameLibrary.GL.Interfaces;

namespace GameLibrary.GL.Movement
{
    public class ZigZagMovement : IMovement
    {
        private readonly int speedX;
        private readonly int speedY;
        private readonly Point boundary;
        private readonly int width;
        private readonly int height;
        private Direction direction;
        public ZigZagMovement(int speedX, int speedY, Point boundary, int width, int height, Direction direction)
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
            if (direction != Direction.DiagUpRight && direction != Direction.DiagUpLeft && direction != Direction.DiagDownRight && direction != Direction.DiagDownLeft)
            {
                direction = Direction.DiagDownRight;
            }
        }
        public Point Move(Point location)
        {
            if (direction == Direction.DiagUpRight && location.X + width + speedX < boundary.X && location.Y - speedY > 0)
            {
                location.X+=speedX;
                location.Y-=speedY;
                return location;
            }
            if (direction == Direction.DiagUpLeft && location.X - speedX > 0 && location.Y - speedY > 0)
            {
                location.X-=speedX;
                location.Y-=speedY;
                return location;
            }
            if (direction == Direction.DiagDownRight && location.X + width + speedX < boundary.X && location.Y + height + speedY < boundary.Y)
            {
                location.X+=speedX;
                location.Y+=speedY;
                return location;
            }
            if (direction == Direction.DiagDownLeft && location.X - speedX > 0 && location.Y + height + speedY < boundary.Y)
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
            if (direction == Direction.DiagUpRight)
            {
                if (p.X + width + speedX < boundary.X && p.Y - speedY < 0)
                {
                    direction = Direction.DiagDownRight;
                }
                if (p.X + width + speedX > boundary.X && p.Y - speedY > 0)
                {
                    direction = Direction.DiagUpLeft;
                }
            }
            if (direction == Direction.DiagUpLeft)
            {
                if (p.X - speedX > 0 && p.Y - speedY < 0)
                {
                    direction = Direction.DiagDownLeft;
                }
                if (p.X - speedX < 0 && p.Y - speedY > 0)
                {
                    direction = Direction.DiagUpRight;
                }
            }
            if (direction == Direction.DiagDownLeft)
            {
                if (p.X - speedX > 0 && p.Y + height + speedY > boundary.Y)
                {
                    direction = Direction.DiagUpLeft;
                }
                if (p.X - speedX < 0 && p.Y + height + speedY < boundary.Y)
                {
                    direction = Direction.DiagDownRight;
                }
            }
            if (direction == Direction.DiagDownRight)
            {
                if (p.X + width + speedX > boundary.X && p.Y + height + speedY < boundary.Y)
                {
                    direction = Direction.DiagDownLeft;
                }
                if (p.X + width + speedX < boundary.X && p.Y + height + speedY > boundary.Y)
                {
                    direction = Direction.DiagUpRight;
                }
            }
        }
    }
}
