﻿using System;
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
    enum Mode { Show, Game };
    public partial class frmMain : Form
    {
        Figure userFigure;
        Figure compFigure;
        Mode gameMode;
        int scoreWins = 0;
        int scoreLose = 0;
        int scoreDraw = 0;
        Random rand = new Random();

        public frmMain()
        {
            InitializeComponent();
            picCompPaper.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            picCompScissors.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            picCompRock.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            showScore();
            setCompSpeed();
        }

        private void startGame()
        {
            if (gameMode != Mode.Game)
            {
                gameMode = Mode.Game;
                lblMsgUser.Text = "Выбери свою фигуру";
            }
        }

        private void showUserFigure(Figure fig)
        {
            startGame();
            picUserRock.Visible = (fig == Figure.Rock);
            picUserPaper.Visible = (fig == Figure.Paper);
            picUserScissors.Visible = (fig == Figure.Scissors);
            userFigure = fig;
        }

        private void showCompFigure(Figure fig)
        {
            picCompRock.Visible = (fig == Figure.Rock);
            picCompPaper.Visible = (fig == Figure.Paper);
            picCompScissors.Visible = (fig == Figure.Scissors);
            compFigure = fig;
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

        private void tmrCompSelect_Tick(object sender, EventArgs e)
        {
            if (gameMode == Mode.Game)
                compRandomFigureSelect();
        }

        private void compRandomFigureSelect()
        {
            showCompFigure((Figure)rand.Next(0, 3));
        }

        private void showScore()
        {
            lblScore.Text = String.Format("Победы: {0}   Поражения: {1}   Ничьи: {2}", scoreWins, scoreLose, scoreDraw);
        }

        private void userSelect_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameMode == Mode.Game)
                checkResult();
            else
                startGame();
        }

        private void checkResult()
        {
            gameMode = Mode.Show;
            bool wins = false;

            if (userFigure == compFigure)
            {
                scoreDraw++;
                lblMsgUser.Text = "Ничья";
            }
            else
            {
                if (userFigure == Figure.Rock && compFigure == Figure.Scissors)
                    wins = true;
                if (userFigure == Figure.Scissors && compFigure == Figure.Paper)
                    wins = true;
                if (userFigure == Figure.Paper && compFigure == Figure.Rock)
                    wins = true;

                if (wins)
                {
                    scoreWins++;
                    lblMsgUser.Text = "Победа!";
                }
                else
                {
                    scoreLose++;
                    lblMsgUser.Text = "Проигрыш";
                }
            }
            showScore();
        }

        private void trbDifficulty_ValueChanged(object sender, EventArgs e)
        {
            setCompSpeed();
        }

        private void setCompSpeed()
        {
            switch (trbDifficulty.Value)
            {
                case 1:
                    tmrCompSelect.Interval = 400;
                    break;
                case 2:
                    tmrCompSelect.Interval = 300;
                    break;
                case 3:
                    tmrCompSelect.Interval = 200;
                    break;
                case 4:
                    tmrCompSelect.Interval = 100;
                    break;
                case 5:
                    tmrCompSelect.Interval = 50;
                    break;
            }
        }
    }
}
