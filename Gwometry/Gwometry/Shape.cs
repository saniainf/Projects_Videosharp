using System.Drawing;

namespace Gwometry
{
    abstract class Shape
    {
        protected Pixel position;

        protected Graphics graph;
        protected Pen pen;

        public Shape()
        {
            pen = new Pen(Color.Black);
        }

        public void setGraphics(Graphics g)
        {
            graph = g;
        }

        abstract public void Draw();

        virtual public void Move(Pixel p)
        {
            position = p;
        }
    }
}
