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
    enum GameMode { Plus, Minus, Mult, Divs };
    public partial class frmMain : Form
    {
        Random rnd = new Random();
        int countQuestion;
        int minValue = 1;
        int maxValue = 10;
        int countQuestionMax = 2;
        string currentAnswer;
        GameMode currentMode;

        public frmMain()
        {
            InitializeComponent();
            Font fnt = new System.Drawing.Font(lblThink.Font.FontFamily, 20, FontStyle.Bold);
            lblThink.Font = fnt;
            lblThink.TextAlign = ContentAlignment.MiddleCenter;
            lblThink.Text = "Выбери задание и сложность";
            txbMax.Text = maxValue.ToString();
            txbAnswer.Enabled = false;
            txbAnswer.Text = "";
            prbProgress.Visible = false;
            btnAnswer.Enabled = false;
            btnPlus.Visible = true;
        }

        private void startGame(GameMode mode)
        {
            Font fnt = new System.Drawing.Font(lblThink.Font.FontFamily, 48, FontStyle.Bold);
            lblThink.Font = fnt;
            lblThink.TextAlign = ContentAlignment.MiddleRight;
            currentMode = mode;
            btnPlus.Visible = false;
            btnMinus.Visible = false;
            btnMult.Visible = false;
            btnDivs.Visible = false;
            prbProgress.Visible = true;
            btnAnswer.Enabled = true;
            lblThink.Enabled = true;
            txbAnswer.Enabled = true;
            txbMax.Enabled = false;
            txbAnswer.Text = "";
            prbProgress.Minimum = 0;
            prbProgress.Maximum = countQuestionMax;
            prbProgress.Value = 0;
            countQuestion = 0;
            txbAnswer.Focus();
            try
            {
                maxValue = Convert.ToInt16(txbMax.Text);
            }
            catch
            {
                maxValue = 10;
                txbMax.Text = "10";
            }
            nextThink();
        }

        private void nextThink()
        {
            int a;
            int b;
            a = rnd.Next(minValue, maxValue);
            b = rnd.Next(minValue, maxValue);
            switch (currentMode)
            {
                case GameMode.Plus:
                    {
                        lblThink.Text = a.ToString() + " + " + b.ToString();
                        currentAnswer = (a + b).ToString();
                    }
                    break;
                case GameMode.Minus:
                    {
                        if (a < b)
                        {
                            int e = a;
                            a = b;
                            b = e;
                        }
                        lblThink.Text = a.ToString() + " – " + b.ToString();
                        currentAnswer = (a - b).ToString();
                    }
                    break;
                case GameMode.Mult:
                    {
                        lblThink.Text = a.ToString() + " × " + b.ToString();
                        currentAnswer = (a * b).ToString();
                    }
                    break;
                case GameMode.Divs:
                    {
                        lblThink.Text = (a * b).ToString() + " : " + b.ToString();
                        currentAnswer = a.ToString();
                    }
                    break;
            }
            countQuestion++;
        }

        private void txbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                checkAnswer();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            checkAnswer();
        }

        private void checkAnswer()
        {
            if (txbAnswer.Text == "")
                return;

            try
            {
                Convert.ToInt16(txbAnswer.Text);
            }
            catch
            {
                txbAnswer.Text = "";
                return;
            }

            if (txbAnswer.Text == currentAnswer)
            {
                txbAnswer.Text = "";
                prbProgress.Value = countQuestion;
                if (countQuestion == countQuestionMax)
                    gameWin();
                else
                    nextThink();
            }
            else
                gameOver();
        }

        private void gameOver()
        {
            Font fnt = new System.Drawing.Font(lblThink.Font.FontFamily, 20, FontStyle.Bold);
            lblThink.Font = fnt;
            lblThink.TextAlign = ContentAlignment.MiddleCenter;
            lblThink.Text = "Ошибка\nВыбери задание и сложность";
            done();
        }

        private void gameWin()
        {
            Font fnt = new System.Drawing.Font(lblThink.Font.FontFamily, 20, FontStyle.Bold);
            lblThink.Font = fnt;
            lblThink.TextAlign = ContentAlignment.MiddleCenter;
            lblThink.Text = "Пройдено\nВыбери задание и сложность";
            done();
        }

        private void done()
        {
            txbAnswer.Enabled = false;
            txbAnswer.Text = "";
            prbProgress.Visible = false;
            btnAnswer.Enabled = false;
            btnPlus.Visible = true;
            btnMinus.Visible = true;
            btnMult.Visible = true;
            btnDivs.Visible = true;
            txbMax.Enabled = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            startGame(GameMode.Plus);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            startGame(GameMode.Minus);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            startGame(GameMode.Mult);
        }

        private void btnDivs_Click(object sender, EventArgs e)
        {
            startGame(GameMode.Divs);
        }
    }
}
