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
    public partial class frmLevel_04 : Form
    {
        List<Label> riseWall;

        public frmLevel_04()
        {
            InitializeComponent();
            riseWall = new List<Label>();
        }

        private void addRiseWall()
        {
            Label rWall = new Label();
            rWall.Size = lblFinish.Size;
            rWall.Location = new Point(lblFinish.Location.X - (rWall.Width + 3) * (riseWall.Count + 1), lblFinish.Location.Y);
            rWall.BackColor = wallLeft.BackColor;
            rWall.MouseEnter += new EventHandler(lblWall_MouseEnter);
            this.Controls.Add(rWall);
            riseWall.Add(rWall);
        }

        private void placeKey()
        {
            Random rnd = new Random();
            Point pTopLeft = new Point(wallLeft.Location.X + wallLeft.Width + 5, wallTop.Location.Y + wallTop.Height + 5);
            Point pBottomRight = new Point(riseWall[riseWall.Count - 1].Location.X - 5 - lblKey.Width, wallBottom.Location.Y - wallBottom.Height - 5 - lblKey.Height);
            Point point = new Point(rnd.Next(pTopLeft.X, pBottomRight.X), rnd.Next(pTopLeft.Y, pBottomRight.Y));
            lblKey.Location = point;
            tmrRiseWall.Enabled = true;
        }

        private void startGame()
        {
            Point point = lblStart.Location;
            point.Offset(lblStart.Width / 2, lblStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            if (riseWall.Count > 0)
            {
                foreach (Label wall in riseWall)
                {
                    wall.MouseEnter -= new EventHandler(lblWall_MouseEnter);
                    this.Controls.Remove(wall);
                    wall.Dispose();
                }
                riseWall = new List<Label>();
            }
            for (int i = 0; i < 5; i++)
                addRiseWall();
            placeKey();
            Sound.playStart();
            tmrRiseWall.Enabled = true;
        }

        private void finishGame()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void restartGame()
        {
            tmrRiseWall.Enabled = false;
            Sound.playFail();
            DialogResult dlg;
            dlg = MessageBox.Show("Вы столкнулись со стеной!\n\nПовторить?", "Вы проиграли!", MessageBoxButtons.YesNo);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
                startGame();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void frmLevel_04_Shown(object sender, EventArgs e)
        {
            startGame();
        }

        private void lblWall_MouseEnter(object sender, EventArgs e)
        {
            restartGame();
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            finishGame();
        }

        private void tmrRiseWall_Tick(object sender, EventArgs e)
        {
            addRiseWall();
            placeKey();
            if (riseWall[riseWall.Count - 1].Location.X <= lblStart.Location.X + lblStart.Width + lblFinish.Width * 2)
                restartGame();
        }

        private void lblKey_MouseEnter(object sender, EventArgs e)
        {
            if (riseWall.Count > 0)
            {
                Sound.playKey();
                Label wall = riseWall[riseWall.Count - 1];
                riseWall.Remove(wall);
                wall.MouseEnter -= new EventHandler(lblWall_MouseEnter);
                this.Controls.Remove(wall);
                wall.Dispose();
                tmrRiseWall.Enabled = false;
                if (riseWall.Count > 0)
                    placeKey();
                else
                    lblKey.Visible = false;
            }
            else
                tmrRiseWall.Enabled = false;
        }

    }
}
