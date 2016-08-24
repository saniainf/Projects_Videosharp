using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagGame
{
    class Box : IPlayer
    {
        public Rectangle RectB { get; private set; }
        public Color ColorB { get; private set; }
        int sx, sy;

        public Box(int x, int y, int width, int height)
            : this(x, y, width, height, 0, 0)
        {
        }

        public Box(int x, int y, int width, int height, int sx, int sy)
        {
            RectB = new Rectangle(x, y, width, height);
            ColorB = Color.Green;
            this.sx = sx;
            this.sy = sy;
        }


        public void Run()
        {
            int x = RectB.X + sx;
            int y = RectB.Y + sy;
            if (x < 0 || x > GameBoard.Range.Width - RectB.Width)
                sx = -sx;
            if (y < 0 || y > GameBoard.Range.Height - RectB.Height)
                sy = -sy;
            RectB = new Rectangle(RectB.X + sx, RectB.Y + sy, RectB.Width, RectB.Height);
        }

        public void TaggedIt()
        {
            ColorB = Color.Red;
        }

        public void NoTaggedIt()
        {
            ColorB = Color.White;
        }

        public bool Touching(IPlayer player)
        {
            return GameBoard.Intersect(this, player);
        }
    }
}
