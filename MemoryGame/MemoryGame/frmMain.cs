using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class frmMain : Form
    {
        frmHelp frmHlp = new frmHelp();
        frmAbout frmAbt = new frmAbout();

        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuGameExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuHelpRules_Click(object sender, EventArgs e)
        {
            frmHlp.ShowDialog();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbt.ShowDialog();
        }
    }
}
