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
    public partial class frmLevel_01 : Form
    {
        int boxLeft = 5;

        public frmLevel_01()
        {
            InitializeComponent();
        }

        private void startGame()
        {
            Point point = lblStart.Location;
            point.Offset(lblStart.Width / 2, lblStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.playStart();
            boxLeft = 5;

        }

        private void finishGame()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void restartGame()
        {
            Sound.playFail();
            DialogResult dlg;
            dlg = MessageBox.Show("Вы столкнулись со стеной!\n\nПовторить?", "Вы проиграли!", MessageBoxButtons.YesNo);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
                startGame();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void frmLevel_01_Shown(object sender, EventArgs e)
        {
            startGame();
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            if (boxLeft == 0)
                finishGame();
        }

        private void lblWall_MouseEnter(object sender, EventArgs e)
        {
            restartGame();
        }

        private void lblBox_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;
            Sound.playKey();
            boxLeft--;
        }
    }
}
