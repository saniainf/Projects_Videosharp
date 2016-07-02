using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretPicture
{
    public partial class FormSecretPicture : Form
    {
        int secterNr = 0;

        public FormSecretPicture()
        {
            InitializeComponent();
        }

        private void buttonShow1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._1_janapanfilova;
        }

        private void buttonShow2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._10_alanhall_southtoerivercarolinahemlockscampgroundnc;
        }

        private void buttonShow3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._11_graceeggleston_throwingrockslakemichigansunset;
        }

        private void buttonShow4_Click(object sender, EventArgs e)
        {
            if (secterNr == 2)
            {
                this.BackgroundImage = Properties.Resources._3_bing_kaneohebay1920x1200;
                secterNr = 0;
            }
            else
                this.BackgroundImage = Properties.Resources._12_alexabrown_leaveswater;
        }

        private void FormSecretPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                secterNr = 1;
        }

        private void FormSecretPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (secterNr == 1)
                if (e.X < buttonShow1.Location.X && e.Y < buttonShow1.Location.Y)
                    secterNr = 2;

        }
    }
}
