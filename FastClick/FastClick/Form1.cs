using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastClick
{
    public partial class frmMain : Form
    {
        long timeStart;
        long timeStop;
        int maxCounter = 10;
        int counter;
        string mode = "stop";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void startGame()
        {
            if (mode == "play")
                return;
            mode = "play";
            counter = maxCounter;
            lblCounter.Text = counter.ToString();
            lblResult.Text = "";
            btnStart.Enabled = false;
        }

        private void playGame()
        {
            if (mode == "stop")
                return;
            if (counter == maxCounter)
                timeStart = DateTime.Now.Ticks;
            if (counter > 0)
                counter--;
            lblCounter.Text = counter.ToString();
            if (counter == 0)
                stopGame();
        }

        private void stopGame()
        {
            mode = "stop";
            timeStop = DateTime.Now.Ticks;
            double seconds = TimeSpan.FromTicks(timeStop - timeStart).TotalSeconds;
            double clicksPerSeconds = maxCounter / seconds;
            lblResult.Text = clicksPerSeconds.ToString("#.#") + " кликов за секунду";
            btnStart.Enabled = true;
        }

        private void lblCounter_Click(object sender, EventArgs e)
        {
            playGame();
        }

        private void lblCounter_MouseDown(object sender, MouseEventArgs e)
        {
            playGame();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа написана мной.\n\nИ она работает.");
        }
    }
}
