namespace ArcheryWorx
{
    partial class frmArcherSelector
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
            this.listBoxArchers = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxArchers
            // 
            this.listBoxArchers.FormattingEnabled = true;
            this.listBoxArchers.Location = new System.Drawing.Point(12, 12);
            this.listBoxArchers.Name = "listBoxArchers";
            this.listBoxArchers.Size = new System.Drawing.Size(260, 95);
            this.listBoxArchers.TabIndex = 0;
            this.listBoxArchers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxArchers_MouseDoubleClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(197, 116);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "&Continue";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ArcherSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 152);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listBoxArchers);
            this.MaximumSize = new System.Drawing.Size(300, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 190);
            this.Name = "ArcherSelector";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArcherSelector";
            this.Load += new System.EventHandler(this.ArcherSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxArchers;
        private System.Windows.Forms.Button btnSelect;
    }
}