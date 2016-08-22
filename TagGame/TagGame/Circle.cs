using System.Drawing;

namespace TagGame
{
    class Circle
    {
        public Point CenterC { get; private set; }
        public int RadiusC { get; private set; }
        public Color ColorC { get; private set; }

        public Circle(int x, int y, int r)
        {
            CenterC = new Point(x, y);
            RadiusC = r;
            ColorC = Color.Blue;
        }

    }
}
