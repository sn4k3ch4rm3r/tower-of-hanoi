using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_of_Hanoi.Components
{
    public class RoundedRectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Radius { get; set; }

        public RoundedRectangle(int x, int y, int width, int height, int radius)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Radius = radius;
        }
    }
}
