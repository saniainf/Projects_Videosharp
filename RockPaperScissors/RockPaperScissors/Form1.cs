using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{

    enum Figure { Rock, Scissors, Paper };
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void showUserFigure(Figure fig)
        {
            picRock.Visible = (fig == Figure.Rock);
            picPaper.Visible = (fig == Figure.Paper);
            picScissors.Visible = (fig == Figure.Scissors);
        }

        private void pnlUserSelect_MouseEnter(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            switch (pnl.Tag.ToString())
            {
                case "Rock":
                    showUserFigure(Figure.Rock);
                    break;
                case "Paper":
                    showUserFigure(Figure.Paper);
                    break;
                case "Scissors":
                    showUserFigure(Figure.Scissors);
                    break;
            }
        }
    }
}
