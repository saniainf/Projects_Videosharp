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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlUserRock = new System.Windows.Forms.Panel();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.pnlUserScissors = new System.Windows.Forms.Panel();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.pnlUserPaper = new System.Windows.Forms.Panel();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlUserRock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            this.pnlUserScissors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            this.pnlUserPaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserRock
            // 
            this.pnlUserRock.BackColor = System.Drawing.Color.White;
            this.pnlUserRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserRock.Controls.Add(this.picRock);
            this.pnlUserRock.Location = new System.Drawing.Point(26, 25);
            this.pnlUserRock.Name = "pnlUserRock";
            this.pnlUserRock.Size = new System.Drawing.Size(120, 120);
            this.pnlUserRock.TabIndex = 0;
            this.pnlUserRock.Tag = "Rock";
            this.pnlUserRock.MouseEnter += new System.EventHandler(this.pnlUserSelect_MouseEnter);
            // 
            // picRock
            // 
            this.picRock.Image = ((System.Drawing.Image)(resources.GetObject("picRock.Image")));
            this.picRock.Location = new System.Drawing.Point(0, 0);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(120, 120);
            this.picRock.TabIndex = 1;
            this.picRock.TabStop = false;
            this.picRock.Visible = false;
            // 
            // pnlUserScissors
            // 
            this.pnlUserScissors.BackColor = System.Drawing.Color.White;
            this.pnlUserScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserScissors.Controls.Add(this.picScissors);
            this.pnlUserScissors.Location = new System.Drawing.Point(176, 25);
            this.pnlUserScissors.Name = "pnlUserScissors";
            this.pnlUserScissors.Size = new System.Drawing.Size(120, 120);
            this.pnlUserScissors.TabIndex = 0;
            this.pnlUserScissors.Tag = "Scissors";
            this.pnlUserScissors.MouseEnter += new System.EventHandler(this.pnlUserSelect_MouseEnter);
            // 
            // picScissors
            // 
            this.picScissors.Image = ((System.Drawing.Image)(resources.GetObject("picScissors.Image")));
            this.picScissors.Location = new System.Drawing.Point(0, 0);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(120, 120);
            this.picScissors.TabIndex = 1;
            this.picScissors.TabStop = false;
            this.picScissors.Visible = false;
            // 
            // pnlUserPaper
            // 
            this.pnlUserPaper.BackColor = System.Drawing.Color.White;
            this.pnlUserPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserPaper.Controls.Add(this.picPaper);
            this.pnlUserPaper.Location = new System.Drawing.Point(326, 25);
            this.pnlUserPaper.Name = "pnlUserPaper";
            this.pnlUserPaper.Size = new System.Drawing.Size(120, 120);
            this.pnlUserPaper.TabIndex = 0;
            this.pnlUserPaper.Tag = "Paper";
            this.pnlUserPaper.MouseEnter += new System.EventHandler(this.pnlUserSelect_MouseEnter);
            // 
            // picPaper
            // 
            this.picPaper.Image = ((System.Drawing.Image)(resources.GetObject("picPaper.Image")));
            this.picPaper.Location = new System.Drawing.Point(0, 0);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(120, 120);
            this.picPaper.TabIndex = 1;
            this.picPaper.TabStop = false;
            this.picPaper.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(561, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 120);
            this.panel4.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 391);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlUserPaper);
            this.Controls.Add(this.pnlUserScissors);
            this.Controls.Add(this.pnlUserRock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камень Ножницы Бумага";
            this.pnlUserRock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            this.pnlUserScissors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            this.pnlUserPaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserRock;
        private System.Windows.Forms.Panel pnlUserScissors;
        private System.Windows.Forms.Panel pnlUserPaper;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.PictureBox picPaper;
    }
}

