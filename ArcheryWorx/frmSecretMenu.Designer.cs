namespace ArcheryWorx
{
    partial class frmSecretMenu
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAuth = new System.Windows.Forms.TextBox();
            this.groupBoxSecret = new System.Windows.Forms.GroupBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblImagesLoc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblArrowLoc = new System.Windows.Forms.Label();
            this.lblArcherLoc = new System.Windows.Forms.Label();
            this.lblDbLocation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSecret.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(250, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAuth
            // 
            this.txtAuth.Location = new System.Drawing.Point(12, 230);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.PasswordChar = '*';
            this.txtAuth.Size = new System.Drawing.Size(100, 20);
            this.txtAuth.TabIndex = 1;
            this.txtAuth.TextChanged += new System.EventHandler(this.txtAuth_TextChanged);
            // 
            // groupBoxSecret
            // 
            this.groupBoxSecret.Controls.Add(this.lblURL);
            this.groupBoxSecret.Controls.Add(this.label5);
            this.groupBoxSecret.Controls.Add(this.lblImagesLoc);
            this.groupBoxSecret.Controls.Add(this.label4);
            this.groupBoxSecret.Controls.Add(this.lblArrowLoc);
            this.groupBoxSecret.Controls.Add(this.lblArcherLoc);
            this.groupBoxSecret.Controls.Add(this.lblDbLocation);
            this.groupBoxSecret.Controls.Add(this.label3);
            this.groupBoxSecret.Controls.Add(this.label2);
            this.groupBoxSecret.Controls.Add(this.label1);
            this.groupBoxSecret.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSecret.Name = "groupBoxSecret";
            this.groupBoxSecret.Size = new System.Drawing.Size(572, 209);
            this.groupBoxSecret.TabIndex = 2;
            this.groupBoxSecret.TabStop = false;
            this.groupBoxSecret.Text = "Secretcy Act";
            this.groupBoxSecret.Visible = false;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblURL.Location = new System.Drawing.Point(6, 179);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(237, 13);
            this.lblURL.TabIndex = 11;
            this.lblURL.Text = "http://www.fleetassistant.co.za/awx/Downloads";
            this.lblURL.Click += new System.EventHandler(this.lblURL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Downloads";
            // 
            // lblImagesLoc
            // 
            this.lblImagesLoc.AutoSize = true;
            this.lblImagesLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImagesLoc.Location = new System.Drawing.Point(6, 143);
            this.lblImagesLoc.Name = "lblImagesLoc";
            this.lblImagesLoc.Size = new System.Drawing.Size(13, 13);
            this.lblImagesLoc.TabIndex = 9;
            this.lblImagesLoc.Text = "q";
            this.lblImagesLoc.Click += new System.EventHandler(this.lblImagesLoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Images Location";
            // 
            // lblArrowLoc
            // 
            this.lblArrowLoc.AutoSize = true;
            this.lblArrowLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblArrowLoc.Location = new System.Drawing.Point(9, 108);
            this.lblArrowLoc.Name = "lblArrowLoc";
            this.lblArrowLoc.Size = new System.Drawing.Size(12, 13);
            this.lblArrowLoc.TabIndex = 7;
            this.lblArrowLoc.Text = "z";
            this.lblArrowLoc.Click += new System.EventHandler(this.lblArrowLoc_Click);
            // 
            // lblArcherLoc
            // 
            this.lblArcherLoc.AutoSize = true;
            this.lblArcherLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblArcherLoc.Location = new System.Drawing.Point(9, 74);
            this.lblArcherLoc.Name = "lblArcherLoc";
            this.lblArcherLoc.Size = new System.Drawing.Size(12, 13);
            this.lblArcherLoc.TabIndex = 6;
            this.lblArcherLoc.Text = "y";
            this.lblArcherLoc.Click += new System.EventHandler(this.lblArcherLoc_Click);
            // 
            // lblDbLocation
            // 
            this.lblDbLocation.AutoSize = true;
            this.lblDbLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDbLocation.Location = new System.Drawing.Point(9, 39);
            this.lblDbLocation.Name = "lblDbLocation";
            this.lblDbLocation.Size = new System.Drawing.Size(12, 13);
            this.lblDbLocation.TabIndex = 5;
            this.lblDbLocation.Text = "x";
            this.lblDbLocation.Click += new System.EventHandler(this.lblDbLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arrow Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Archer Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database Location";
            // 
            // frmSecretMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 262);
            this.Controls.Add(this.groupBoxSecret);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAuth);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSecretMenu";
            this.ShowIcon = false;
            this.Text = "The Super Secret Hidden Admin Menu";
            this.Load += new System.EventHandler(this.frmSecretMenu_Load);
            this.groupBoxSecret.ResumeLayout(false);
            this.groupBoxSecret.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAuth;
        private System.Windows.Forms.GroupBox groupBoxSecret;
        private System.Windows.Forms.Label lblArrowLoc;
        private System.Windows.Forms.Label lblArcherLoc;
        private System.Windows.Forms.Label lblDbLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImagesLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label label5;
    }
}