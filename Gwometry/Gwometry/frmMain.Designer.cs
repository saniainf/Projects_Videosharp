namespace Gwometry
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
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.btnMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMain
            // 
            this.pcbMain.BackColor = System.Drawing.Color.White;
            this.pcbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbMain.Location = new System.Drawing.Point(0, 0);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(1166, 718);
            this.pcbMain.TabIndex = 0;
            this.pcbMain.TabStop = false;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(1046, 43);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "button1";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 718);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.pcbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "GraphicEntities";
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.Button btnMove;
    }
}

