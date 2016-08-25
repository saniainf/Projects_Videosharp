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
        public int SX, SY;

        public Box(int x, int y, int width, int height)
            : this(x, y, width, height, 0, 0)
        {
        }

        public Box(int x, int y, int width, int height, int sx, int sy)
        {
            RectB = new Rectangle(x, y, width, height);
            ColorB = Color.Green;
            this.SX = sx;
            this.SY = sy;
        }


        public void Run()
        {
            int x = RectB.X + SX;
            int y = RectB.Y + SY;
            if (x < 0 || x > GameBoard.Range.Width - RectB.Width)
                SX = -SX;
            if (y < 0 || y > GameBoard.Range.Height - RectB.Height)
                SY = -SY;
            RectB = new Rectangle(RectB.X + SX, RectB.Y + SY, RectB.Width, RectB.Height);
        }

        public void TaggedIt()
        {
            ColorB = Color.Red;
        }

        public void NoTaggedIt()
        {
            ColorB = Color.Green;
        }

        public bool Touching(IPlayer player)
        {
            return GameBoard.Intersect(this, player);
        }
    }
}
