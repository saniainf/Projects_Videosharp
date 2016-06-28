using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrint2D
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSound_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSound.Checked)
            {
                cbSound.Text = "Звук включен";
                Sound.soundOn();
            }
            else
            {
                cbSound.Text = "Звук выключен";
                Sound.soundOff();
            }
            Sound.playKey();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Sound.playStart();
        }
    }
}
