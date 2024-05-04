namespace GameLibrary.GL.Movement
{
    public class HorizontalMovement : IMovement
    {
        private int speed;
        private System.Drawing.Point boundary;
        private int width;
        private string direction;
        public HorizontalMovement(int speed, System.Drawing.Point boundary, int width, string direction)
        {
            this.speed=speed;
            this.boundary=boundary;
            this.width = width;
            this.direction = direction;
            CheckDirection();
        }
        private void CheckDirection()
        {
            if (direction !="Right" && direction !="Left")
            {
                direction="Left";
            }
        }
        public System.Drawing.Point Move(System.Drawing.Point location)
        {
            if (location.X +width + speed < boundary.X && direction == "Right")
            {
                location.X += speed;
            }
            else if (location.X +width + speed >= boundary.X)
            {
                ChangeDirection();
            }
            if (location.X - speed > 0 && direction == "Left")
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
            if (direction =="Right")
            {
                direction = "Left";
            }
            else if (direction == "Left")
            {
                direction = "Right";
            }
        }
    }
}
