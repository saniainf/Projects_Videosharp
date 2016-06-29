namespace Labyrint2D
{
    partial class frmLevel_02
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblDoor = new System.Windows.Forms.Label();
            this.lblFlash1 = new System.Windows.Forms.Label();
            this.tmrFlash = new System.Windows.Forms.Timer(this.components);
            this.lblFlash2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblFinish.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinish.Location = new System.Drawing.Point(559, 415);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(80, 40);
            this.lblFinish.TabIndex = 1;
            this.lblFinish.Text = "Финиш";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinish.MouseEnter += new System.EventHandler(this.lblFinish_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(639, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 464);
            this.label4.TabIndex = 2;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(128, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 287);
            this.label5.TabIndex = 3;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 451);
            this.label3.TabIndex = 4;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-10, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(664, 25);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, -10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 25);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStart.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStart.Location = new System.Drawing.Point(14, 15);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(80, 40);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Старт";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(308, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 20);
            this.label6.TabIndex = 3;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(539, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 287);
            this.label7.TabIndex = 3;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // lblKey
            // 
            this.lblKey.BackColor = System.Drawing.Color.Yellow;
            this.lblKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKey.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKey.Location = new System.Drawing.Point(539, 62);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(80, 40);
            this.lblKey.TabIndex = 7;
            this.lblKey.Text = "Ключ";
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKey.MouseEnter += new System.EventHandler(this.lblKey_MouseEnter);
            // 
            // lblDoor
            // 
            this.lblDoor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDoor.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDoor.Location = new System.Drawing.Point(543, 222);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(111, 25);
            this.lblDoor.TabIndex = 7;
            this.lblDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDoor.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // lblFlash1
            // 
            this.lblFlash1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFlash1.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFlash1.Location = new System.Drawing.Point(138, 276);
            this.lblFlash1.Name = "lblFlash1";
            this.lblFlash1.Size = new System.Drawing.Size(408, 20);
            this.lblFlash1.TabIndex = 3;
            this.lblFlash1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFlash1.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // tmrFlash
            // 
            this.tmrFlash.Interval = 800;
            this.tmrFlash.Tick += new System.EventHandler(this.tmrFlash_Tick);
            // 
            // lblFlash2
            // 
            this.lblFlash2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFlash2.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFlash2.Location = new System.Drawing.Point(128, 286);
            this.lblFlash2.Name = "lblFlash2";
            this.lblFlash2.Size = new System.Drawing.Size(20, 174);
            this.lblFlash2.TabIndex = 3;
            this.lblFlash2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFlash2.MouseEnter += new System.EventHandler(this.lblWall_MouseEnter);
            // 
            // frmLevel_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(654, 469);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFlash1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFlash2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblDoor);
            this.Controls.Add(this.lblStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLevel_02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLevel_02";
            this.Shown += new System.EventHandler(this.frmLevel_02_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblDoor;
        private System.Windows.Forms.Label lblFlash1;
        private System.Windows.Forms.Timer tmrFlash;
        private System.Windows.Forms.Label lblFlash2;
    }
}