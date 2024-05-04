namespace GameLibrary.GL.Movement
{
    public class VerticalMovement : IMovement
    {
        private readonly int speed;
        private System.Drawing.Point boundary;
        private readonly int height;
        private string direction;
        public VerticalMovement(int speed, System.Drawing.Point boundary, int height, string direction)
        {
            this.speed=speed;
            this.boundary=boundary;
            this.height = height;
            this.direction = direction;
            CheckDirection();
        }
        private void CheckDirection()
        {
            if (direction !="Up" && direction !="Down")
            {
                direction="Down";
            }
        }
        public System.Drawing.Point Move(System.Drawing.Point location)
        {
            if (location.Y + height + speed < boundary.Y && direction == "Down")
            {
                location.Y += speed;
            }
            else if (location.Y + height + speed >= boundary.Y)
            {
                ChangeDirection();
            }
            if (location.Y - speed > 0 && direction == "Up")
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
            if (direction =="Up")
            {
                direction = "Down";
            }
            else if (direction == "Down")
            {
                direction = "Up";
            }
        }
    }
}
