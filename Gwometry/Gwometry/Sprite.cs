using System.Collections.Generic;

namespace Gwometry
{
    class Sprite : Shape
    {
        List<Shape> shapes;

        public Sprite()
        {
            shapes = new List<Shape>();
        }

        public void AddShape(Shape s)
        {
            s.setGraphics(graph);
            shapes.Add(s);
        }

        public void Clear()
        {
            shapes.Clear();
        }

        public override void Draw()
        {
            foreach (Shape ss in shapes)
                ss.Draw();
        }
    }
}
