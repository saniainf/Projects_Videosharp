namespace MindCounter
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.nmbTimeArithmetic = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nmbTimeDivsRule = new System.Windows.Forms.NumericUpDown();
            this.lblDescTimeArith = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblDescTimeDivsRule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmbCountQuest = new System.Windows.Forms.NumericUpDown();
            this.lblCountQuest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTimeArithmetic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTimeDivsRule)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCountQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // nmbTimeArithmetic
            // 
            this.nmbTimeArithmetic.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmbTimeArithmetic.Location = new System.Drawing.Point(122, 25);
            this.nmbTimeArithmetic.Name = "nmbTimeArithmetic";
            this.nmbTimeArithmetic.Size = new System.Drawing.Size(63, 33);
            this.nmbTimeArithmetic.TabIndex = 2;
            this.nmbTimeArithmetic.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmbTimeArithmetic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbBox_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(12, 200);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(95, 30);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Применить";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(133, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // nmbTimeDivsRule
            // 
            this.nmbTimeDivsRule.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmbTimeDivsRule.Location = new System.Drawing.Point(122, 73);
            this.nmbTimeDivsRule.Name = "nmbTimeDivsRule";
            this.nmbTimeDivsRule.Size = new System.Drawing.Size(63, 33);
            this.nmbTimeDivsRule.TabIndex = 3;
            this.nmbTimeDivsRule.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmbTimeDivsRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbBox_KeyDown);
            // 
            // lblDescTimeArith
            // 
            this.lblDescTimeArith.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescTimeArith.Location = new System.Drawing.Point(6, 22);
            this.lblDescTimeArith.Name = "lblDescTimeArith";
            this.lblDescTimeArith.Size = new System.Drawing.Size(110, 38);
            this.lblDescTimeArith.TabIndex = 2;
            this.lblDescTimeArith.Text = "По арифметике";
            this.lblDescTimeArith.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSec
            // 
            this.lblSec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSec.Location = new System.Drawing.Point(188, 20);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(26, 42);
            this.lblSec.TabIndex = 2;
            this.lblSec.Text = "сек";
            this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescTimeDivsRule
            // 
            this.lblDescTimeDivsRule.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescTimeDivsRule.Location = new System.Drawing.Point(6, 73);
            this.lblDescTimeDivsRule.Name = "lblDescTimeDivsRule";
            this.lblDescTimeDivsRule.Size = new System.Drawing.Size(110, 32);
            this.lblDescTimeDivsRule.TabIndex = 2;
            this.lblDescTimeDivsRule.Text = "По признакам делимости";
            this.lblDescTimeDivsRule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(188, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "сек";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDescTimeArith);
            this.groupBox1.Controls.Add(this.nmbTimeArithmetic);
            this.groupBox1.Controls.Add(this.nmbTimeDivsRule);
            this.groupBox1.Controls.Add(this.lblDescTimeDivsRule);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSec);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Время на ответ";
            // 
            // nmbCountQuest
            // 
            this.nmbCountQuest.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmbCountQuest.Location = new System.Drawing.Point(134, 149);
            this.nmbCountQuest.Name = "nmbCountQuest";
            this.nmbCountQuest.Size = new System.Drawing.Size(63, 33);
            this.nmbCountQuest.TabIndex = 4;
            this.nmbCountQuest.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmbCountQuest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbBox_KeyDown);
            // 
            // lblCountQuest
            // 
            this.lblCountQuest.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountQuest.Location = new System.Drawing.Point(18, 146);
            this.lblCountQuest.Name = "lblCountQuest";
            this.lblCountQuest.Size = new System.Drawing.Size(110, 38);
            this.lblCountQuest.TabIndex = 2;
            this.lblCountQuest.Text = "Количество вопросов";
            this.lblCountQuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(240, 240);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCountQuest);
            this.Controls.Add(this.nmbCountQuest);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.nmbTimeArithmetic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTimeDivsRule)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmbCountQuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmbTimeArithmetic;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nmbTimeDivsRule;
        private System.Windows.Forms.Label lblDescTimeArith;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblDescTimeDivsRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmbCountQuest;
        private System.Windows.Forms.Label lblCountQuest;
    }
}