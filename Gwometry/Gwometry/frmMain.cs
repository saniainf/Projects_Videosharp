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
        }

        private void Draw()
        {
            graph.DrawRectangle(pen, 100, 100, 300, 200);
            graph.DrawRectangle(pen, 200, 150, 100, 100);
            graph.DrawLine(pen, 250, 150, 250, 250);
            graph.DrawLine(pen, 250, 200, 300, 200);
            Draw(line1);
            Draw(line2);
            pcbMain.Image = bmp;
        }

        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.X1, line.Y1, line.X2, line.Y2);
        }
    }
}
