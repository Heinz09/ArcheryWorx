namespace ArcheryWorx
{
    partial class frmPaperTuningAssistant
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.PictureBoxCenter = new System.Windows.Forms.PictureBox();
            this.PictureBoxRight = new System.Windows.Forms.PictureBox();
            this.PictureBoxTop = new System.Windows.Forms.PictureBox();
            this.PictureBoxBottom = new System.Windows.Forms.PictureBox();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.txtSysDescription = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PictureBoxLeft);
            this.groupBox1.Controls.Add(this.PictureBoxCenter);
            this.groupBox1.Controls.Add(this.PictureBoxRight);
            this.groupBox1.Controls.Add(this.PictureBoxTop);
            this.groupBox1.Controls.Add(this.PictureBoxBottom);
            this.groupBox1.Controls.Add(this.MainPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 243);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Possible Tears";
            // 
            // PictureBoxLeft
            // 
            this.PictureBoxLeft.AccessibleDescription = "";
            this.PictureBoxLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxLeft.Image = global::ArcheryWorx.Properties.Resources.Left_Tear;
            this.PictureBoxLeft.Location = new System.Drawing.Point(7, 93);
            this.PictureBoxLeft.Name = "PictureBoxLeft";
            this.PictureBoxLeft.Size = new System.Drawing.Size(65, 65);
            this.PictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxLeft.TabIndex = 9;
            this.PictureBoxLeft.TabStop = false;
            this.PictureBoxLeft.Tag = "Left";
            this.PictureBoxLeft.Click += new System.EventHandler(this.PictureBoxLeft_Click);
            // 
            // PictureBoxCenter
            // 
            this.PictureBoxCenter.AccessibleDescription = "";
            this.PictureBoxCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxCenter.Image = global::ArcheryWorx.Properties.Resources.perfect_tear;
            this.PictureBoxCenter.Location = new System.Drawing.Point(81, 93);
            this.PictureBoxCenter.Name = "PictureBoxCenter";
            this.PictureBoxCenter.Size = new System.Drawing.Size(65, 65);
            this.PictureBoxCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxCenter.TabIndex = 8;
            this.PictureBoxCenter.TabStop = false;
            this.PictureBoxCenter.Tag = "Center";
            this.PictureBoxCenter.Click += new System.EventHandler(this.PictureBoxCenter_Click);
            // 
            // PictureBoxRight
            // 
            this.PictureBoxRight.AccessibleDescription = "";
            this.PictureBoxRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxRight.Image = global::ArcheryWorx.Properties.Resources.Right_Tear;
            this.PictureBoxRight.Location = new System.Drawing.Point(155, 93);
            this.PictureBoxRight.Name = "PictureBoxRight";
            this.PictureBoxRight.Size = new System.Drawing.Size(65, 65);
            this.PictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxRight.TabIndex = 7;
            this.PictureBoxRight.TabStop = false;
            this.PictureBoxRight.Tag = "Right";
            this.PictureBoxRight.Click += new System.EventHandler(this.PictureBoxRight_Click);
            // 
            // PictureBoxTop
            // 
            this.PictureBoxTop.AccessibleDescription = "";
            this.PictureBoxTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxTop.Image = global::ArcheryWorx.Properties.Resources.High_Tear;
            this.PictureBoxTop.Location = new System.Drawing.Point(81, 19);
            this.PictureBoxTop.Name = "PictureBoxTop";
            this.PictureBoxTop.Size = new System.Drawing.Size(65, 65);
            this.PictureBoxTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxTop.TabIndex = 6;
            this.PictureBoxTop.TabStop = false;
            this.PictureBoxTop.Tag = "Top";
            this.PictureBoxTop.Click += new System.EventHandler(this.PictureBoxTop_Click);
            // 
            // PictureBoxBottom
            // 
            this.PictureBoxBottom.AccessibleDescription = "";
            this.PictureBoxBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxBottom.Image = global::ArcheryWorx.Properties.Resources.Low_Tear;
            this.PictureBoxBottom.Location = new System.Drawing.Point(81, 167);
            this.PictureBoxBottom.Name = "PictureBoxBottom";
            this.PictureBoxBottom.Size = new System.Drawing.Size(65, 65);
            this.PictureBoxBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxBottom.TabIndex = 5;
            this.PictureBoxBottom.TabStop = false;
            this.PictureBoxBottom.Tag = "Bottom";
            this.PictureBoxBottom.Click += new System.EventHandler(this.PictureBoxBottom_Click);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPictureBox.Enabled = false;
            this.MainPictureBox.Location = new System.Drawing.Point(7, 19);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(216, 216);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 10;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.Tag = "Main";
            this.MainPictureBox.Click += new System.EventHandler(this.MainPictureBox_Click);
            // 
            // txtSysDescription
            // 
            this.txtSysDescription.Enabled = false;
            this.txtSysDescription.Location = new System.Drawing.Point(248, 12);
            this.txtSysDescription.Multiline = true;
            this.txtSysDescription.Name = "txtSysDescription";
            this.txtSysDescription.Size = new System.Drawing.Size(304, 214);
            this.txtSysDescription.TabIndex = 6;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(477, 232);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // PaperTuningAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 266);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtSysDescription);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaperTuningAssistant";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paper Tuning Assistant";
            this.Load += new System.EventHandler(this.PaperTuningAssistant_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PictureBoxLeft;
        private System.Windows.Forms.PictureBox PictureBoxCenter;
        private System.Windows.Forms.PictureBox PictureBoxRight;
        private System.Windows.Forms.PictureBox PictureBoxTop;
        private System.Windows.Forms.PictureBox PictureBoxBottom;
        private System.Windows.Forms.TextBox txtSysDescription;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox MainPictureBox;

    }
}