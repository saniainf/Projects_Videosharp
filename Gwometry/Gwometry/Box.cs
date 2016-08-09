
using System;
namespace Gwometry
{
    class Box
    {
        public Pixel leftTop;
        public Pixel rightBot;
        public int width;
        public int height;

        public Box(int x1, int y1, int x2, int y2)
            : this(new Pixel(x1, y1), new Pixel(x2, y2))
        {

        }

        public Box(Pixel leftTop, Pixel rightBot)
        {
            this.leftTop = leftTop;
            this.rightBot = rightBot;
            this.width = Math.Abs(leftTop.X - rightBot.X);
            this.height = Math.Abs(rightBot.Y - leftTop.Y);
        }
    }
}
