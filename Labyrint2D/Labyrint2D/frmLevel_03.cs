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
    public partial class frmLevel_03 : Form
    {
        bool moveRight = true;
        int speed = 2;

        public frmLevel_03()
        {
            InitializeComponent();
        }

        private void startGame()
        {
            Point point = lblStart.Location;
            point.Offset(lblStart.Width / 2, lblStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.playStart();
            point.X = 0 - lblMoveWall.Width;
            point.Y = 0;
            lblMoveWall.Location = point;
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

        private void frmLevel_03_Shown(object sender, EventArgs e)
        {
            startGame();
        }

        private void lblWall_MouseEnter(object sender, EventArgs e)
        {
            restartGame();
        }

        private void lblFinish_MouseMove(object sender, MouseEventArgs e)
        {
            finishGame();
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            Point point = lblMoveWall.Location;

            if (lblMoveWall.Location.X + lblMoveWall.Size.Width >= label5.Location.X + label5.Size.Width)
                moveRight = false;
            if (lblMoveWall.Location.X <= 0)
                moveRight = true;

            if (moveRight)
                point.Offset(speed, 0);
            else
                point.Offset(-speed, 0);

            lblMoveWall.Location = point;
        }
    }
}
