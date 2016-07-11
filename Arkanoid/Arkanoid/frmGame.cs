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
            fillBricksGameField();
        }

        private void fillBricksGameField()
        {
            startBricks = new Point(40, 40);
            bricks = new List<PictureBox>();
            for (int j = 8; j >= 0; j--)
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
            }
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
                placeToStartLocation();
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
                }
            }

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
        }
    }
}
