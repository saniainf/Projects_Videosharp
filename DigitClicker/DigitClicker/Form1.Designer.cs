namespace DigitClicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbX = new System.Windows.Forms.TextBox();
            this.txbY = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbX
            // 
            this.txbX.BackColor = System.Drawing.Color.Lavender;
            this.txbX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbX.Location = new System.Drawing.Point(13, 13);
            this.txbX.Multiline = true;
            this.txbX.Name = "txbX";
            this.txbX.ReadOnly = true;
            this.txbX.Size = new System.Drawing.Size(72, 236);
            this.txbX.TabIndex = 0;
            this.txbX.TabStop = false;
            // 
            // txbY
            // 
            this.txbY.BackColor = System.Drawing.Color.Lavender;
            this.txbY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbY.Location = new System.Drawing.Point(91, 13);
            this.txbY.Multiline = true;
            this.txbY.Name = "txbY";
            this.txbY.ReadOnly = true;
            this.txbY.Size = new System.Drawing.Size(72, 236);
            this.txbY.TabIndex = 0;
            this.txbY.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(169, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 36);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(169, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить координаты";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Location = new System.Drawing.Point(169, 97);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(86, 36);
            this.btnRepeat.TabIndex = 2;
            this.btnRepeat.Text = "Повторить";
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 261);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.txbX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автокликер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRepeat;
    }
}

