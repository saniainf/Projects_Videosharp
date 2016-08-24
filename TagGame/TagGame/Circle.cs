using System;
using System.Drawing;

namespace TagGame
{
    class Circle : IPlayer
    {
        public Point CenterC { get; private set; }
        public int RadiusC { get; private set; }
        public Color ColorC { get; private set; }
        int sx, sy;

        public Circle(int x, int y, int r)
            : this(x, y, r, 0, 0)
        {
        }

        public Circle(int x, int y, int r, int sx, int sy)
        {
            CenterC = new Point(x, y);
            RadiusC = r;
            ColorC = Color.White;
            this.sx = sx;
            this.sy = sy;
        }

        public void Run()
        {
            int x = CenterC.X + sx;
            int y = CenterC.Y + sy;
            if (x < RadiusC || x > GameBoard.Range.Width - RadiusC)
                sx = -sx;
            if (y < RadiusC || y > GameBoard.Range.Height - RadiusC)
                sy = -sy;
            CenterC = new Point(CenterC.X + sx, CenterC.Y + sy);
        }

        public void TaggedIt()
        {
            ColorC = Color.Red;
        }

        public void NoTaggedIt()
        {
            ColorC = Color.White;
        }

        public bool Touching(IPlayer player)
        {
            return GameBoard.Intersect(this, player);
        }
    }
}
