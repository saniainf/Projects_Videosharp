namespace Labyrint2D
{
    partial class frmLevel_04
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
            this.lblFinish = new System.Windows.Forms.Label();
            this.wallRight = new System.Windows.Forms.Label();
            this.wallBottom = new System.Windows.Forms.Label();
            this.wallTop = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.wallLeft = new System.Windows.Forms.Label();
            this.tmrRiseWall = new System.Windows.Forms.Timer(this.components);
            this.lblKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblFinish.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinish.Location = new System.Drawing.Point(613, 9);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(27, 444);
            this.lblFinish.TabIndex = 7;
            this.lblFinish.Text = "Ф\r\nи\r\nн\r\nи\r\nш\r\n";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinish.MouseEnter += new System.EventHandler(this.lblFinish_MouseEnter);
            // 
            // wallRight
            // 
            this.wallRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wallRight.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wallRight.Location = new System.Drawing.Point(640, 4);
            this.wallRight.Name = "wallRight";
            this.wallRight.Size = new System.Drawing.Size(20, 464);
            this.wallRight.TabIndex = 8;
            this.wallRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wallRight.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // wallBottom
            // 
            this.wallBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wallBottom.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wallBottom.Location = new System.Drawing.Point(-9, 453);
            this.wallBottom.Name = "wallBottom";
            this.wallBottom.Size = new System.Drawing.Size(664, 25);
            this.wallBottom.TabIndex = 10;
            this.wallBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wallBottom.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // wallTop
            // 
            this.wallTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wallTop.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wallTop.Location = new System.Drawing.Point(0, -10);
            this.wallTop.Name = "wallTop";
            this.wallTop.Size = new System.Drawing.Size(664, 25);
            this.wallTop.TabIndex = 11;
            this.wallTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wallTop.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStart.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStart.Location = new System.Drawing.Point(12, 4);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(31, 456);
            this.lblStart.TabIndex = 12;
            this.lblStart.Text = "С\r\nт\r\nа\r\nр\r\nт";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wallLeft
            // 
            this.wallLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wallLeft.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wallLeft.Location = new System.Drawing.Point(-5, 2);
            this.wallLeft.Name = "wallLeft";
            this.wallLeft.Size = new System.Drawing.Size(20, 451);
            this.wallLeft.TabIndex = 13;
            this.wallLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wallLeft.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // tmrRiseWall
            // 
            this.tmrRiseWall.Interval = 800;
            this.tmrRiseWall.Tick += new System.EventHandler(this.tmrRiseWall_Tick);
            // 
            // lblKey
            // 
            this.lblKey.BackColor = System.Drawing.Color.Yellow;
            this.lblKey.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKey.Location = new System.Drawing.Point(76, 318);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(20, 20);
            this.lblKey.TabIndex = 13;
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKey.MouseEnter += new System.EventHandler(this.lblKey_MouseEnter);
            // 
            // frmLevel_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(654, 469);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.wallLeft);
            this.Controls.Add(this.wallRight);
            this.Controls.Add(this.wallBottom);
            this.Controls.Add(this.wallTop);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLevel_04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLevel_04";
            this.Shown += new System.EventHandler(this.frmLevel_04_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label wallRight;
        private System.Windows.Forms.Label wallBottom;
        private System.Windows.Forms.Label wallTop;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label wallLeft;
        private System.Windows.Forms.Timer tmrRiseWall;
        private System.Windows.Forms.Label lblKey;
    }
}