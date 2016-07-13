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
        Rectangle paddleRect;
        Rectangle ballRect;
        Point ballDirection;
        int shadowOffset = 4;
        int paddleVelocity = 15;
        Point startBallLocation;
        Point startPaddleLocation;
        Point startBallDirection;
        List<PictureBox> bricks;
        Point startBricks;
        int ballRadius;
        int score;
        int lifeCount;
        bool gameDone;

        public frmGame()
        {
            InitializeComponent();
        }

        private void initGame()
        {
            Point lp = new Point(leftWall.Location.X + leftWall.Size.Width, TopWall.Location.Y + TopWall.Size.Height);
            gameField = new Rectangle(lp.X, lp.Y, rightWall.Location.X - lp.X, this.Size.Height - (TopWall.Location.Y + TopWall.Size.Height));
            paddleRect = new Rectangle(paddle.Location.X, paddle.Location.Y, paddle.Size.Width - shadowOffset, paddle.Size.Height - shadowOffset);
            ballRect = new Rectangle(ball.Location.X, ball.Location.Y, ball.Size.Width - shadowOffset, ball.Size.Height - shadowOffset);
            ballDirection = new Point(3, -3);
            startBallDirection = ballDirection;
            startBallLocation = ballRect.Location;
            startPaddleLocation = paddleRect.Location;
            ballRadius = ballRect.Width / 2;
            score = 0;
            lifeCount = 7;
            fillBricksGameField();
            tmrBall.Enabled = true;
            gameDone = false;
        }

        private void fillBricksGameField()
        {
            startBricks = new Point(40, 40);
            bricks = new List<PictureBox>();
            for (int j = 5; j >= 0; j--)
                for (int i = 12; i >= 0; i--)
                {
                    PictureBox pcb = new PictureBox();
                    pcb.Size = new System.Drawing.Size(76, 36);
                    pcb.Location = new Point((i * pcb.Size.Width) - (i * shadowOffset) + startBricks.X, (j * pcb.Size.Height) - (j * shadowOffset) + startBricks.Y);
                    pcb.BackgroundImage = global::Arkanoid.Properties.Resources.brick;
                    pcb.BackColor = System.Drawing.Color.Transparent;
                    pcb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                    this.Controls.Add(pcb);
                    bricks.Add(pcb);
                }
        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Left:
                    shiftPaddle(-paddleVelocity);
                    break;
                case Keys.Right:
                    shiftPaddle(paddleVelocity);
                    break;
                case Keys.Enter:
                    tmrBall.Enabled = true;
                    break;
                case Keys.Escape:
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    break;
            }
            if (gameDone)
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void frmGame_Shown(object sender, EventArgs e)
        {
            initGame();
        }

        private void shiftPaddle(int sx)
        {
            paddleRect.Location = new Point(paddleRect.Location.X + sx, paddleRect.Location.Y);
            if (paddleRect.Left < gameField.Left)
                paddleRect.Location = new Point(gameField.Left, paddleRect.Location.Y);
            if (paddleRect.Right > gameField.Right)
                paddleRect.Location = new Point(gameField.Right - paddleRect.Size.Width, paddleRect.Location.Y);
            paddle.Location = paddleRect.Location;
        }

        private void shiftBall()
        {
            if (ballRect.Left < gameField.Left)
                ballDirection.X = Math.Abs(ballDirection.X);
            if (ballRect.Right > gameField.Right)
                ballDirection.X = -(Math.Abs(ballDirection.X));
            if (ballRect.Top < gameField.Top)
                ballDirection.Y = Math.Abs(ballDirection.Y);

            if (ballRect.Bottom > paddleRect.Top)
            {
                Point ballCenter = new Point(ballRect.Left + (ballRect.Size.Width / 2), ballRect.Top + (ballRect.Size.Height / 2));
                if (ballCenter.X >= paddleRect.Left & ballCenter.X <= paddleRect.Right)
                    ballDirection.Y = -(Math.Abs(ballDirection.Y));
                else if (ballRect.Right >= paddleRect.Left & ballRect.Right <= paddleRect.Right)
                {
                    ballDirection.Y = -(Math.Abs(ballDirection.Y));
                    ballDirection.X = -(Math.Abs(ballDirection.X));
                }
                else if (ballRect.Left >= paddleRect.Left & ballRect.Left <= paddleRect.Right)
                {
                    ballDirection.Y = -(Math.Abs(ballDirection.Y));
                    ballDirection.X = Math.Abs(ballDirection.X);
                }
            }

            ballRect.Location = new Point(ballRect.Location.X + ballDirection.X, ballRect.Location.Y + ballDirection.Y);
            if (ballRect.Bottom > gameField.Bottom)
            {
                missBall();
                return;
            }
            ball.Location = ballRect.Location;
        }

        private void intersects()
        {
            Point ballCenter = new Point(ballRect.Left + (ballRect.Size.Width / 2), ballRect.Top + (ballRect.Size.Height / 2));

            foreach (PictureBox pcb in bricks)
            {
                if (pcb.Visible)
                {
                    Point pcbCenter = new Point(pcb.Location.X + (pcb.Size.Width / 2), pcb.Location.Y + (pcb.Size.Height / 2));
                    Rectangle rectBrick = new Rectangle(pcb.Location.X, pcb.Location.Y, pcb.Size.Width, pcb.Size.Height);

                    if (ballCenter.X >= rectBrick.Left &
                        ballCenter.X <= rectBrick.Right &
                        ballCenter.Y >= rectBrick.Top - ballRadius &
                        ballCenter.Y <= rectBrick.Top)
                    {
                        //reflectStr = "Top";
                        ballDirection.Y = -(Math.Abs(ballDirection.Y));
                        pcb.Visible = false;
                        score += 10;
                        return;
                    }
                    else if (ballCenter.X >= rectBrick.Left &
                        ballCenter.X <= rectBrick.Right &
                        ballCenter.Y >= rectBrick.Bottom &
                        ballCenter.Y <= rectBrick.Bottom + ballRadius)
                    {
                        //reflectStr = "Bottom";
                        ballDirection.Y = Math.Abs(ballDirection.Y);
                        pcb.Visible = false;
                        score += 10;
                        return;
                    }
                    else if (ballCenter.X >= rectBrick.Left - ballRadius &
                        ballCenter.X <= rectBrick.Left &
                        ballCenter.Y >= rectBrick.Top &
                        ballCenter.Y <= rectBrick.Bottom)
                    {
                        //reflectStr = "Left";
                        ballDirection.X = -(Math.Abs(ballDirection.X));
                        pcb.Visible = false;
                        score += 10;
                        return;
                    }
                    else if (ballCenter.X >= rectBrick.Right &
                        ballCenter.X <= rectBrick.Right + ballRadius &
                        ballCenter.Y >= rectBrick.Top &
                        ballCenter.Y <= rectBrick.Bottom)
                    {
                        //reflectStr = "Right";
                        ballDirection.X = Math.Abs(ballDirection.X);
                        pcb.Visible = false;
                        score += 10;
                        return;
                    }
                }
            }
        }

        private void uiUpdate()
        {
            lblScore.Text = "Score: " + score.ToString();
            lblLife.Text = new string('Y', lifeCount);
        }

        private void missBall()
        {
            lifeCount--;
            placeToStartLocation();
        }

        private void checkWinLose()
        {
            if (lifeCount == 0)
            {
                gameOver();
                return;
            }
            bool lvlClear = true;
            foreach (PictureBox pcb in bricks)
                if (pcb.Visible)
                    lvlClear = false;
            if (lvlClear)
                gameWin();
        }

        private void gameOver()
        {
            tmrBall.Enabled = false;
            foreach (PictureBox pcb in bricks)
                pcb.Visible = false;
            ball.Visible = false;
            paddle.Visible = false;
            pcbSign.Visible = true;
            pcbSign.BackgroundImage = global::Arkanoid.Properties.Resources.lblLose;
            gameDone = true;
        }

        private void gameWin()
        {
            tmrBall.Enabled = false;
            foreach (PictureBox pcb in bricks)
                pcb.Visible = false;
            ball.Visible = false;
            paddle.Visible = false;
            pcbSign.Visible = true;
            pcbSign.BackgroundImage = global::Arkanoid.Properties.Resources.lblWin;
            gameDone = true;
        }

        private void placeToStartLocation()
        {
            paddleRect.Location = startPaddleLocation;
            ballRect.Location = startBallLocation;
            ballDirection = startBallDirection;
            paddle.Location = paddleRect.Location;
            ball.Location = ballRect.Location;
        }
        private void tmrBall_Tick(object sender, EventArgs e)
        {
            shiftBall();
            intersects();
            uiUpdate();
            checkWinLose();
        }
    }
}
