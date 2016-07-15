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

        int[] cards = new int[16];

        private void InitGame()
        {
            for (int i = 0; i < cards.Length; i++)
                cards[i] = i % (cards.Length / 2) + 1;

        }

        private void loadPicToPcb(int picture, int image)
        {

        }

        private PictureBox getPcb(int picture)
        {
            switch (picture)
            {
                case 0: return pcb1;
                case 1: return pcb2;
                case 2: return pcb3;
                case 3: return pcb4;
                case 4: return pcb5;
                case 5: return pcb6;
                case 6: return pcb7;
                case 7: return pcb8;
                case 8: return pcb9;
                case 9: return pcb10;
                case 10: return pcb11;
                case 11: return pcb12;
                case 12: return pcb13;
                case 13: return pcb14;
                case 14: return pcb15;
                case 15: return pcb16;
                default: return null;
            }
        }

        public frmMain()
        {
            InitializeComponent();
            InitGame();
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

        private void pcb_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(((PictureBox)sender).Tag.ToString());
        }
    }
}
