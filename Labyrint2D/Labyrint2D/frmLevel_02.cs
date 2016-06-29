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
    public partial class frmLevel_02 : Form
    {
        public frmLevel_02()
        {
            InitializeComponent();
        }

        private void startGame()
        {
            Point point = lblStart.Location;
            point.Offset(lblStart.Width / 2, lblStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.playStart();
            lblKey.Visible = true;
            lblDoor.Visible = true;
            lblFlash1.Visible = true;
            lblFlash2.Visible = false;
            tmrFlash.Enabled = true;
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

        private void frmLevel_02_Shown(object sender, EventArgs e)
        {
            startGame();
        }

        private void lblWall_MouseEnter(object sender, EventArgs e)
        {
            restartGame();
        }

        private void lblKey_MouseEnter(object sender, EventArgs e)
        {
            lblDoor.Visible = false;
            lblKey.Visible = false;
            Sound.playKey();
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            finishGame();
        }

        private void tmrFlash_Tick(object sender, EventArgs e)
        {
            lblFlash1.Visible = !lblFlash1.Visible;
            lblFlash2.Visible = !lblFlash2.Visible;
        }
    }
}
