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
    public enum AGameMode { Plus, Minus, Mult, Divs };
    public enum DRGameMode { Two, Tree, Four, Five };
    public enum GameMode { Arithmetic, DivsRule };
    public partial class frmMain : Form
    {
        public static int countQuestionMax = 10;
        public static int timePerQuestArithmetic = 10;
        public static int timePerQuestDivsRule = 20;
        public static GameMode currentGameMode = GameMode.Arithmetic;

        private ToolStripRadioButtonMenuItem mniArithmetic = new ToolStripRadioButtonMenuItem();
        private ToolStripRadioButtonMenuItem mniDevsRule = new ToolStripRadioButtonMenuItem();

        Random rnd = new Random();
        int countQuestion;
        int minValue = 1;
        int maxValue = 10;
        int currentTime = 0;
        string correctArithAnswer;
        bool correctDivsRuleAnswer;
        AGameMode currentAMode;
        DRGameMode currentDRMode;

        public frmMain()
        {
            InitializeComponent();

            mniArithmetic.Text = "Арифметика";
            mniDevsRule.Text = "Признаки делимости";
            mnsMainTypeTrain.DropDownItems.AddRange(new ToolStripItem[] { mniArithmetic, mniDevsRule });
            mniArithmetic.CheckStateChanged += new EventHandler(mniArithmetic_CheckedChanged);
            mniDevsRule.CheckStateChanged += new EventHandler(mniDevsRule_CheckedChanged);
            switch (currentGameMode)
            {
                case GameMode.Arithmetic:
                    mniArithmetic.Checked = true;
                    break;
                case GameMode.DivsRule:
                    mniDevsRule.Checked = true;
                    break;
            }
            txbMax.Text = maxValue.ToString();
        }

        private void startGameArithmetic(AGameMode mode)
        {
            Font fnt = new System.Drawing.Font(lblThink.Font.FontFamily, 48, FontStyle.Bold);
            lblThink.Font = fnt;
            lblThink.TextAlign = ContentAlignment.MiddleRight;
            currentAMode = mode;
            btnPlus.Visible = false;
            btnMinus.Visible = false;
            btnMult.Visible = false;
            btnDivs.Visible = false;
            prbProgress.Visible = true;
            btnArithAnswer.Enabled = true;
            lblThink.Enabled = true;
            txbArithAnswer.Enabled = true;
            txbMax.Enabled = false;
            mnsMain.Enabled = false;
            txbArithAnswer.Text = "";
            prbProgress.Minimum = 0;
            prbProgress.Maximum = countQuestionMax;
            prbProgress.Value = 0;
            countQuestion = 0;
            txbArithAnswer.Focus();
            prbAnswerTime.Visible = true;
            prbAnswerTime.Maximum = timePerQuestArithmetic;
            try
            {
                maxValue = Convert.ToInt16(txbMax.Text);
            }
            catch
            {
                maxValue = 10;
                txbMax.Text = "10";
            }
            nextThinkArith();
        }

        private void startGameDivsRule(DRGameMode mode)
        {
            Font fnt = new System.Drawing.Font(lblThink.Font.FontFamily, 48, FontStyle.Bold);
            lblThink.Font = fnt;
            lblThink.TextAlign = ContentAlignment.MiddleRight;
            currentDRMode = mode;
            btnDivsOnTwo.Visible = false;
            btnDivsOnThree.Visible = false;
            btnDivsOnFour.Visible = false;
            btnDivsOnFive.Visible = false;
            prbProgress.Visible = true;
            btnDivsYes.Enabled = true;
            btnDivsNo.Enabled = true;
            txbMax.Enabled = false;
            mnsMain.Enabled = false;
            prbProgress.Minimum = 0;
            prbProgress.Maximum = countQuestionMax;
            prbProgress.Value = 0;
            countQuestion = 0;
            prbAnswerTime.Visible = true;
            prbAnswerTime.Maximum = timePerQuestDivsRule;
            try
            {
                maxValue = Convert.ToInt16(txbMax.Text);
            }
            catch
            {
                maxValue = 10;
                txbMax.Text = "10";
            }
            nextThinkDivsRule();
        }

        private void nextThinkDivsRule()
        {
            int a;
            int b;
            a = rnd.Next(minValue, maxValue);
            b = rnd.Next(minValue, maxValue);
            switch (currentDRMode)
            {
                case DRGameMode.Two:
                    {
                        lblThink.Text = a.ToString() + " : 2";
                        correctDivsRuleAnswer = !(Convert.ToBoolean(a % 2));
                    }
                    break;
                case DRGameMode.Tree:
                    {
                        lblThink.Text = a.ToString() + " : 3";
                        correctDivsRuleAnswer = !(Convert.ToBoolean(a % 3));
                    }
                    break;
                case DRGameMode.Four:
                    {
                        lblThink.Text = a.ToString() + " : 4";
                        correctDivsRuleAnswer = !(Convert.ToBoolean(a % 4));
                    }
                    break;
                case DRGameMode.Five:
                    {
                        lblThink.Text = a.ToString() + " : 5";
                        correctDivsRuleAnswer = !(Convert.ToBoolean(a % 5));
                    }
                    break;
            }
            currentTime = 0;
            prbAnswerTime.Value = 0;
            tmrAnswer.Enabled = true;
            countQuestion++;
        }

        private void nextThinkArith()
        {
            int a;
            int b;
            a = rnd.Next(minValue, maxValue);
            b = rnd.Next(minValue, maxValue);
            switch (currentAMode)
            {
                case AGameMode.Plus:
                    {
                        lblThink.Text = a.ToString() + " + " + b.ToString();
                        correctArithAnswer = (a + b).ToString();
                    }
                    break;
                case AGameMode.Minus:
                    {
                        if (a < b)
                        {
                            int e = a;
                            a = b;
                            b = e;
                        }
                        lblThink.Text = a.ToString() + " – " + b.ToString();
                        correctArithAnswer = (a - b).ToString();
                    }
                    break;
                case AGameMode.Mult:
                    {
                        lblThink.Text = a.ToString() + " × " + b.ToString();
                        correctArithAnswer = (a * b).ToString();
                    }
                    break;
                case AGameMode.Divs:
                    {
                        lblThink.Text = (a * b).ToString() + " : " + b.ToString();
                        correctArithAnswer = a.ToString();
                    }
                    break;
            }
            currentTime = 0;
            prbAnswerTime.Value = 0;
            tmrAnswer.Enabled = true;
            countQuestion++;
        }

        private void checkArithAnswer()
        {
            if (txbArithAnswer.Text == "")
                return;

            try
            {
                Convert.ToInt16(txbArithAnswer.Text);
            }
            catch
            {
                txbArithAnswer.Text = "";
                return;
            }

            tmrAnswer.Enabled = false;
            if (correctArithAnswer == txbArithAnswer.Text)
            {
                txbArithAnswer.Text = "";
                prbProgress.Value = countQuestion;
                if (countQuestion == countQuestionMax)
                    gameWin();
                else
                    nextThinkArith();
            }
            else
                gameOver();
        }

        private void checkDivsRuleAnswer(bool yesOrNo)
        {
            tmrAnswer.Enabled = false;
            if (correctDivsRuleAnswer == yesOrNo)
            {
                prbProgress.Value = countQuestion;
                if (countQuestion == countQuestionMax)
                    gameWin();
                else
                    nextThinkDivsRule();
            }
            else
                gameOver();
        }

        private void done()
        {
            switch (currentGameMode)
            {
                case GameMode.Arithmetic:
                    {
                        txbArithAnswer.Enabled = false;
                        txbArithAnswer.Text = "";
                        prbProgress.Visible = false;
                        btnArithAnswer.Enabled = false;
                        btnPlus.Visible = true;
                        btnMinus.Visible = true;
                        btnMult.Visible = true;
                        btnDivs.Visible = true;
                        txbMax.Enabled = true;
                        prbAnswerTime.Visible = false;
                        mnsMain.Enabled = true;
                    }
                    break;
                case GameMode.DivsRule:
                    {
                        btnDivsOnTwo.Visible = true;
                        btnDivsOnThree.Visible = true;
                        btnDivsOnFour.Visible = true;
                        btnDivsOnFive.Visible = true;
                        prbProgress.Visible = false;
                        btnDivsYes.Enabled = false;
                        btnDivsNo.Enabled = false;
                        txbMax.Enabled = true;
                        prbAnswerTime.Visible = false;
                        mnsMain.Enabled = true;
                    }
                    break;
            }
        }

        private void tmrAnswer_Tick(object sender, EventArgs e)
        {
            switch (currentGameMode)
            {
                case GameMode.Arithmetic:
                    if (currentTime == timePerQuestArithmetic)
                    {
                        tmrAnswer.Enabled = false;
                        timeOver();
                    }
                    else
                    {
                        currentTime++;
                        prbAnswerTime.Value = currentTime;
                    }
                    break;
                case GameMode.DivsRule:
                    if (currentTime == timePerQuestDivsRule)
                    {
                        tmrAnswer.Enabled = false;
                        timeOver();
                    }
                    else
                    {
                        currentTime++;
                        prbAnswerTime.Value = currentTime;
                    }
                    break;
            }
        }

        private void mnsMainOptions_Click(object sender, EventArgs e)
        {
            frmOptions frmOpt = new frmOptions();
            frmOpt.ShowDialog();
        }

        private void mniArithmetic_CheckedChanged(object sender, EventArgs e)
        {
            currentGameMode = GameMode.Arithmetic;

            msgForUser("Выбери задание и сложность");
            aControlShow(true);
            btnArithAnswer.Enabled = false;
            txbArithAnswer.Enabled = false;
            txbArithAnswer.Text = "";
            drControlShow(false);
        }

        private void mniDevsRule_CheckedChanged(object sender, EventArgs e)
        {
            currentGameMode = GameMode.DivsRule;
            msgForUser("Выбери задание и сложность");
            drControlShow(true);
            btnDivsYes.Enabled = false;
            btnDivsNo.Enabled = false;
            aControlShow(false);
        }

        private void msgForUser(string msg)
        {
            Font fnt = new System.Drawing.Font(lblThink.Font.FontFamily, 20, FontStyle.Bold);
            lblThink.Font = fnt;
            lblThink.TextAlign = ContentAlignment.MiddleCenter;
            lblThink.Text = msg;
        }

        private void aControlShow(bool show)
        {
            btnPlus.Visible = show;
            btnMinus.Visible = show;
            btnMult.Visible = show;
            btnDivs.Visible = show;
            btnArithAnswer.Visible = show;
            txbArithAnswer.Visible = show;
        }

        private void drControlShow(bool show)
        {
            btnDivsOnTwo.Visible = show;
            btnDivsOnThree.Visible = show;
            btnDivsOnFour.Visible = show;
            btnDivsOnFive.Visible = show;
            btnDivsYes.Visible = show;
            btnDivsNo.Visible = show;
        }

        private void gameOver()
        {
            msgForUser("Ошибка\nВыбери задание и сложность");
            done();
        }

        private void gameWin()
        {
            msgForUser("Пройдено\nВыбери задание и сложность");
            done();
        }

        private void timeOver()
        {
            msgForUser("Время вышло\nВыбери задание и сложность");
            done();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            startGameArithmetic(AGameMode.Plus);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            startGameArithmetic(AGameMode.Minus);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            startGameArithmetic(AGameMode.Mult);
        }

        private void btnDivs_Click(object sender, EventArgs e)
        {
            startGameArithmetic(AGameMode.Divs);
        }

        private void btnDivsOnTwo_Click(object sender, EventArgs e)
        {
            startGameDivsRule(DRGameMode.Two);
        }

        private void btnDivsOnThree_Click(object sender, EventArgs e)
        {
            startGameDivsRule(DRGameMode.Tree);
        }

        private void btnDivsOnFour_Click(object sender, EventArgs e)
        {
            startGameDivsRule(DRGameMode.Four);
        }

        private void btnDivsOnFive_Click(object sender, EventArgs e)
        {
            startGameDivsRule(DRGameMode.Five);
        }

        private void txbArithAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                checkArithAnswer();
        }

        private void btnArithAnswer_Click(object sender, EventArgs e)
        {
            checkArithAnswer();
        }

        private void btnDivsYes_Click(object sender, EventArgs e)
        {
            checkDivsRuleAnswer(true);
        }

        private void btnDivsNo_Click(object sender, EventArgs e)
        {
            checkDivsRuleAnswer(false);
        }
    }
}
