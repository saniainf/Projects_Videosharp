namespace MemoryGame
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGameNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGameExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpRules = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tblpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            this.pcb3 = new System.Windows.Forms.PictureBox();
            this.pcb4 = new System.Windows.Forms.PictureBox();
            this.pcb5 = new System.Windows.Forms.PictureBox();
            this.pcb6 = new System.Windows.Forms.PictureBox();
            this.pcb7 = new System.Windows.Forms.PictureBox();
            this.pcb8 = new System.Windows.Forms.PictureBox();
            this.pcb9 = new System.Windows.Forms.PictureBox();
            this.pcb10 = new System.Windows.Forms.PictureBox();
            this.pcb11 = new System.Windows.Forms.PictureBox();
            this.pcb12 = new System.Windows.Forms.PictureBox();
            this.pcb13 = new System.Windows.Forms.PictureBox();
            this.pcb14 = new System.Windows.Forms.PictureBox();
            this.pcb15 = new System.Windows.Forms.PictureBox();
            this.pcb16 = new System.Windows.Forms.PictureBox();
            this.pcbStartPicture = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            this.tblpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStartPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGame,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(572, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuGame
            // 
            this.mnuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGameNewGame,
            this.mnuSep1,
            this.mnuGameExit});
            this.mnuGame.Name = "mnuGame";
            this.mnuGame.Size = new System.Drawing.Size(46, 20);
            this.mnuGame.Text = "Игра";
            // 
            // mnuGameNewGame
            // 
            this.mnuGameNewGame.Name = "mnuGameNewGame";
            this.mnuGameNewGame.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuGameNewGame.Size = new System.Drawing.Size(155, 22);
            this.mnuGameNewGame.Text = "Новая игра";
            this.mnuGameNewGame.Click += new System.EventHandler(this.mnuGameNewGame_Click);
            // 
            // mnuSep1
            // 
            this.mnuSep1.Name = "mnuSep1";
            this.mnuSep1.Size = new System.Drawing.Size(152, 6);
            // 
            // mnuGameExit
            // 
            this.mnuGameExit.Name = "mnuGameExit";
            this.mnuGameExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuGameExit.Size = new System.Drawing.Size(155, 22);
            this.mnuGameExit.Text = "Выход";
            this.mnuGameExit.Click += new System.EventHandler(this.mnuGameExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpRules,
            this.mnuSep2,
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(68, 20);
            this.mnuHelp.Text = "Помощь";
            // 
            // mnuHelpRules
            // 
            this.mnuHelpRules.Name = "mnuHelpRules";
            this.mnuHelpRules.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuHelpRules.Size = new System.Drawing.Size(195, 22);
            this.mnuHelpRules.Text = "Правила игры";
            this.mnuHelpRules.Click += new System.EventHandler(this.mnuHelpRules_Click);
            // 
            // mnuSep2
            // 
            this.mnuSep2.Name = "mnuSep2";
            this.mnuSep2.Size = new System.Drawing.Size(192, 6);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mnuHelpAbout.Size = new System.Drawing.Size(195, 22);
            this.mnuHelpAbout.Text = "О программе";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // tblpMain
            // 
            this.tblpMain.BackColor = System.Drawing.Color.PapayaWhip;
            this.tblpMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblpMain.ColumnCount = 4;
            this.tblpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tblpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tblpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tblpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tblpMain.Controls.Add(this.pcb1, 0, 0);
            this.tblpMain.Controls.Add(this.pcb2, 1, 0);
            this.tblpMain.Controls.Add(this.pcb3, 2, 0);
            this.tblpMain.Controls.Add(this.pcb4, 3, 0);
            this.tblpMain.Controls.Add(this.pcb5, 0, 1);
            this.tblpMain.Controls.Add(this.pcb6, 1, 1);
            this.tblpMain.Controls.Add(this.pcb7, 2, 1);
            this.tblpMain.Controls.Add(this.pcb8, 3, 1);
            this.tblpMain.Controls.Add(this.pcb9, 0, 2);
            this.tblpMain.Controls.Add(this.pcb10, 1, 2);
            this.tblpMain.Controls.Add(this.pcb11, 2, 2);
            this.tblpMain.Controls.Add(this.pcb12, 3, 2);
            this.tblpMain.Controls.Add(this.pcb13, 0, 3);
            this.tblpMain.Controls.Add(this.pcb14, 1, 3);
            this.tblpMain.Controls.Add(this.pcb15, 2, 3);
            this.tblpMain.Controls.Add(this.pcb16, 3, 3);
            this.tblpMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblpMain.Location = new System.Drawing.Point(11, 37);
            this.tblpMain.Name = "tblpMain";
            this.tblpMain.RowCount = 4;
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tblpMain.Size = new System.Drawing.Size(550, 550);
            this.tblpMain.TabIndex = 1;
            // 
            // pcb1
            // 
            this.pcb1.Image = global::MemoryGame.Properties.Resources._0;
            this.pcb1.Location = new System.Drawing.Point(6, 6);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(128, 128);
            this.pcb1.TabIndex = 0;
            this.pcb1.TabStop = false;
            this.pcb1.Tag = "0";
            this.pcb1.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb2
            // 
            this.pcb2.Image = ((System.Drawing.Image)(resources.GetObject("pcb2.Image")));
            this.pcb2.Location = new System.Drawing.Point(143, 6);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(128, 128);
            this.pcb2.TabIndex = 0;
            this.pcb2.TabStop = false;
            this.pcb2.Tag = "1";
            this.pcb2.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb3
            // 
            this.pcb3.Image = ((System.Drawing.Image)(resources.GetObject("pcb3.Image")));
            this.pcb3.Location = new System.Drawing.Point(280, 6);
            this.pcb3.Name = "pcb3";
            this.pcb3.Size = new System.Drawing.Size(128, 128);
            this.pcb3.TabIndex = 0;
            this.pcb3.TabStop = false;
            this.pcb3.Tag = "2";
            this.pcb3.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb4
            // 
            this.pcb4.Image = global::MemoryGame.Properties.Resources._0;
            this.pcb4.Location = new System.Drawing.Point(417, 6);
            this.pcb4.Name = "pcb4";
            this.pcb4.Size = new System.Drawing.Size(128, 128);
            this.pcb4.TabIndex = 0;
            this.pcb4.TabStop = false;
            this.pcb4.Tag = "3";
            this.pcb4.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb5
            // 
            this.pcb5.Image = ((System.Drawing.Image)(resources.GetObject("pcb5.Image")));
            this.pcb5.Location = new System.Drawing.Point(6, 143);
            this.pcb5.Name = "pcb5";
            this.pcb5.Size = new System.Drawing.Size(128, 128);
            this.pcb5.TabIndex = 0;
            this.pcb5.TabStop = false;
            this.pcb5.Tag = "4";
            this.pcb5.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb6
            // 
            this.pcb6.Image = ((System.Drawing.Image)(resources.GetObject("pcb6.Image")));
            this.pcb6.Location = new System.Drawing.Point(143, 143);
            this.pcb6.Name = "pcb6";
            this.pcb6.Size = new System.Drawing.Size(128, 128);
            this.pcb6.TabIndex = 0;
            this.pcb6.TabStop = false;
            this.pcb6.Tag = "5";
            this.pcb6.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb7
            // 
            this.pcb7.Image = ((System.Drawing.Image)(resources.GetObject("pcb7.Image")));
            this.pcb7.Location = new System.Drawing.Point(280, 143);
            this.pcb7.Name = "pcb7";
            this.pcb7.Size = new System.Drawing.Size(128, 128);
            this.pcb7.TabIndex = 0;
            this.pcb7.TabStop = false;
            this.pcb7.Tag = "6";
            this.pcb7.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb8
            // 
            this.pcb8.Image = ((System.Drawing.Image)(resources.GetObject("pcb8.Image")));
            this.pcb8.Location = new System.Drawing.Point(417, 143);
            this.pcb8.Name = "pcb8";
            this.pcb8.Size = new System.Drawing.Size(128, 128);
            this.pcb8.TabIndex = 0;
            this.pcb8.TabStop = false;
            this.pcb8.Tag = "7";
            this.pcb8.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb9
            // 
            this.pcb9.Image = ((System.Drawing.Image)(resources.GetObject("pcb9.Image")));
            this.pcb9.Location = new System.Drawing.Point(6, 280);
            this.pcb9.Name = "pcb9";
            this.pcb9.Size = new System.Drawing.Size(128, 128);
            this.pcb9.TabIndex = 0;
            this.pcb9.TabStop = false;
            this.pcb9.Tag = "8";
            this.pcb9.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb10
            // 
            this.pcb10.Image = ((System.Drawing.Image)(resources.GetObject("pcb10.Image")));
            this.pcb10.Location = new System.Drawing.Point(143, 280);
            this.pcb10.Name = "pcb10";
            this.pcb10.Size = new System.Drawing.Size(128, 128);
            this.pcb10.TabIndex = 0;
            this.pcb10.TabStop = false;
            this.pcb10.Tag = "9";
            this.pcb10.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb11
            // 
            this.pcb11.Image = ((System.Drawing.Image)(resources.GetObject("pcb11.Image")));
            this.pcb11.Location = new System.Drawing.Point(280, 280);
            this.pcb11.Name = "pcb11";
            this.pcb11.Size = new System.Drawing.Size(128, 128);
            this.pcb11.TabIndex = 0;
            this.pcb11.TabStop = false;
            this.pcb11.Tag = "10";
            this.pcb11.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb12
            // 
            this.pcb12.Image = ((System.Drawing.Image)(resources.GetObject("pcb12.Image")));
            this.pcb12.Location = new System.Drawing.Point(417, 280);
            this.pcb12.Name = "pcb12";
            this.pcb12.Size = new System.Drawing.Size(128, 128);
            this.pcb12.TabIndex = 0;
            this.pcb12.TabStop = false;
            this.pcb12.Tag = "11";
            this.pcb12.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb13
            // 
            this.pcb13.Image = ((System.Drawing.Image)(resources.GetObject("pcb13.Image")));
            this.pcb13.Location = new System.Drawing.Point(6, 417);
            this.pcb13.Name = "pcb13";
            this.pcb13.Size = new System.Drawing.Size(128, 128);
            this.pcb13.TabIndex = 0;
            this.pcb13.TabStop = false;
            this.pcb13.Tag = "12";
            this.pcb13.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb14
            // 
            this.pcb14.Image = ((System.Drawing.Image)(resources.GetObject("pcb14.Image")));
            this.pcb14.Location = new System.Drawing.Point(143, 417);
            this.pcb14.Name = "pcb14";
            this.pcb14.Size = new System.Drawing.Size(128, 128);
            this.pcb14.TabIndex = 0;
            this.pcb14.TabStop = false;
            this.pcb14.Tag = "13";
            this.pcb14.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb15
            // 
            this.pcb15.Image = ((System.Drawing.Image)(resources.GetObject("pcb15.Image")));
            this.pcb15.Location = new System.Drawing.Point(280, 417);
            this.pcb15.Name = "pcb15";
            this.pcb15.Size = new System.Drawing.Size(128, 128);
            this.pcb15.TabIndex = 0;
            this.pcb15.TabStop = false;
            this.pcb15.Tag = "14";
            this.pcb15.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcb16
            // 
            this.pcb16.Image = ((System.Drawing.Image)(resources.GetObject("pcb16.Image")));
            this.pcb16.Location = new System.Drawing.Point(417, 417);
            this.pcb16.Name = "pcb16";
            this.pcb16.Size = new System.Drawing.Size(128, 128);
            this.pcb16.TabIndex = 0;
            this.pcb16.TabStop = false;
            this.pcb16.Tag = "15";
            this.pcb16.Click += new System.EventHandler(this.pcb_Click);
            // 
            // pcbStartPicture
            // 
            this.pcbStartPicture.BackgroundImage = global::MemoryGame.Properties.Resources.Memory_Game;
            this.pcbStartPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbStartPicture.Location = new System.Drawing.Point(0, 28);
            this.pcbStartPicture.Name = "pcbStartPicture";
            this.pcbStartPicture.Size = new System.Drawing.Size(572, 568);
            this.pcbStartPicture.TabIndex = 2;
            this.pcbStartPicture.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(572, 598);
            this.Controls.Add(this.pcbStartPicture);
            this.Controls.Add(this.tblpMain);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mario Memory Game";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tblpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStartPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuGame;
        private System.Windows.Forms.ToolStripMenuItem mnuGameNewGame;
        private System.Windows.Forms.ToolStripSeparator mnuSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuGameExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpRules;
        private System.Windows.Forms.ToolStripSeparator mnuSep2;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.TableLayoutPanel tblpMain;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.PictureBox pcb3;
        private System.Windows.Forms.PictureBox pcb4;
        private System.Windows.Forms.PictureBox pcb5;
        private System.Windows.Forms.PictureBox pcb6;
        private System.Windows.Forms.PictureBox pcb7;
        private System.Windows.Forms.PictureBox pcb8;
        private System.Windows.Forms.PictureBox pcb9;
        private System.Windows.Forms.PictureBox pcb10;
        private System.Windows.Forms.PictureBox pcb11;
        private System.Windows.Forms.PictureBox pcb12;
        private System.Windows.Forms.PictureBox pcb13;
        private System.Windows.Forms.PictureBox pcb14;
        private System.Windows.Forms.PictureBox pcb15;
        private System.Windows.Forms.PictureBox pcb16;
        private System.Windows.Forms.PictureBox pcbStartPicture;
    }
}

