using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwometry
{
    class Box
    {
        public int X1, Y1;
        public int X2, Y2;
        public int width;
        public int height;

        public Box(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            width = x2 - x1;
            height = y2 - y1;
        }
    }
}
