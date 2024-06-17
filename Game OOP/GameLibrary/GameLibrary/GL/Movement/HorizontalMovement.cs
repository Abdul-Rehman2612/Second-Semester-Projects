using GameLibrary.GL.Enum;
using GameLibrary.GL.Interfaces;

namespace GameLibrary.GL.Movement
{
    public class HorizontalMovement : IMovement
    {
        private int speed;
        private System.Drawing.Point boundary;
        private int width;
        private Direction direction;
        public HorizontalMovement(int speed, System.Drawing.Point boundary, int width, Direction direction)
        {
            this.speed=speed;
            this.boundary=boundary;
            this.width = width;
            this.direction = direction;
            CheckDirection();
        }
        private void CheckDirection()
        {
            if (direction !=Direction.Right && direction !=Direction.Left)
            {
                direction=Direction.Left;
            }
        }
        public System.Drawing.Point Move(System.Drawing.Point location)
        {
            if (location.X +width + speed < boundary.X && direction == Direction.Right)
            {
                location.X += speed;
            }
            else if (location.X +width + speed >= boundary.X)
            {
                ChangeDirection();
            }
            if (location.X - speed > 0 && direction == Direction.Left)
            {
                location.X -= speed;
            }
            else if (location.X - speed <= 0)
            {
                ChangeDirection();
            }
            return location;
        }
        private void ChangeDirection()
        {
            if (direction == Direction.Right)
            {
                direction = Direction.Left;
            }
            else if (direction == Direction.Left)
            {
                direction = Direction.Right;
            }
        }
    }
}
