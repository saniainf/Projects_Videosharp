namespace Labyrint2D
{
    partial class frmLevel_03
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblMoveWall = new System.Windows.Forms.Label();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblFinish.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinish.Location = new System.Drawing.Point(560, 412);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(80, 40);
            this.lblFinish.TabIndex = 1;
            this.lblFinish.Text = "Финиш";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinish.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblFinish_MouseMove);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(640, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 464);
            this.label4.TabIndex = 2;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 451);
            this.label3.TabIndex = 3;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-9, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(664, 25);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 25);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStart.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStart.Location = new System.Drawing.Point(15, 14);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(80, 40);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Старт";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoveWall
            // 
            this.lblMoveWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMoveWall.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoveWall.Location = new System.Drawing.Point(0, -3);
            this.lblMoveWall.Name = "lblMoveWall";
            this.lblMoveWall.Size = new System.Drawing.Size(15, 457);
            this.lblMoveWall.TabIndex = 3;
            this.lblMoveWall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMoveWall.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // tmrMove
            // 
            this.tmrMove.Enabled = true;
            this.tmrMove.Interval = 1;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(-4, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(565, 17);
            this.label5.TabIndex = 5;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(94, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(548, 17);
            this.label6.TabIndex = 5;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(-4, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(565, 17);
            this.label7.TabIndex = 5;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(94, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(548, 17);
            this.label8.TabIndex = 5;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // frmLevel_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(654, 469);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMoveWall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLevel_03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLevel_03";
            this.Shown += new System.EventHandler(this.frmLevel_03_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblMoveWall;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}