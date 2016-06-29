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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSound_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSound.Checked)
            {
                cbSound.Text = "Звук включен";
                Sound.soundOn();
            }
            else
            {
                cbSound.Text = "Звук выключен";
                Sound.soundOff();
            }
            Sound.playKey();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            startLvl_01();
        }

        private void startLvl_01()
        {
            DialogResult dlg;
            frmLevel_01 lvl_01 = new frmLevel_01();
            dlg = lvl_01.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.OK)
                startLvl_02();
        }

        private void startLvl_02()
        {
            DialogResult dlg;
            frmLevel_02 lvl_02 = new frmLevel_02();
            dlg = lvl_02.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.OK)
                startLvl_03();
        }

        private void startLvl_03()
        {
            DialogResult dlg;
            frmLevel_03 lvl_03 = new frmLevel_03();
            dlg = lvl_03.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.OK)
                startLvl_04();
        }

        private void startLvl_04()
        {
            DialogResult dlg;
            frmLevel_04 lvl_04 = new frmLevel_04();
            dlg = lvl_04.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                Sound.playWin();
                MessageBox.Show("Победа!\n\nВы прошли весь лабиринт!", "Ура!");
            }
        }
    }
}
