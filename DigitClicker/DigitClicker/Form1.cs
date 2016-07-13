using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DigitClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbX.Text = "";
            txbY.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int pointX;
            int pointY;
            pointX = Cursor.Position.X;
            pointY = Cursor.Position.Y;

            txbX.Text += pointX.ToString() + Environment.NewLine;
            txbY.Text += pointY.ToString() + Environment.NewLine;
        }

        public void DoMouseClick(int x, int y)
        {
            Cursor.Position = new Point(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            int pointX;
            int pointY;
            for (int j = 1; j <= 9; j++)
                for (int i = 0; i < txbX.Lines.Length - 1; i++)
                {
                    pointX = Convert.ToInt16(txbX.Lines[i]);
                    pointY = Convert.ToInt16(txbY.Lines[i]);
                    DoMouseClick(pointX, pointY);
                }
        }
    }
}
