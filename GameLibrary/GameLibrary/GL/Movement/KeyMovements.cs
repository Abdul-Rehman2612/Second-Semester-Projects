﻿using EZInput;

namespace GameLibrary.GL.Movement
{
    public class KeyMovements : IMovement
    {
        private readonly int speed;
        private readonly System.Drawing.Point boundary;
        private readonly int width;
        private readonly int height;
        public KeyMovements(int speed, System.Drawing.Point boundary, int width, int height)
        {
            this.speed=speed;
            this.boundary=boundary;
            this.width=width;
            this.height=height;
        }
        public System.Drawing.Point Move(System.Drawing.Point Location)
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                if (Location.X - speed > 0)
                    Location.X -= speed;
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                if (Location.X + width + speed < boundary.X)
                    Location.X += speed;
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                if (Location.Y - speed > 0)
                    Location.Y -= speed;
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                if (Location.Y + height + speed < boundary.Y)
                    Location.Y += speed;
            }
            return Location;
        }
    }
}
