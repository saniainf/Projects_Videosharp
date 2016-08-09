using System;

namespace Gwometry
{
    public struct Pixel
    {
        public int X;
        public int Y;

        public Pixel(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int distance(Pixel point)
        {
            return Convert.ToInt32(Math.Sqrt((X - point.X) * (X - point.X) + (Y - point.Y) * (Y - point.Y)));
        }
    }
}
