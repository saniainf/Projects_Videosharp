using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindCounter
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
            nmbTimeArithmetic.Value = frmMain.timePerQuestArithmetic;
            nmbTimeDivsRule.Value = frmMain.timePerQuestDivsRule;
            nmbCountQuest.Value = frmMain.countQuestionMax;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            applyOpt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void nmbBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                applyOpt();
        }

        private void applyOpt()
        {
            frmMain.timePerQuestArithmetic = (int)nmbTimeArithmetic.Value;
            frmMain.timePerQuestDivsRule = (int)nmbTimeDivsRule.Value;
            frmMain.countQuestionMax = (int)nmbCountQuest.Value;
            this.Close();
        }
    }
}
