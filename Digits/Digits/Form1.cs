using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Digits
{
    public partial class frmMain : Form
    {
        int btnCount = 9;
        int currentBtn = 0;
        Random rnd = new Random();
        Stopwatch watch = new Stopwatch();

        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра с цифрами.\n\nНажимайте кнопки с цифрами от 1 до 9.", "О программе");
        }

        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void startGame()
        {
            for (int j = 1; j <= btnCount; j++)
                getButton(j).Text = j.ToString();
            for (int k = 1; k <= btnCount * 3; k++)
                swapBtn();
            for (int i = 1; i <= btnCount; i++)
            {
                getButton(i).Visible = true;
            }
            currentBtn = 1;
            watch.Restart();
        }

        private void swapBtn()
        {
            int a = rnd.Next(1, btnCount + 1);
            int b = rnd.Next(1, btnCount + 1);
            string txt = getButton(a).Text;
            getButton(a).Text = getButton(b).Text;
            getButton(b).Text = txt;
        }

        private Button getButton(int i)
        {
            switch (i)
            {
                case 1:
                    return button1;
                case 2:
                    return button2;
                case 3:
                    return button3;
                case 4:
                    return button4;
                case 5:
                    return button5;
                case 6:
                    return button6;
                case 7:
                    return button7;
                case 8:
                    return button8;
                case 9:
                    return button9;
                default:
                    return null;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string num = ((Button)sender).Text;
            if (num == currentBtn.ToString())
            {
                ((Button)sender).Visible = false;
                currentBtn++;
            }
            if (currentBtn > btnCount)
            {
                watch.Stop();
                MessageBox.Show((watch.ElapsedMilliseconds / 1000.0).ToString("#.###") + " сек.", "Результат");
            }
        }
    }
}
