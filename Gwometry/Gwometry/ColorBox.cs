using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwometry
{
    class ColorBox
    {
        public Pixel leftTop;
        public Pixel rightBot;
        public int width;
        public int height;
        public Pen pen;

        public ColorBox(int x1, int y1, int x2, int y2, Color color)
            : this(new Pixel(x1, y1), new Pixel(x2, y2), color)
        {

        }

        public ColorBox(Pixel leftTop, Pixel rightBot, Color color)
        {
            this.leftTop = leftTop;
            this.rightBot = rightBot;
            this.width = Math.Abs(leftTop.X - rightBot.X);
            this.height = Math.Abs(rightBot.Y - leftTop.Y);
            pen = new Pen(color);
        }
    }
}
