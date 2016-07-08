using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid
{
    class Rectangle2
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Top { get { return Y; } }
        public int Bottom { get { return Y + Height; } }
        public int Left { get { return X; } }
        public int Right { get { return X + Width; } }
        public Point Center
        {
            get
            {
                return new Point(Left + Width / 2, Top + Height / 2);
            }
        }
        public Point Location
        {
            get
            {
                return new Point(X, Y);
            }
            set
            {

            }
        }

        public Rectangle2(int x, int y, int width, int height)
        {

        }

        public Rectangle2(Point location, int width, int height)
        {

        }
    }
}
