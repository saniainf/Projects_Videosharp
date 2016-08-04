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
        public frmMain()
        {
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pcbMain.Width, pcbMain.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue, 2f);
            graph.DrawRectangle(pen, 100, 100, 300, 200);
            graph.DrawRectangle(pen, 200, 150, 100, 100);
            graph.DrawLine(pen, 250, 150, 250, 250);
            graph.DrawLine(pen, 250, 200, 300, 200);
            graph.DrawLine(pen, 100, 100, 250, 10);
            graph.DrawLine(pen, 250, 10, 400, 100);
            pcbMain.Image = bmp;
        }
    }
}
