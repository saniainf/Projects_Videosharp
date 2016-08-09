using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStruct
{
    class Program
    {
        struct StructPixel
        {
            public int x;
            public int y;
            public StructPixel(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        class ClassPixel
        {
            public int x;
            public int y;
            public ClassPixel(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            StructPixel sp;
            ClassPixel cp;
            sp = new StructPixel(10, 20);
            cp = new ClassPixel(100, 200);
            movePixel(ref sp);
            movePixel(cp);
        }

        static void movePixel(ref StructPixel sp)
        {
            sp.x++;
            sp.y++;
        }

        static void movePixel(ClassPixel cp)
        {
            cp.x++;
            cp.y++;
        }
    }
}
