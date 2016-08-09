using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwometry
{
    class ColorCircle
    {
        public Pixel center;
        public Pixel leftTop;
        public int radius;
        public int width;
        public int height;
        public Pen pen;

        public ColorCircle(int x, int y, int radius, Color color)
            : this(new Pixel(x, y), radius, color)
        {
        }

        public ColorCircle(Pixel center, Pixel point, Color color)
            : this(center, center.distance(point), color)
        {
        }

        public ColorCircle(Pixel center, int radius, Color color)
        {
            this.center = center;
            this.radius = radius;
            this.leftTop = new Pixel(center.X - radius, center.Y - radius);
            width = radius * 2;
            height = radius * 2;
            pen = new Pen(color);
        }
    }
}
