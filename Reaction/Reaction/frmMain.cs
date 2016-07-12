using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reaction
{
    public partial class frmMain : Form
    {
        int picN = 1;

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
            picN = picN < 3 ? picN + 1 : 1;
            showPic(picN);
        }
    }
}
