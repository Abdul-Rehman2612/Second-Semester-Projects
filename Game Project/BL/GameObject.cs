using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Game_Project
{
    internal class GameObject
    {
        public Image Image { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public bool FallUnderGravity { get; set; }

        public GameObject(Image image, float x, float y, bool fallUnderGravity)
        {
            Image = image;
            X = x;
            Y = y;
            FallUnderGravity = fallUnderGravity;
        }
    }
}
