namespace Arkanoid
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.tmrBall = new System.Windows.Forms.Timer(this.components);
            this.leftWall = new System.Windows.Forms.PictureBox();
            this.TopWall = new System.Windows.Forms.PictureBox();
            this.rightWall = new System.Windows.Forms.PictureBox();
            this.paddle = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrBall
            // 
            this.tmrBall.Enabled = true;
            this.tmrBall.Interval = 7;
            this.tmrBall.Tick += new System.EventHandler(this.tmrBall_Tick);
            // 
            // leftWall
            // 
            this.leftWall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftWall.BackgroundImage")));
            this.leftWall.Location = new System.Drawing.Point(0, 0);
            this.leftWall.Name = "leftWall";
            this.leftWall.Size = new System.Drawing.Size(32, 768);
            this.leftWall.TabIndex = 3;
            this.leftWall.TabStop = false;
            // 
            // TopWall
            // 
            this.TopWall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopWall.BackgroundImage")));
            this.TopWall.Location = new System.Drawing.Point(0, 0);
            this.TopWall.Name = "TopWall";
            this.TopWall.Size = new System.Drawing.Size(1024, 32);
            this.TopWall.TabIndex = 3;
            this.TopWall.TabStop = false;
            // 
            // rightWall
            // 
            this.rightWall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightWall.BackgroundImage")));
            this.rightWall.Location = new System.Drawing.Point(992, 0);
            this.rightWall.Name = "rightWall";
            this.rightWall.Size = new System.Drawing.Size(32, 768);
            this.rightWall.TabIndex = 3;
            this.rightWall.TabStop = false;
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.Color.Transparent;
            this.paddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paddle.BackgroundImage")));
            this.paddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paddle.Location = new System.Drawing.Point(464, 732);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(96, 24);
            this.paddle.TabIndex = 5;
            this.paddle.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.Location = new System.Drawing.Point(497, 704);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 6;
            this.ball.TabStop = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.TopWall);
            this.Controls.Add(this.rightWall);
            this.Controls.Add(this.leftWall);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Арканоид";
            this.Shown += new System.EventHandler(this.frmGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.leftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrBall;
        private System.Windows.Forms.PictureBox leftWall;
        private System.Windows.Forms.PictureBox TopWall;
        private System.Windows.Forms.PictureBox rightWall;
        private System.Windows.Forms.PictureBox paddle;
        private System.Windows.Forms.PictureBox ball;
    }
}