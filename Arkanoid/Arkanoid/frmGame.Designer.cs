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
            this.lblWallTop = new System.Windows.Forms.Label();
            this.lblWallLeft = new System.Windows.Forms.Label();
            this.lblWallRight = new System.Windows.Forms.Label();
            this.paddle = new System.Windows.Forms.Button();
            this.ball = new System.Windows.Forms.RadioButton();
            this.lblBrick1 = new System.Windows.Forms.Label();
            this.lblBrick2 = new System.Windows.Forms.Label();
            this.lblBrick3 = new System.Windows.Forms.Label();
            this.lblBrick4 = new System.Windows.Forms.Label();
            this.lblBrick7 = new System.Windows.Forms.Label();
            this.lblBrick6 = new System.Windows.Forms.Label();
            this.lblBrick5 = new System.Windows.Forms.Label();
            this.lblBrick8 = new System.Windows.Forms.Label();
            this.tmrBall = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblWallTop
            // 
            this.lblWallTop.BackColor = System.Drawing.Color.SlateGray;
            this.lblWallTop.Location = new System.Drawing.Point(-6, -6);
            this.lblWallTop.Name = "lblWallTop";
            this.lblWallTop.Size = new System.Drawing.Size(809, 23);
            this.lblWallTop.TabIndex = 0;
            // 
            // lblWallLeft
            // 
            this.lblWallLeft.BackColor = System.Drawing.Color.SlateGray;
            this.lblWallLeft.Location = new System.Drawing.Point(-3, -3);
            this.lblWallLeft.Name = "lblWallLeft";
            this.lblWallLeft.Size = new System.Drawing.Size(20, 574);
            this.lblWallLeft.TabIndex = 0;
            // 
            // lblWallRight
            // 
            this.lblWallRight.BackColor = System.Drawing.Color.SlateGray;
            this.lblWallRight.Location = new System.Drawing.Point(783, -3);
            this.lblWallRight.Name = "lblWallRight";
            this.lblWallRight.Size = new System.Drawing.Size(20, 574);
            this.lblWallRight.TabIndex = 0;
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.Color.MidnightBlue;
            this.paddle.Enabled = false;
            this.paddle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paddle.ForeColor = System.Drawing.Color.White;
            this.paddle.Location = new System.Drawing.Point(350, 574);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(102, 23);
            this.paddle.TabIndex = 1;
            this.paddle.Text = "------------";
            this.paddle.UseVisualStyleBackColor = false;
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Checked = true;
            this.ball.Enabled = false;
            this.ball.ForeColor = System.Drawing.Color.Transparent;
            this.ball.Location = new System.Drawing.Point(396, 555);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 13);
            this.ball.TabIndex = 2;
            this.ball.TabStop = true;
            this.ball.UseVisualStyleBackColor = false;
            // 
            // lblBrick1
            // 
            this.lblBrick1.BackColor = System.Drawing.Color.Firebrick;
            this.lblBrick1.Location = new System.Drawing.Point(114, 131);
            this.lblBrick1.Name = "lblBrick1";
            this.lblBrick1.Size = new System.Drawing.Size(75, 23);
            this.lblBrick1.TabIndex = 0;
            // 
            // lblBrick2
            // 
            this.lblBrick2.BackColor = System.Drawing.Color.Firebrick;
            this.lblBrick2.Location = new System.Drawing.Point(280, 131);
            this.lblBrick2.Name = "lblBrick2";
            this.lblBrick2.Size = new System.Drawing.Size(75, 23);
            this.lblBrick2.TabIndex = 0;
            // 
            // lblBrick3
            // 
            this.lblBrick3.BackColor = System.Drawing.Color.Firebrick;
            this.lblBrick3.Location = new System.Drawing.Point(446, 131);
            this.lblBrick3.Name = "lblBrick3";
            this.lblBrick3.Size = new System.Drawing.Size(75, 23);
            this.lblBrick3.TabIndex = 0;
            // 
            // lblBrick4
            // 
            this.lblBrick4.BackColor = System.Drawing.Color.Firebrick;
            this.lblBrick4.Location = new System.Drawing.Point(612, 131);
            this.lblBrick4.Name = "lblBrick4";
            this.lblBrick4.Size = new System.Drawing.Size(75, 23);
            this.lblBrick4.TabIndex = 0;
            // 
            // lblBrick7
            // 
            this.lblBrick7.BackColor = System.Drawing.Color.Firebrick;
            this.lblBrick7.Location = new System.Drawing.Point(529, 237);
            this.lblBrick7.Name = "lblBrick7";
            this.lblBrick7.Size = new System.Drawing.Size(75, 23);
            this.lblBrick7.TabIndex = 0;
            // 
            // lblBrick6
            // 
            this.lblBrick6.BackColor = System.Drawing.Color.Firebrick;
            this.lblBrick6.Location = new System.Drawing.Point(363, 237);
            this.lblBrick6.Name = "lblBrick6";
            this.lblBrick6.Size = new System.Drawing.Size(75, 23);
            this.lblBrick6.TabIndex = 0;
            // 
            // lblBrick5
            // 
            this.lblBrick5.BackColor = System.Drawing.Color.Firebrick;
            this.lblBrick5.Location = new System.Drawing.Point(197, 237);
            this.lblBrick5.Name = "lblBrick5";
            this.lblBrick5.Size = new System.Drawing.Size(75, 23);
            this.lblBrick5.TabIndex = 0;
            // 
            // lblBrick8
            // 
            this.lblBrick8.BackColor = System.Drawing.Color.Firebrick;
            this.lblBrick8.Location = new System.Drawing.Point(363, 343);
            this.lblBrick8.Name = "lblBrick8";
            this.lblBrick8.Size = new System.Drawing.Size(75, 23);
            this.lblBrick8.TabIndex = 0;
            // 
            // tmrBall
            // 
            this.tmrBall.Interval = 2;
            this.tmrBall.Tick += new System.EventHandler(this.tmrBall_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.lblWallRight);
            this.Controls.Add(this.lblWallLeft);
            this.Controls.Add(this.lblBrick5);
            this.Controls.Add(this.lblBrick8);
            this.Controls.Add(this.lblBrick6);
            this.Controls.Add(this.lblBrick7);
            this.Controls.Add(this.lblBrick4);
            this.Controls.Add(this.lblBrick3);
            this.Controls.Add(this.lblBrick2);
            this.Controls.Add(this.lblBrick1);
            this.Controls.Add(this.lblWallTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Арканоид";
            this.Shown += new System.EventHandler(this.frmGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWallTop;
        private System.Windows.Forms.Label lblWallLeft;
        private System.Windows.Forms.Label lblWallRight;
        private System.Windows.Forms.Button paddle;
        private System.Windows.Forms.RadioButton ball;
        private System.Windows.Forms.Label lblBrick1;
        private System.Windows.Forms.Label lblBrick2;
        private System.Windows.Forms.Label lblBrick3;
        private System.Windows.Forms.Label lblBrick4;
        private System.Windows.Forms.Label lblBrick7;
        private System.Windows.Forms.Label lblBrick6;
        private System.Windows.Forms.Label lblBrick5;
        private System.Windows.Forms.Label lblBrick8;
        private System.Windows.Forms.Timer tmrBall;
    }
}