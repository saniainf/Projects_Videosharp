using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagGame
{
    public partial class frmMain : Form
    {
        GameBoard gBoard;
        GameBoxVsCircle gCatch;

        public frmMain()
        {
            InitializeComponent();
            gBoard = new GameBoard(pcbMain);
            gCatch = new GameBoxVsCircle();
            tmrMain.Enabled = true;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    gCatch.AddGamer(GameBoard.NewCircle());
            //}
            for (int i = 0; i < 5; i++)
            {
                gCatch.AddGamer(GameBoard.NewBox());
            }
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            gCatch.Step();
            gBoard.Clear();
            foreach (IPlayer p in gCatch.Players)
            {
                gBoard.Show(p);
            }
            gBoard.Refresh();
        }

        private void btnAddCircle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                gCatch.AddGamer(GameBoard.NewCircle());
            }
        }
    }
}
