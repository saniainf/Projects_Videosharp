using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagGame
{
    class GameBoard
    {
        static public Size Range { get; private set; }
        static Random rnd = new Random();
        PictureBox pcbMain;
        Graphics graph;

        public GameBoard(PictureBox pcb)
        {
            pcbMain = pcb;
            Range = pcbMain.Size;
            pcbMain.Image = new Bitmap(Range.Width, Range.Height);
            graph = Graphics.FromImage(pcbMain.Image);
            Clear();
        }

        public void Clear()
        {
            graph.Clear(pcbMain.BackColor);
        }

        public void Show(IPlayer p)
        {
            if (p is Circle)
                Show((Circle)p);
            if (p is Box)
                Show((Box)p);
        }

        public void Show(Circle c)
        {
            Pen pen = new Pen(c.ColorC, 2f);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graph.DrawEllipse(pen, c.CenterC.X - c.RadiusC, c.CenterC.Y - c.RadiusC, c.RadiusC * 2, c.RadiusC * 2);
        }

        public void Show(Box b)
        {
            Pen pen = new Pen(b.ColorB, 2f);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graph.DrawRectangle(pen, b.RectB);
        }

        public void Refresh()
        {
            pcbMain.Refresh();
        }

        static public Circle NewCircle()
        {
            int r = rnd.Next(Range.Width / 50, Range.Height / 20);
            int x = rnd.Next(r, Range.Width - r);
            int y = rnd.Next(r, Range.Height - r);
            int sx = rnd.Next(-5, 6);
            int sy = rnd.Next(-5, 6);
            return new Circle(x, y, r, sx, sy);
        }

        static public Box NewBox()
        {
            int width = rnd.Next(Range.Width / 30, Range.Width / 10);
            int height = rnd.Next(Range.Height / 30, Range.Height / 10);
            int x = rnd.Next(0, Range.Width - width);
            int y = rnd.Next(0, Range.Height - height);
            int sx = rnd.Next(-5, 6);
            int sy = rnd.Next(-5, 6);
            return new Box(x, y, width, height, sx, sy);
        }

        static public bool Intersect(IPlayer p1, IPlayer p2)
        {
            if (p1 is Box && p2 is Box)
            {
                return ((Box)p1).RectB.IntersectsWith(((Box)p2).RectB);
            }

            if (p1 is Circle && p2 is Circle)
            {
                return intersect((Circle)p1, ((Circle)p2));
            }

            if (p1 is Circle && p2 is Box)
            {
                return intersect((Circle)p1, (Box)p2);
            }

            if (p1 is Box && p2 is Circle)
            {
                return intersect((Circle)p2, (Box)p1);
            }

            return false;
        }

        static private bool intersect(Circle c, Box b)
        {
            int x = c.CenterC.X - c.RadiusC;
            int y = c.CenterC.Y - c.RadiusC;
            int wh = c.RadiusC * 2;
            Rectangle rect = new Rectangle(x, y, wh, wh);
            if (!(rect.IntersectsWith(b.RectB)))
                return false;
            return
                c.RadiusC >= distance(c.CenterC, new Point(b.RectB.Left, b.RectB.Top)) ||
                c.RadiusC >= distance(c.CenterC, new Point(b.RectB.Left, b.RectB.Bottom)) ||
                c.RadiusC >= distance(c.CenterC, new Point(b.RectB.Right, b.RectB.Top)) ||
                c.RadiusC >= distance(c.CenterC, new Point(b.RectB.Right, b.RectB.Bottom));
        }

        static private bool intersect(Circle c1, Circle c2)
        {
            return (distance(c1.CenterC, c2.CenterC) < c1.RadiusC + c2.RadiusC);
        }

        static private int distance(Point p1, Point p2)
        {
            return Convert.ToInt16(Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y)));
        }
    }
}
