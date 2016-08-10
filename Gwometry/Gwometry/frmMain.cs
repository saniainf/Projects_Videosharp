using System.Drawing;
using System.Windows.Forms;

namespace Gwometry
{
    public partial class frmMain : Form
    {
        Bitmap bmp;
        Graphics graph;
        Pen pen;

        Line line1;
        Line line2;
        Box box1;
        Box box2;
        Circle circle1;
        Circle circle2;
        Circle circle3;

        ColorLine line21;
        ColorLine line22;
        ColorBox box21;
        ColorBox box22;
        ColorCircle circle21;
        ColorCircle circle22;
        ColorCircle circle23;

        Pixel A, B, C, D, E, F, G, H, I, J, K, L, M;

        public frmMain()
        {
            InitializeComponent();
            Init();
            InitSnowMan1();
            InitSnowMan2();
            Draw();
        }

        private void Init()
        {
            bmp = new Bitmap(pcbMain.Width, pcbMain.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue, 2f);
        }

        private void InitSnowMan1()
        {
            A = new Pixel(300, 60);
            B = new Pixel(300, 210);
            C = new Pixel(300, 460);
            D = new Pixel(300, 110);
            E = new Pixel(300, 310);
            F = new Pixel(220, 150);
            G = new Pixel(50, 300);
            H = new Pixel(380, 150);
            I = new Pixel(550, 300);
            J = new Pixel(150, 575);
            K = new Pixel(203, 620);
            L = new Pixel(397, 575);
            M = new Pixel(450, 620);

            circle1 = new Circle(A, D);
            circle2 = new Circle(B, D);
            circle3 = new Circle(C, E);

            line1 = new Line(F, G);
            line2 = new Line(H, I);

            box1 = new Box(J, K);
            box2 = new Box(L, M);
        }

        private void InitSnowMan2()
        {
            int offset = 400;
            A = new Pixel(offset + 300, 60);
            B = new Pixel(offset + 300, 210);
            C = new Pixel(offset + 300, 460);
            D = new Pixel(offset + 300, 110);
            E = new Pixel(offset + 300, 310);
            F = new Pixel(offset + 220, 150);
            G = new Pixel(offset + 50, 300);
            H = new Pixel(offset + 380, 150);
            I = new Pixel(offset + 550, 300);
            J = new Pixel(offset + 150, 575);
            K = new Pixel(offset + 203, 620);
            L = new Pixel(offset + 397, 575);
            M = new Pixel(offset + 450, 620);

            circle21 = new ColorCircle(A, D, Color.Red);
            circle22 = new ColorCircle(B, D, Color.Orange);
            circle23 = new ColorCircle(C, E, Color.Green);

            line21 = new ColorLine(F, G, Color.Orange);
            line22 = new ColorLine(H, I, Color.Orange);

            box21 = new ColorBox(J, K, Color.Black);
            box22 = new ColorBox(L, M, Color.Black);
        }

        private void Draw()
        {
            Draw(line1);
            Draw(line2);
            Draw(box1);
            Draw(box2);
            Draw(circle1);
            Draw(circle2);
            Draw(circle3);

            Draw(line21);
            Draw(line22);
            Draw(box21);
            Draw(box22);
            Draw(circle21);
            Draw(circle22);
            Draw(circle23);

            pcbMain.Image = bmp;
        }

        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.begin.X, line.begin.Y, line.ended.X, line.ended.Y);
        }

        private void Draw(ColorLine colorLine)
        {
            graph.DrawLine(colorLine.pen, colorLine.begin.X, colorLine.begin.Y, colorLine.ended.X, colorLine.ended.Y);
        }

        private void Draw(Box box)
        {
            graph.DrawRectangle(pen, box.leftTop.X, box.leftTop.Y, box.width, box.height);
        }

        private void Draw(ColorBox colorBox)
        {
            graph.DrawRectangle(colorBox.pen, colorBox.leftTop.X, colorBox.leftTop.Y, colorBox.width, colorBox.height);
        }

        private void Draw(Circle circle)
        {
            graph.DrawEllipse(pen, circle.leftTop.X, circle.leftTop.Y, circle.width, circle.height);
        }

        private void Draw(ColorCircle colorCircle)
        {
            graph.DrawEllipse(colorCircle.pen, colorCircle.leftTop.X, colorCircle.leftTop.Y, colorCircle.width, colorCircle.height);
        }
    }
}
