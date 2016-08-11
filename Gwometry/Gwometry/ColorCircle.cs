using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwometry
{
    class ColorCircle : Circle
    {
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
            :base (center, radius)
        {
            pen = new Pen(color);
        }
    }
}
