using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmGame : Form
    {
        Rectangle gameField;
        //Rectangle paddle;
        //Rectangle ball;
        Point ballDirection;
        int paddleVelocity = 10;

        public frmGame()
        {
            InitializeComponent();
        }

        private void initGame()
        {
            gameField = new Rectangle();
            //paddleX = paddle.Location.X;
            //paddleY = paddle.Location.Y;
            //wallLx = lblWallLeft.Location.X + lblWallLeft.Size.Width;
            //wallRx = lblWallRight.Location.X;
            //wallTy = lblWallTop.Location.X + lblWallTop.Size.Height;
            //ballX = ball.Location.X;
            //ballY = ball.Location.Y;
            //ballSX = ballShiftX;
            //ballSY = -ballShiftY;
        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                //case Keys.Left:
                //    shiftPaddle(-paddleShiftX);
                //    break;
                //case Keys.Right:
                //    shiftPaddle(paddleShiftX);
                //    break;
                case Keys.Enter:
                    tmrBall.Enabled = true;
                    break;
            }
        }

        private void frmGame_Shown(object sender, EventArgs e)
        {
            initGame();
        }

        private void shiftPaddle(int sx)
        {
            //int aXLeft = paddleX + sx;
            //int aXRight = aXLeft + paddle.Size.Width;
            //if (wallLx > aXLeft) aXLeft = wallLx;
            //if (wallRx < aXRight) aXLeft = wallRx - paddle.Size.Width;
            //paddleX = aXLeft;
            //paddle.Location = new Point(paddleX, paddleY);
        }

        private void shiftBall()
        {
            //int bTop, bBot, bLeft, bRight;
            //bTop = ballX;
            //bBot = ballX + ball.Size.Width;
            //bLeft = ballY;
            //bRight = ballY + ball.Size.Height;
            //if ((bLeft + ballSX) < wallLx)
            //    ballSX = ballShiftX;
            //if (bRight + ballSX > wallRx)
            //    ballSX = -ballShiftX;
            //// переписать нахрен
            //ballX += ballSX;
            //ballY += ballSY;
            //ball.Location = new Point(ballX, ballY);
        }

        private void tmrBall_Tick(object sender, EventArgs e)
        {
            shiftBall();
        }
    }
}
