using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Reaction
{
    public partial class frmMain : Form
    {
        int totalRound = 10;
        int clickNum = -1;
        int reactionTime = 0;
        int waiting = 0;
        int minWaiting = 1;
        int maxWaiting = 3;
        Random rnd = new Random();

        Stopwatch watch = new Stopwatch();

        public frmMain()
        {
            InitializeComponent();
        }

        private void showPic(int n)
        {
            pcbOne.Visible = (n == 1);
            pcbTwo.Visible = (n == 2);
            pcbThree.Visible = (n == 3);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (clickNum < 0)
                return;
            if (waiting > 0)
            {
                waiting--;
                if (waiting == 0)
                {
                    showPic(rnd.Next(1, 4));
                    watch.Restart();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            clickNum = 0;
            reactionTime = 0;
            btnStart.Enabled = false;
            tmr.Enabled = true;
            nextRound();
        }

        private void nextRound()
        {
            showPic(0);
            clickNum++;
            waiting = rnd.Next(minWaiting * 1000 / tmr.Interval, (maxWaiting + 1) * 1000 / tmr.Interval);
        }

        private void picClick(object sender, EventArgs e)
        {
            watch.Stop();
            reactionTime += (int)watch.ElapsedMilliseconds;
            if (clickNum >= totalRound)
                showResult();
            else
                nextRound();
        }

        private void showResult()
        {
            double sec = reactionTime / 1000.0 / totalRound;
            MessageBox.Show("Среднее время реакции: " + sec.ToString("0.000") + " сек.", "Результат");
            btnStart.Enabled = true;
            clickNum = -1;
        }
    }
}
