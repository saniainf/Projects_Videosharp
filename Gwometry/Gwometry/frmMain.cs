using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        Line line3;
        Line line4;
        Box box1;
        Box box2;

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

            line1 = new Line(100, 100, 250, 10);
            line2 = new Line(250, 10, 400, 100);
            line3 = new Line(250, 150, 250, 250);
            line4 = new Line(250, 200, 300, 200);
            box1 = new Box(100, 100, 400, 300);
            box2 = new Box(200, 150, 300, 250);
        }

        private void Draw()
        {
            Draw(line1);
            Draw(line2);
            Draw(line3);
            Draw(line4);
            Draw(box1);
            Draw(box2);

            pcbMain.Image = bmp;
        }

        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.X1, line.Y1, line.X2, line.Y2);
        }

        private void Draw(Box box)
        {
            graph.DrawRectangle(pen, box.X1, box.Y1, box.width, box.height);
        }
    }
}
