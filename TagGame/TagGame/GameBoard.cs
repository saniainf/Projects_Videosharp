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

        public void Show(Circle c)
        {
            Pen pen = new Pen(c.ColorC, 2f);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graph.DrawEllipse(pen, c.CenterC.X - c.RadiusC, c.CenterC.Y - c.RadiusC, c.RadiusC * 2, c.RadiusC * 2);
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
    }
}
