using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    public partial class frmMain : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        int clicks = 0;

        public frmMain()
        {
            InitializeComponent();
            trbCount_Scroll(null, null);
            trbTime_Scroll(null, null);

        }

        private void trbCount_Scroll(object sender, EventArgs e)
        {
            lblShowCount.Text = trbCount.Value.ToString() + " кликов";
            prbCount.Maximum = trbCount.Value;
        }

        private void trbTime_Scroll(object sender, EventArgs e)
        {
            lblShowTime.Text = trbTime.Value.ToString() + " мс";
        }

        private void tmrClick_Tick(object sender, EventArgs e)
        {
            makeClick();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startClicker();
        }

        private void startClicker()
        {
            clicks = trbCount.Value;
            btnStart.Enabled = false;
            tmrClick.Interval = trbTime.Value;
            tmrClick.Enabled = true;
        }

        private void makeClick()
        {
            clicks--;
            prbCount.Value = clicks;
            DoMouseClick();
            if (clicks == 0)
                stopClicker();
        }

        private void stopClicker()
        {
            tmrClick.Enabled = false;
            btnStart.Enabled = true;
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
    }
}
