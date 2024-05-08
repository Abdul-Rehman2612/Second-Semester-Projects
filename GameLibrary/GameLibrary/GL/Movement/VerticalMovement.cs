using GameLibrary.GL.Enum;
using GameLibrary.GL.Interfaces;

namespace GameLibrary.GL.Movement
{
    public class VerticalMovement : IMovement
    {
        private readonly int speed;
        private System.Drawing.Point boundary;
        private readonly int height;
        private Direction direction;
        public VerticalMovement(int speed, System.Drawing.Point boundary, int height, Direction direction)
        {
            this.speed=speed;
            this.boundary=boundary;
            this.height = height;
            this.direction = direction;
            CheckDirection();
        }
        private void CheckDirection()
        {
            if (direction !=Direction.Up && direction != Direction.Down)
            {
                direction= Direction.Down;
            }
        }
        public System.Drawing.Point Move(System.Drawing.Point location)
        {
            if (location.Y + height + speed < boundary.Y && direction == Direction.Down)
            {
                location.Y += speed;
            }
            else if (location.Y + height + speed >= boundary.Y)
            {
                ChangeDirection();
            }
            if (location.Y - speed > 0 && direction == Direction.Up)
            {
                location.Y -= speed;
            }
            else if (location.Y - speed <= 0)
            {
                ChangeDirection();
            }
            return location;
        }
        private void ChangeDirection()
        {
            if (direction == Direction.Up)
            {
                direction = Direction.Down;
            }
            else if (direction == Direction.Down)
            {
                direction = Direction.Up;
            }
        }
    }
}
