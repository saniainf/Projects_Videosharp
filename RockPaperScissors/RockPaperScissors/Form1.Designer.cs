namespace RockPaperScissors
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlUserRock = new System.Windows.Forms.Panel();
            this.picUserRock = new System.Windows.Forms.PictureBox();
            this.pnlUserScissors = new System.Windows.Forms.Panel();
            this.picUserScissors = new System.Windows.Forms.PictureBox();
            this.pnlUserPaper = new System.Windows.Forms.Panel();
            this.picUserPaper = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picCompRock = new System.Windows.Forms.PictureBox();
            this.picCompScissors = new System.Windows.Forms.PictureBox();
            this.picCompPaper = new System.Windows.Forms.PictureBox();
            this.tmrCompSelect = new System.Windows.Forms.Timer(this.components);
            this.lblMsgUser = new System.Windows.Forms.Label();
            this.lblCompSelect = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.trbDifficulty = new System.Windows.Forms.TrackBar();
            this.pnlUserRock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserRock)).BeginInit();
            this.pnlUserScissors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserScissors)).BeginInit();
            this.pnlUserPaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPaper)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserRock
            // 
            this.pnlUserRock.BackColor = System.Drawing.Color.White;
            this.pnlUserRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserRock.Controls.Add(this.picUserRock);
            this.pnlUserRock.Location = new System.Drawing.Point(12, 55);
            this.pnlUserRock.Name = "pnlUserRock";
            this.pnlUserRock.Size = new System.Drawing.Size(120, 120);
            this.pnlUserRock.TabIndex = 0;
            this.pnlUserRock.Tag = "Rock";
            this.pnlUserRock.MouseEnter += new System.EventHandler(this.pnlUserSelect_MouseEnter);
            // 
            // picUserRock
            // 
            this.picUserRock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picUserRock.Image = ((System.Drawing.Image)(resources.GetObject("picUserRock.Image")));
            this.picUserRock.Location = new System.Drawing.Point(0, 0);
            this.picUserRock.Name = "picUserRock";
            this.picUserRock.Size = new System.Drawing.Size(118, 118);
            this.picUserRock.TabIndex = 1;
            this.picUserRock.TabStop = false;
            this.picUserRock.Visible = false;
            this.picUserRock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userSelect_MouseClick);
            // 
            // pnlUserScissors
            // 
            this.pnlUserScissors.BackColor = System.Drawing.Color.White;
            this.pnlUserScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserScissors.Controls.Add(this.picUserScissors);
            this.pnlUserScissors.Location = new System.Drawing.Point(162, 55);
            this.pnlUserScissors.Name = "pnlUserScissors";
            this.pnlUserScissors.Size = new System.Drawing.Size(120, 120);
            this.pnlUserScissors.TabIndex = 0;
            this.pnlUserScissors.Tag = "Scissors";
            this.pnlUserScissors.MouseEnter += new System.EventHandler(this.pnlUserSelect_MouseEnter);
            // 
            // picUserScissors
            // 
            this.picUserScissors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picUserScissors.Image = ((System.Drawing.Image)(resources.GetObject("picUserScissors.Image")));
            this.picUserScissors.Location = new System.Drawing.Point(0, 0);
            this.picUserScissors.Name = "picUserScissors";
            this.picUserScissors.Size = new System.Drawing.Size(118, 118);
            this.picUserScissors.TabIndex = 1;
            this.picUserScissors.TabStop = false;
            this.picUserScissors.Visible = false;
            this.picUserScissors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userSelect_MouseClick);
            // 
            // pnlUserPaper
            // 
            this.pnlUserPaper.BackColor = System.Drawing.Color.White;
            this.pnlUserPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserPaper.Controls.Add(this.picUserPaper);
            this.pnlUserPaper.Location = new System.Drawing.Point(312, 55);
            this.pnlUserPaper.Name = "pnlUserPaper";
            this.pnlUserPaper.Size = new System.Drawing.Size(120, 120);
            this.pnlUserPaper.TabIndex = 0;
            this.pnlUserPaper.Tag = "Paper";
            this.pnlUserPaper.MouseEnter += new System.EventHandler(this.pnlUserSelect_MouseEnter);
            // 
            // picUserPaper
            // 
            this.picUserPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picUserPaper.Image = ((System.Drawing.Image)(resources.GetObject("picUserPaper.Image")));
            this.picUserPaper.Location = new System.Drawing.Point(0, 0);
            this.picUserPaper.Name = "picUserPaper";
            this.picUserPaper.Size = new System.Drawing.Size(118, 118);
            this.picUserPaper.TabIndex = 1;
            this.picUserPaper.TabStop = false;
            this.picUserPaper.Visible = false;
            this.picUserPaper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userSelect_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.picCompPaper);
            this.panel4.Controls.Add(this.picCompRock);
            this.panel4.Controls.Add(this.picCompScissors);
            this.panel4.Location = new System.Drawing.Point(510, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 120);
            this.panel4.TabIndex = 0;
            // 
            // picCompRock
            // 
            this.picCompRock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCompRock.Image = ((System.Drawing.Image)(resources.GetObject("picCompRock.Image")));
            this.picCompRock.Location = new System.Drawing.Point(0, 0);
            this.picCompRock.Name = "picCompRock";
            this.picCompRock.Size = new System.Drawing.Size(118, 118);
            this.picCompRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCompRock.TabIndex = 1;
            this.picCompRock.TabStop = false;
            this.picCompRock.Visible = false;
            // 
            // picCompScissors
            // 
            this.picCompScissors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCompScissors.Image = ((System.Drawing.Image)(resources.GetObject("picCompScissors.Image")));
            this.picCompScissors.Location = new System.Drawing.Point(0, 0);
            this.picCompScissors.Name = "picCompScissors";
            this.picCompScissors.Size = new System.Drawing.Size(118, 118);
            this.picCompScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCompScissors.TabIndex = 1;
            this.picCompScissors.TabStop = false;
            this.picCompScissors.Visible = false;
            // 
            // picCompPaper
            // 
            this.picCompPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCompPaper.Image = ((System.Drawing.Image)(resources.GetObject("picCompPaper.Image")));
            this.picCompPaper.Location = new System.Drawing.Point(0, 0);
            this.picCompPaper.Name = "picCompPaper";
            this.picCompPaper.Size = new System.Drawing.Size(118, 118);
            this.picCompPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCompPaper.TabIndex = 1;
            this.picCompPaper.TabStop = false;
            this.picCompPaper.Visible = false;
            // 
            // tmrCompSelect
            // 
            this.tmrCompSelect.Enabled = true;
            this.tmrCompSelect.Interval = 30;
            this.tmrCompSelect.Tick += new System.EventHandler(this.tmrCompSelect_Tick);
            // 
            // lblMsgUser
            // 
            this.lblMsgUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMsgUser.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMsgUser.Location = new System.Drawing.Point(12, 14);
            this.lblMsgUser.Name = "lblMsgUser";
            this.lblMsgUser.Size = new System.Drawing.Size(420, 30);
            this.lblMsgUser.TabIndex = 1;
            this.lblMsgUser.Text = "Выбери свою фигуру";
            this.lblMsgUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompSelect
            // 
            this.lblCompSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompSelect.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompSelect.Location = new System.Drawing.Point(510, 14);
            this.lblCompSelect.Name = "lblCompSelect";
            this.lblCompSelect.Size = new System.Drawing.Size(120, 30);
            this.lblCompSelect.TabIndex = 1;
            this.lblCompSelect.Text = "Рука компьютера";
            this.lblCompSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(12, 188);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(618, 56);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "label1";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbDifficulty
            // 
            this.trbDifficulty.LargeChange = 1;
            this.trbDifficulty.Location = new System.Drawing.Point(448, 56);
            this.trbDifficulty.Maximum = 5;
            this.trbDifficulty.Minimum = 1;
            this.trbDifficulty.Name = "trbDifficulty";
            this.trbDifficulty.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbDifficulty.Size = new System.Drawing.Size(45, 118);
            this.trbDifficulty.TabIndex = 2;
            this.trbDifficulty.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trbDifficulty.Value = 3;
            this.trbDifficulty.ValueChanged += new System.EventHandler(this.trbDifficulty_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 258);
            this.Controls.Add(this.trbDifficulty);
            this.Controls.Add(this.lblCompSelect);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblMsgUser);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlUserPaper);
            this.Controls.Add(this.pnlUserScissors);
            this.Controls.Add(this.pnlUserRock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камень Ножницы Бумага";
            this.pnlUserRock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserRock)).EndInit();
            this.pnlUserScissors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserScissors)).EndInit();
            this.pnlUserPaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserPaper)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCompRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserRock;
        private System.Windows.Forms.Panel pnlUserScissors;
        private System.Windows.Forms.Panel pnlUserPaper;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picUserRock;
        private System.Windows.Forms.PictureBox picUserScissors;
        private System.Windows.Forms.PictureBox picUserPaper;
        private System.Windows.Forms.PictureBox picCompRock;
        private System.Windows.Forms.PictureBox picCompScissors;
        private System.Windows.Forms.PictureBox picCompPaper;
        private System.Windows.Forms.Timer tmrCompSelect;
        private System.Windows.Forms.Label lblMsgUser;
        private System.Windows.Forms.Label lblCompSelect;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TrackBar trbDifficulty;
    }
}

