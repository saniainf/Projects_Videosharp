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
    enum Mode { Begin, ShowOne, ShowTwo, ShowThree };
    public partial class frmMain : Form
    {
        frmHelp frmHlp = new frmHelp();
        frmAbout frmAbt = new frmAbout();
        Mode gameMode = Mode.Begin;
        Random rnd = new Random();

        int[] cards = new int[16];
        bool[] opensPcb = new bool[16];
        int done;
        int cardA;
        int cardB;

        private void InitGame()
        {
            for (int i = 0; i < cards.Length; i++)
                cards[i] = i % (cards.Length / 2) + 1;
            shuffleCards();
            for (int j = 0; j < cards.Length; j++)
                hidePcb(j);
            for (int i = 0; i < opensPcb.Length; i++)
                opensPcb[i] = false;
            done = 0;
            pcbStartPicture.Visible = false;
            gameMode = Mode.Begin;

        }

        private void loadImageToPcb(int pcbNumber, int loadImage)
        {
            getPcb(pcbNumber).Image = getImage(loadImage);
        }

        private void showPcb(int pcbNumber)
        {
            loadImageToPcb(pcbNumber, cards[pcbNumber]);
            getPcb(pcbNumber).Cursor = Cursors.Arrow;
        }

        private void hidePcb(int pcbNumber)
        {
            loadImageToPcb(pcbNumber, 0);
            getPcb(pcbNumber).Cursor = Cursors.Hand;
        }

        private void openPcb(int pcbNumber)
        {
            opensPcb[pcbNumber] = true;
            showPcb(pcbNumber);
        }

        public frmMain()
        {
            InitializeComponent();
            //InitGame();
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
            int pcbNum = Convert.ToInt32(((PictureBox)sender).Tag.ToString());
            if (opensPcb[pcbNum]) return;
            switch (gameMode)
            {
                case Mode.Begin:
                    modeBegin(pcbNum);
                    break;
                case Mode.ShowOne:
                    modeShowOne(pcbNum);
                    break;
                case Mode.ShowTwo:
                    modeShowTwo(pcbNum);
                    break;
                case Mode.ShowThree:
                    modeShowThree(pcbNum);
                    break;
            }
        }

        private void modeBegin(int pcbNum)
        {
            cardA = pcbNum;
            showPcb(pcbNum);
            gameMode = Mode.ShowOne;
        }

        private void modeShowOne(int pcbNum)
        {
            cardB = pcbNum;
            if (cardA == cardB)
                return;
            showPcb(pcbNum);
            gameMode = Mode.ShowTwo;
            if (cards[cardA] == cards[cardB])
            {
                openPcb(cardA);
                openPcb(cardB);
                done += 2;
                if (done == 16)
                    winGame();
                else
                    gameMode = Mode.Begin;
            }
            else
                gameMode = Mode.ShowThree;
        }

        private void modeShowTwo(int pcbNum)
        {
            
        }

        private void modeShowThree(int pcbNum)
        {
            hidePcb(cardA);
            hidePcb(cardB);
            modeBegin(pcbNum);
        }

        private void winGame()
        {
            MessageBox.Show("Вы победили!", "Поздравляем");
        }

        private void shuffleCards()
        {
            for (int i = 0; i < 100; i++)
            {
                int a = rnd.Next(0, cards.Length);
                int b = rnd.Next(0, cards.Length);
                int c = cards[a];
                cards[a] = cards[b];
                cards[b] = c;
            }
        }

        private PictureBox getPcb(int pcbNumber)
        {
            switch (pcbNumber)
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

        private Image getImage(int imageNumber)
        {
            switch (imageNumber)
            {
                case 0: return Properties.Resources._0;
                case 1: return Properties.Resources._1;
                case 2: return Properties.Resources._2;
                case 3: return Properties.Resources._3;
                case 4: return Properties.Resources._4;
                case 5: return Properties.Resources._5;
                case 6: return Properties.Resources._6;
                case 7: return Properties.Resources._7;
                case 8: return Properties.Resources._8;
                default: return Properties.Resources._0;
            }
        }

        private void mnuGameNewGame_Click(object sender, EventArgs e)
        {
            InitGame();
        }
    }
}
