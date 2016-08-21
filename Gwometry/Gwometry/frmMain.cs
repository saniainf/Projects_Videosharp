using System.Drawing;
using System.Windows.Forms;

namespace Gwometry
{
    public partial class frmMain : Form
    {
        Bitmap bmp;
        Graphics graph;
        Pen pen;

        Sprite snowMan1;
        Sprite snowMan2;

        Pixel A, B, C, D, E, F, G, H, I, J, K, L, M;

        Circle c;
        Box b;
        Line l;

        public frmMain()
        {
            InitializeComponent();
            Init();
            InitSnowMan1();
            InitSnowMan2();
            Draw();

            //InitDemo();
        }

        private void Init()
        {
            bmp = new Bitmap(pcbMain.Width, pcbMain.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue, 2f);
        }

        private void InitDemo()
        {
            Pixel p = new Pixel(100, 100);
            A = new Pixel(0, 0);

            c = new Circle(A, 20);
            c.Move(p);
            c.setGraphics(graph);
            c.Draw();

            l = new Line(0, 20, 0, 100);
            l.setGraphics(graph);
            l.Move(p);
            l.Draw();

            b = new Box(-20, -20, 20, -40);
            b.setGraphics(graph);
            b.Move(p);
            b.Draw();

            pcbMain.Image = bmp;
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

            snowMan1 = new Sprite();
            snowMan1.setGraphics(graph);
            snowMan1.AddShape(new Circle(A, D));
            snowMan1.AddShape(new Circle(B, D));
            snowMan1.AddShape(new Circle(C, E));
            snowMan1.AddShape(new Line(F, G));
            snowMan1.AddShape(new Line(H, I));
            snowMan1.AddShape(new Box(J, K));
            snowMan1.AddShape(new Box(L, M));
        }

        private void InitSnowMan2()
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

            snowMan2 = new Sprite();
            snowMan2.setGraphics(graph);
            snowMan2.AddShape(new ColorCircle(A, D, Color.Red));
            snowMan2.AddShape(new ColorCircle(B, D, Color.Orange));
            snowMan2.AddShape(new ColorCircle(C, E, Color.Green));
            snowMan2.AddShape(new ColorLine(F, G, Color.Orange));
            snowMan2.AddShape(new ColorLine(H, I, Color.Orange));
            snowMan2.AddShape(new ColorBox(J, K, Color.Black));
            snowMan2.AddShape(new ColorBox(L, M, Color.Black));

            snowMan2.Move(new Pixel(400, 0));

        }

        private void Draw()
        {
            snowMan1.Draw();
            snowMan2.Draw();
            pcbMain.Image = bmp;
        }

        private void btnMove_Click(object sender, System.EventArgs e)
        {
            Pixel p = new Pixel(10, 2);
            snowMan1.Move(p);
            snowMan2.Move(new Pixel(410,2));
            Draw();
        }
    }
}
