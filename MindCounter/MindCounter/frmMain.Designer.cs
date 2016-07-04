namespace MindCounter
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
            this.lblThink = new System.Windows.Forms.Label();
            this.txbAnswer = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prbProgress = new System.Windows.Forms.ProgressBar();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDivs = new System.Windows.Forms.Button();
            this.txbMax = new System.Windows.Forms.TextBox();
            this.prbAnswerTime = new System.Windows.Forms.ProgressBar();
            this.tmrAnswer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblThink
            // 
            this.lblThink.BackColor = System.Drawing.Color.White;
            this.lblThink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThink.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThink.Location = new System.Drawing.Point(12, 9);
            this.lblThink.Name = "lblThink";
            this.lblThink.Size = new System.Drawing.Size(393, 86);
            this.lblThink.TabIndex = 0;
            this.lblThink.Text = "24123421123";
            this.lblThink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbAnswer
            // 
            this.txbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAnswer.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbAnswer.Location = new System.Drawing.Point(486, 9);
            this.txbAnswer.MaxLength = 6;
            this.txbAnswer.Name = "txbAnswer";
            this.txbAnswer.Size = new System.Drawing.Size(196, 86);
            this.txbAnswer.TabIndex = 2;
            this.txbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAnswer_KeyDown);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(11, 100);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(92, 39);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+\r\nСложение";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prbProgress
            // 
            this.prbProgress.Location = new System.Drawing.Point(12, 101);
            this.prbProgress.Name = "prbProgress";
            this.prbProgress.Size = new System.Drawing.Size(393, 37);
            this.prbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbProgress.TabIndex = 3;
            this.prbProgress.Visible = false;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Enabled = false;
            this.btnAnswer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer.Location = new System.Drawing.Point(485, 100);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(198, 39);
            this.btnAnswer.TabIndex = 1;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(112, 100);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(92, 39);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "–\r\nВычитание\r\n";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMult.Location = new System.Drawing.Point(213, 100);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(92, 39);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "×\r\nУмножение";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDivs
            // 
            this.btnDivs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivs.Location = new System.Drawing.Point(314, 100);
            this.btnDivs.Name = "btnDivs";
            this.btnDivs.Size = new System.Drawing.Size(92, 39);
            this.btnDivs.TabIndex = 1;
            this.btnDivs.Text = ":\r\nДеление";
            this.btnDivs.UseVisualStyleBackColor = true;
            this.btnDivs.Click += new System.EventHandler(this.btnDivs_Click);
            // 
            // txbMax
            // 
            this.txbMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMax.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbMax.Location = new System.Drawing.Point(412, 101);
            this.txbMax.MaxLength = 5;
            this.txbMax.Name = "txbMax";
            this.txbMax.Size = new System.Drawing.Size(67, 37);
            this.txbMax.TabIndex = 4;
            this.txbMax.Text = "1000";
            // 
            // prbAnswerTime
            // 
            this.prbAnswerTime.Location = new System.Drawing.Point(412, 77);
            this.prbAnswerTime.Maximum = 5;
            this.prbAnswerTime.Name = "prbAnswerTime";
            this.prbAnswerTime.Size = new System.Drawing.Size(67, 18);
            this.prbAnswerTime.Step = 1;
            this.prbAnswerTime.TabIndex = 5;
            this.prbAnswerTime.Value = 1;
            this.prbAnswerTime.Visible = false;
            // 
            // tmrAnswer
            // 
            this.tmrAnswer.Interval = 1000;
            this.tmrAnswer.Tick += new System.EventHandler(this.tmrAnswer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 151);
            this.Controls.Add(this.prbAnswerTime);
            this.Controls.Add(this.txbMax);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnDivs);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txbAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThink);
            this.Controls.Add(this.prbProgress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Устный счет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThink;
        private System.Windows.Forms.TextBox txbAnswer;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prbProgress;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDivs;
        private System.Windows.Forms.TextBox txbMax;
        private System.Windows.Forms.ProgressBar prbAnswerTime;
        private System.Windows.Forms.Timer tmrAnswer;
    }
}

