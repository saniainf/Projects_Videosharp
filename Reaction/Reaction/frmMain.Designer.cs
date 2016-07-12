namespace Reaction
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
            this.pcbOne = new System.Windows.Forms.PictureBox();
            this.pcbTwo = new System.Windows.Forms.PictureBox();
            this.pcbThree = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbThree)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbOne
            // 
            this.pcbOne.BackColor = System.Drawing.Color.Transparent;
            this.pcbOne.Image = global::Reaction.Properties.Resources.image1;
            this.pcbOne.Location = new System.Drawing.Point(12, 12);
            this.pcbOne.Name = "pcbOne";
            this.pcbOne.Size = new System.Drawing.Size(128, 128);
            this.pcbOne.TabIndex = 0;
            this.pcbOne.TabStop = false;
            this.pcbOne.Click += new System.EventHandler(this.picClick);
            // 
            // pcbTwo
            // 
            this.pcbTwo.BackColor = System.Drawing.Color.Transparent;
            this.pcbTwo.Image = global::Reaction.Properties.Resources.image2;
            this.pcbTwo.Location = new System.Drawing.Point(146, 12);
            this.pcbTwo.Name = "pcbTwo";
            this.pcbTwo.Size = new System.Drawing.Size(128, 128);
            this.pcbTwo.TabIndex = 0;
            this.pcbTwo.TabStop = false;
            this.pcbTwo.Click += new System.EventHandler(this.picClick);
            // 
            // pcbThree
            // 
            this.pcbThree.BackColor = System.Drawing.Color.Transparent;
            this.pcbThree.Image = global::Reaction.Properties.Resources.image3;
            this.pcbThree.Location = new System.Drawing.Point(280, 12);
            this.pcbThree.Name = "pcbThree";
            this.pcbThree.Size = new System.Drawing.Size(128, 128);
            this.pcbThree.TabIndex = 0;
            this.pcbThree.TabStop = false;
            this.pcbThree.Click += new System.EventHandler(this.picClick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(127, 170);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 44);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Запуск";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 700;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(421, 227);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pcbThree);
            this.Controls.Add(this.pcbTwo);
            this.Controls.Add(this.pcbOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Игра на реакцию";
            ((System.ComponentModel.ISupportInitialize)(this.pcbOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbThree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbOne;
        private System.Windows.Forms.PictureBox pcbTwo;
        private System.Windows.Forms.PictureBox pcbThree;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmr;
    }
}

