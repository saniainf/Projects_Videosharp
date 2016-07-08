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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 768);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1024, 32);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(992, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 768);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Location = new System.Drawing.Point(555, 455);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(96, 24);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(647, 391);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.lblBrick5);
            this.Controls.Add(this.lblBrick8);
            this.Controls.Add(this.lblBrick6);
            this.Controls.Add(this.lblBrick7);
            this.Controls.Add(this.lblBrick4);
            this.Controls.Add(this.lblBrick3);
            this.Controls.Add(this.lblBrick2);
            this.Controls.Add(this.lblBrick1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Арканоид";
            this.Shown += new System.EventHandler(this.frmGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}