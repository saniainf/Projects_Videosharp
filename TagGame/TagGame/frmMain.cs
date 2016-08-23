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
        GameVirus gCatch;

        public frmMain()
        {
            InitializeComponent();
            gBoard = new GameBoard(pcbMain);
            gCatch = new GameVirus();
            tmrMain.Enabled = true;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                gCatch.AddGamer(GameBoard.NewCircle());
            }
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            gCatch.Step();
            gBoard.Clear();
            foreach (Circle c in gCatch.players)
            {
                gBoard.Show(c);
            }
            gBoard.Refresh();
        }
    }
}
