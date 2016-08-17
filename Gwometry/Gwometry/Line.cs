
namespace Gwometry
{
    class Line : Shape
    {
        public Pixel begin;
        public Pixel ended;

        public Line(int x1, int y1, int x2, int y2)
            : this(new Pixel(x1, y1), new Pixel(x2, y2))
        {
        }

        public Line(Pixel begin, Pixel ended)
        {
            this.begin = begin;
            this.ended = ended;
        }

        override public void Draw()
        {
            graph.DrawLine(pen, begin.X + position.X, begin.Y + position.Y, ended.X + position.X, ended.Y + position.Y);
        }
    }
}
