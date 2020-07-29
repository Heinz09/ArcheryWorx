namespace ArcheryWorx
{
    partial class frmNavigator
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
            this.btnSysBowWorx = new System.Windows.Forms.Button();
            this.btnSysArcherArrow = new System.Windows.Forms.Button();
            this.btnSysArcherWorx = new System.Windows.Forms.Button();
            this.btnSysExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSysBowWorx
            // 
            this.btnSysBowWorx.Location = new System.Drawing.Point(12, 12);
            this.btnSysBowWorx.Name = "btnSysBowWorx";
            this.btnSysBowWorx.Size = new System.Drawing.Size(75, 75);
            this.btnSysBowWorx.TabIndex = 0;
            this.btnSysBowWorx.Text = "Bow     Worx";
            this.btnSysBowWorx.UseVisualStyleBackColor = true;
            this.btnSysBowWorx.Click += new System.EventHandler(this.btnSysBowWorx_Click);
            // 
            // btnSysArcherArrow
            // 
            this.btnSysArcherArrow.Location = new System.Drawing.Point(93, 12);
            this.btnSysArcherArrow.Name = "btnSysArcherArrow";
            this.btnSysArcherArrow.Size = new System.Drawing.Size(75, 75);
            this.btnSysArcherArrow.TabIndex = 1;
            this.btnSysArcherArrow.Text = "Arrow   Worx";
            this.btnSysArcherArrow.UseVisualStyleBackColor = true;
            this.btnSysArcherArrow.Click += new System.EventHandler(this.btnSysArcherArrow_Click);
            // 
            // btnSysArcherWorx
            // 
            this.btnSysArcherWorx.Location = new System.Drawing.Point(174, 12);
            this.btnSysArcherWorx.Name = "btnSysArcherWorx";
            this.btnSysArcherWorx.Size = new System.Drawing.Size(75, 75);
            this.btnSysArcherWorx.TabIndex = 2;
            this.btnSysArcherWorx.Text = "Archer  Worx";
            this.btnSysArcherWorx.UseVisualStyleBackColor = true;
            this.btnSysArcherWorx.Click += new System.EventHandler(this.btnSysArcherWorx_Click);
            // 
            // btnSysExit
            // 
            this.btnSysExit.Location = new System.Drawing.Point(336, 12);
            this.btnSysExit.Name = "btnSysExit";
            this.btnSysExit.Size = new System.Drawing.Size(75, 75);
            this.btnSysExit.TabIndex = 3;
            this.btnSysExit.Text = "&Exit";
            this.btnSysExit.UseVisualStyleBackColor = true;
            this.btnSysExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Hunting Worx";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 106);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSysExit);
            this.Controls.Add(this.btnSysArcherWorx);
            this.Controls.Add(this.btnSysArcherArrow);
            this.Controls.Add(this.btnSysBowWorx);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 144);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(442, 144);
            this.Name = "frmNavigator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSysBowWorx;
        private System.Windows.Forms.Button btnSysArcherArrow;
        private System.Windows.Forms.Button btnSysArcherWorx;
        private System.Windows.Forms.Button btnSysExit;
        private System.Windows.Forms.Button button1;
    }
}