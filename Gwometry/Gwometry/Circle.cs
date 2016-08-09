using System;

namespace Gwometry
{
    class Circle
    {
        public Pixel center;
        public Pixel leftTop;
        public int radius;

        public int width { get; set; }
        public int height { get; set; }

        public Circle(int x, int y, int radius)
            : this(new Pixel(x, y), radius)
        {
        }

        public Circle(Pixel center, int radius)
        {
            this.center = center;
            this.radius = radius;
            this.leftTop = new Pixel(center.X - radius, center.Y - radius);
            width = radius * 2;
            height = radius * 2;
        }

        public Circle(Pixel center, Pixel point)
            : this(center, center.distance(point))
        {
        }
    }
}
