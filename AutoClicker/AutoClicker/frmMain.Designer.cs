namespace AutoClicker
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
            this.trbCount = new System.Windows.Forms.TrackBar();
            this.trbTime = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfoClicks = new System.Windows.Forms.Label();
            this.lblInfoTime = new System.Windows.Forms.Label();
            this.lblShowCount = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrClick = new System.Windows.Forms.Timer(this.components);
            this.prbCount = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTime)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trbCount
            // 
            this.trbCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trbCount.LargeChange = 10;
            this.trbCount.Location = new System.Drawing.Point(163, 3);
            this.trbCount.Maximum = 100;
            this.trbCount.Minimum = 1;
            this.trbCount.Name = "trbCount";
            this.trbCount.Size = new System.Drawing.Size(234, 29);
            this.trbCount.TabIndex = 0;
            this.trbCount.TickFrequency = 10;
            this.trbCount.Value = 1;
            this.trbCount.Scroll += new System.EventHandler(this.trbCount_Scroll);
            // 
            // trbTime
            // 
            this.trbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trbTime.LargeChange = 100;
            this.trbTime.Location = new System.Drawing.Point(163, 38);
            this.trbTime.Maximum = 1000;
            this.trbTime.Minimum = 1;
            this.trbTime.Name = "trbTime";
            this.trbTime.Size = new System.Drawing.Size(234, 29);
            this.trbTime.TabIndex = 1;
            this.trbTime.TickFrequency = 100;
            this.trbTime.Value = 1;
            this.trbTime.Scroll += new System.EventHandler(this.trbTime_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.80498F));
            this.tableLayoutPanel1.Controls.Add(this.trbCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trbTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblInfoClicks, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInfoTime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblShowCount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblShowTime, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.prbCount, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 106);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblInfoClicks
            // 
            this.lblInfoClicks.AutoSize = true;
            this.lblInfoClicks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoClicks.Location = new System.Drawing.Point(3, 0);
            this.lblInfoClicks.Name = "lblInfoClicks";
            this.lblInfoClicks.Size = new System.Drawing.Size(154, 35);
            this.lblInfoClicks.TabIndex = 2;
            this.lblInfoClicks.Text = "Количество кликов:";
            this.lblInfoClicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInfoTime
            // 
            this.lblInfoTime.AutoSize = true;
            this.lblInfoTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoTime.Location = new System.Drawing.Point(3, 35);
            this.lblInfoTime.Name = "lblInfoTime";
            this.lblInfoTime.Size = new System.Drawing.Size(154, 35);
            this.lblInfoTime.TabIndex = 2;
            this.lblInfoTime.Text = "Задержка между кликами:";
            this.lblInfoTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShowCount
            // 
            this.lblShowCount.AutoSize = true;
            this.lblShowCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShowCount.Location = new System.Drawing.Point(403, 0);
            this.lblShowCount.Name = "lblShowCount";
            this.lblShowCount.Size = new System.Drawing.Size(76, 35);
            this.lblShowCount.TabIndex = 2;
            this.lblShowCount.Text = "-";
            this.lblShowCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShowTime.Location = new System.Drawing.Point(403, 35);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(76, 35);
            this.lblShowTime.TabIndex = 2;
            this.lblShowTime.Text = "-";
            this.lblShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(3, 73);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 30);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Начать кликать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrClick
            // 
            this.tmrClick.Tick += new System.EventHandler(this.tmrClick_Tick);
            // 
            // prbCount
            // 
            this.prbCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prbCount.Location = new System.Drawing.Point(163, 73);
            this.prbCount.Name = "prbCount";
            this.prbCount.Size = new System.Drawing.Size(234, 30);
            this.prbCount.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 106);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авто кликер";
            ((System.ComponentModel.ISupportInitialize)(this.trbCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTime)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trbCount;
        private System.Windows.Forms.TrackBar trbTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblInfoClicks;
        private System.Windows.Forms.Label lblInfoTime;
        private System.Windows.Forms.Label lblShowCount;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrClick;
        private System.Windows.Forms.ProgressBar prbCount;
    }
}

