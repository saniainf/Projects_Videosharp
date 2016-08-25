using System;
using System.Drawing;

namespace TagGame
{
    class Circle : IPlayer
    {
        public Point CenterC { get; private set; }
        public int RadiusC { get; private set; }
        public Color ColorC { get; private set; }
        public int SX, SY;

        public Circle(int x, int y, int r)
            : this(x, y, r, 0, 0)
        {
        }

        public Circle(int x, int y, int r, int sx, int sy)
        {
            CenterC = new Point(x, y);
            RadiusC = r;
            ColorC = Color.Blue;
            this.SX = sx;
            this.SY = sy;
        }

        public void Run()
        {
            int x = CenterC.X + SX;
            int y = CenterC.Y + SY;
            if (x < RadiusC || x > GameBoard.Range.Width - RadiusC)
                SX = -SX;
            if (y < RadiusC || y > GameBoard.Range.Height - RadiusC)
                SY = -SY;
            CenterC = new Point(CenterC.X + SX, CenterC.Y + SY);
        }

        public void TaggedIt()
        {
            ColorC = Color.Red;
        }

        public void NoTaggedIt()
        {
            ColorC = Color.Blue;
        }

        public bool Touching(IPlayer player)
        {
            return GameBoard.Intersect(this, player);
        }
    }
}
