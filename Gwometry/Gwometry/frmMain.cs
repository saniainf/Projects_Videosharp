using System.Drawing;
using System.Windows.Forms;

namespace Gwometry
{
    public partial class frmMain : Form
    {
        Bitmap bmp;
        Graphics graph;
        Pen pen;

        Line roofLeft;
        Line roofRight;
        ColorLine colorLine1;
        ColorLine colorLine2;
        Box houseWall;
        ColorBox houseWindow;
        Circle roofWindow;
        ColorCircle circle1;

        Pixel A, B, C, D, E, O, center;

        public frmMain()
        {
            InitializeComponent();
            Init();
            Draw();
        }

        private void Init()
        {
            bmp = new Bitmap(pcbMain.Width, pcbMain.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue, 2f);

            A = new Pixel(100, 300);
            B = new Pixel(400, 300);
            C = new Pixel(100, 100);
            D = new Pixel(400, 100);
            E = new Pixel(250, 10);
            O = new Pixel(250, 55);
            center = new Pixel(250, 200);

            roofLeft = new Line(C, E);
            roofRight = new Line(E, D);
            houseWall = new Box(C, B);
            roofWindow = new Circle(O, 20);
            houseWindow = new ColorBox(200, 150, 300, 250, Color.Turquoise);
            colorLine1 = new ColorLine(A, D, Color.Red);
            colorLine2 = new ColorLine(C, B, Color.Red);
            circle1 = new ColorCircle(center, B, Color.Purple);
        }

        private void Draw()
        {
            Draw(roofLeft);
            Draw(roofRight);
            Draw(colorLine1);
            Draw(colorLine2);
            Draw(houseWall);
            Draw(houseWindow);
            Draw(roofWindow);
            Draw(circle1);

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
