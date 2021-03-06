﻿namespace MindCounter
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
            this.txbArithAnswer = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prbProgress = new System.Windows.Forms.ProgressBar();
            this.btnArithAnswer = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDivs = new System.Windows.Forms.Button();
            this.txbMax = new System.Windows.Forms.TextBox();
            this.prbAnswerTime = new System.Windows.Forms.ProgressBar();
            this.tmrAnswer = new System.Windows.Forms.Timer(this.components);
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsMainTypeTrain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMainOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDivsOnTwo = new System.Windows.Forms.Button();
            this.btnDivsOnThree = new System.Windows.Forms.Button();
            this.btnDivsOnFour = new System.Windows.Forms.Button();
            this.btnDivsOnFive = new System.Windows.Forms.Button();
            this.btnDivsYes = new System.Windows.Forms.Button();
            this.btnDivsNo = new System.Windows.Forms.Button();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThink
            // 
            this.lblThink.BackColor = System.Drawing.Color.White;
            this.lblThink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThink.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThink.Location = new System.Drawing.Point(12, 37);
            this.lblThink.Name = "lblThink";
            this.lblThink.Size = new System.Drawing.Size(393, 86);
            this.lblThink.TabIndex = 0;
            this.lblThink.Text = "24123421123";
            this.lblThink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbArithAnswer
            // 
            this.txbArithAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbArithAnswer.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbArithAnswer.Location = new System.Drawing.Point(486, 37);
            this.txbArithAnswer.MaxLength = 6;
            this.txbArithAnswer.Name = "txbArithAnswer";
            this.txbArithAnswer.Size = new System.Drawing.Size(196, 86);
            this.txbArithAnswer.TabIndex = 2;
            this.txbArithAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbArithAnswer_KeyDown);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(11, 128);
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
            this.label1.Location = new System.Drawing.Point(426, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prbProgress
            // 
            this.prbProgress.Location = new System.Drawing.Point(12, 129);
            this.prbProgress.Name = "prbProgress";
            this.prbProgress.Size = new System.Drawing.Size(393, 37);
            this.prbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbProgress.TabIndex = 3;
            this.prbProgress.Visible = false;
            // 
            // btnArithAnswer
            // 
            this.btnArithAnswer.Enabled = false;
            this.btnArithAnswer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnArithAnswer.Location = new System.Drawing.Point(485, 128);
            this.btnArithAnswer.Name = "btnArithAnswer";
            this.btnArithAnswer.Size = new System.Drawing.Size(198, 39);
            this.btnArithAnswer.TabIndex = 1;
            this.btnArithAnswer.Text = "Ответить";
            this.btnArithAnswer.UseVisualStyleBackColor = true;
            this.btnArithAnswer.Click += new System.EventHandler(this.btnArithAnswer_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(112, 128);
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
            this.btnMult.Location = new System.Drawing.Point(213, 128);
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
            this.btnDivs.Location = new System.Drawing.Point(314, 128);
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
            this.txbMax.Location = new System.Drawing.Point(412, 129);
            this.txbMax.MaxLength = 5;
            this.txbMax.Name = "txbMax";
            this.txbMax.Size = new System.Drawing.Size(67, 37);
            this.txbMax.TabIndex = 4;
            this.txbMax.Text = "1000";
            // 
            // prbAnswerTime
            // 
            this.prbAnswerTime.Location = new System.Drawing.Point(412, 105);
            this.prbAnswerTime.Maximum = 5;
            this.prbAnswerTime.Name = "prbAnswerTime";
            this.prbAnswerTime.Size = new System.Drawing.Size(67, 18);
            this.prbAnswerTime.Step = 1;
            this.prbAnswerTime.TabIndex = 5;
            this.prbAnswerTime.Visible = false;
            // 
            // tmrAnswer
            // 
            this.tmrAnswer.Interval = 1000;
            this.tmrAnswer.Tick += new System.EventHandler(this.tmrAnswer_Tick);
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsMainTypeTrain,
            this.mnsMainOptions});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(692, 24);
            this.mnsMain.TabIndex = 7;
            this.mnsMain.Text = "menuStrip2";
            // 
            // mnsMainTypeTrain
            // 
            this.mnsMainTypeTrain.Name = "mnsMainTypeTrain";
            this.mnsMainTypeTrain.Size = new System.Drawing.Size(95, 20);
            this.mnsMainTypeTrain.Text = "Виды заданий";
            // 
            // mnsMainOptions
            // 
            this.mnsMainOptions.Name = "mnsMainOptions";
            this.mnsMainOptions.Size = new System.Drawing.Size(79, 20);
            this.mnsMainOptions.Text = "Настройки";
            this.mnsMainOptions.Click += new System.EventHandler(this.mnsMainOptions_Click);
            // 
            // btnDivsOnTwo
            // 
            this.btnDivsOnTwo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivsOnTwo.Location = new System.Drawing.Point(11, 128);
            this.btnDivsOnTwo.Name = "btnDivsOnTwo";
            this.btnDivsOnTwo.Size = new System.Drawing.Size(92, 39);
            this.btnDivsOnTwo.TabIndex = 1;
            this.btnDivsOnTwo.Text = "x : 2";
            this.btnDivsOnTwo.UseVisualStyleBackColor = true;
            this.btnDivsOnTwo.Click += new System.EventHandler(this.btnDivsOnTwo_Click);
            // 
            // btnDivsOnThree
            // 
            this.btnDivsOnThree.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivsOnThree.Location = new System.Drawing.Point(112, 128);
            this.btnDivsOnThree.Name = "btnDivsOnThree";
            this.btnDivsOnThree.Size = new System.Drawing.Size(92, 39);
            this.btnDivsOnThree.TabIndex = 1;
            this.btnDivsOnThree.Text = "x : 3";
            this.btnDivsOnThree.UseVisualStyleBackColor = true;
            this.btnDivsOnThree.Click += new System.EventHandler(this.btnDivsOnThree_Click);
            // 
            // btnDivsOnFour
            // 
            this.btnDivsOnFour.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivsOnFour.Location = new System.Drawing.Point(213, 128);
            this.btnDivsOnFour.Name = "btnDivsOnFour";
            this.btnDivsOnFour.Size = new System.Drawing.Size(92, 39);
            this.btnDivsOnFour.TabIndex = 1;
            this.btnDivsOnFour.Text = "x : 4";
            this.btnDivsOnFour.UseVisualStyleBackColor = true;
            this.btnDivsOnFour.Click += new System.EventHandler(this.btnDivsOnFour_Click);
            // 
            // btnDivsOnFive
            // 
            this.btnDivsOnFive.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivsOnFive.Location = new System.Drawing.Point(314, 128);
            this.btnDivsOnFive.Name = "btnDivsOnFive";
            this.btnDivsOnFive.Size = new System.Drawing.Size(92, 39);
            this.btnDivsOnFive.TabIndex = 1;
            this.btnDivsOnFive.Text = "x : 5";
            this.btnDivsOnFive.UseVisualStyleBackColor = true;
            this.btnDivsOnFive.Click += new System.EventHandler(this.btnDivsOnFive_Click);
            // 
            // btnDivsYes
            // 
            this.btnDivsYes.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivsYes.Location = new System.Drawing.Point(485, 36);
            this.btnDivsYes.Name = "btnDivsYes";
            this.btnDivsYes.Size = new System.Drawing.Size(92, 88);
            this.btnDivsYes.TabIndex = 1;
            this.btnDivsYes.Text = "Да";
            this.btnDivsYes.UseVisualStyleBackColor = true;
            this.btnDivsYes.Click += new System.EventHandler(this.btnDivsYes_Click);
            // 
            // btnDivsNo
            // 
            this.btnDivsNo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivsNo.Location = new System.Drawing.Point(591, 36);
            this.btnDivsNo.Name = "btnDivsNo";
            this.btnDivsNo.Size = new System.Drawing.Size(92, 88);
            this.btnDivsNo.TabIndex = 1;
            this.btnDivsNo.Text = "Нет";
            this.btnDivsNo.UseVisualStyleBackColor = true;
            this.btnDivsNo.Click += new System.EventHandler(this.btnDivsNo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 177);
            this.Controls.Add(this.prbAnswerTime);
            this.Controls.Add(this.txbMax);
            this.Controls.Add(this.btnDivsNo);
            this.Controls.Add(this.btnDivsYes);
            this.Controls.Add(this.btnArithAnswer);
            this.Controls.Add(this.btnDivsOnFive);
            this.Controls.Add(this.btnDivsOnFour);
            this.Controls.Add(this.btnDivs);
            this.Controls.Add(this.btnDivsOnThree);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDivsOnTwo);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txbArithAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThink);
            this.Controls.Add(this.prbProgress);
            this.Controls.Add(this.mnsMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Устный счет";
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThink;
        private System.Windows.Forms.TextBox txbArithAnswer;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prbProgress;
        private System.Windows.Forms.Button btnArithAnswer;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDivs;
        private System.Windows.Forms.TextBox txbMax;
        private System.Windows.Forms.ProgressBar prbAnswerTime;
        private System.Windows.Forms.Timer tmrAnswer;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnsMainOptions;
        private System.Windows.Forms.ToolStripMenuItem mnsMainTypeTrain;
        private System.Windows.Forms.ToolStripMenuItem mnsTypeArithmetic;
        private System.Windows.Forms.ToolStripMenuItem mnsTypeDivsRule;
        private System.Windows.Forms.Button btnDivsOnTwo;
        private System.Windows.Forms.Button btnDivsOnThree;
        private System.Windows.Forms.Button btnDivsOnFour;
        private System.Windows.Forms.Button btnDivsOnFive;
        private System.Windows.Forms.Button btnDivsYes;
        private System.Windows.Forms.Button btnDivsNo;
    }
}

