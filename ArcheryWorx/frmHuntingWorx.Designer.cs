namespace ArcheryWorx
{
    partial class frmHuntingWorx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHuntingWorx));
            this.listBoxUsrSpecies = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLength4 = new System.Windows.Forms.Label();
            this.lblLength3 = new System.Windows.Forms.Label();
            this.lblLength2 = new System.Windows.Forms.Label();
            this.lblLength1 = new System.Windows.Forms.Label();
            this.btnConversion = new System.Windows.Forms.Button();
            this.txtSysDescription = new System.Windows.Forms.TextBox();
            this.txtSysSpecie = new System.Windows.Forms.Label();
            this.txtSysConservationStatus = new System.Windows.Forms.TextBox();
            this.txtSysLengthMax = new System.Windows.Forms.TextBox();
            this.txtSysLengthMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSysHeightMax = new System.Windows.Forms.TextBox();
            this.txtSysHeightMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblWeight4 = new System.Windows.Forms.Label();
            this.lblWeight3 = new System.Windows.Forms.Label();
            this.txtSysFemaleMaxWeight = new System.Windows.Forms.TextBox();
            this.txtSysFemaleMinWeight = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWeight2 = new System.Windows.Forms.Label();
            this.lblWeight1 = new System.Windows.Forms.Label();
            this.txtSysMaleMaxWeight = new System.Windows.Forms.TextBox();
            this.txtSysMaleMinWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxUsrSpecies
            // 
            this.listBoxUsrSpecies.FormattingEnabled = true;
            this.listBoxUsrSpecies.Location = new System.Drawing.Point(12, 20);
            this.listBoxUsrSpecies.Name = "listBoxUsrSpecies";
            this.listBoxUsrSpecies.Size = new System.Drawing.Size(156, 459);
            this.listBoxUsrSpecies.TabIndex = 1;
            this.listBoxUsrSpecies.SelectedIndexChanged += new System.EventHandler(this.listBoxUsrSpecies_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxMain);
            this.groupBox1.Controls.Add(this.lblLength4);
            this.groupBox1.Controls.Add(this.lblLength3);
            this.groupBox1.Controls.Add(this.lblLength2);
            this.groupBox1.Controls.Add(this.lblLength1);
            this.groupBox1.Controls.Add(this.btnConversion);
            this.groupBox1.Controls.Add(this.txtSysDescription);
            this.groupBox1.Controls.Add(this.txtSysSpecie);
            this.groupBox1.Controls.Add(this.txtSysConservationStatus);
            this.groupBox1.Controls.Add(this.txtSysLengthMax);
            this.groupBox1.Controls.Add(this.txtSysLengthMin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSysHeightMax);
            this.groupBox1.Controls.Add(this.txtSysHeightMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(174, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 467);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblLength4
            // 
            this.lblLength4.AutoSize = true;
            this.lblLength4.Location = new System.Drawing.Point(487, 412);
            this.lblLength4.Name = "lblLength4";
            this.lblLength4.Size = new System.Drawing.Size(21, 13);
            this.lblLength4.TabIndex = 23;
            this.lblLength4.Text = "cm";
            // 
            // lblLength3
            // 
            this.lblLength3.AutoSize = true;
            this.lblLength3.Location = new System.Drawing.Point(487, 386);
            this.lblLength3.Name = "lblLength3";
            this.lblLength3.Size = new System.Drawing.Size(21, 13);
            this.lblLength3.TabIndex = 22;
            this.lblLength3.Text = "cm";
            // 
            // lblLength2
            // 
            this.lblLength2.AutoSize = true;
            this.lblLength2.Location = new System.Drawing.Point(408, 412);
            this.lblLength2.Name = "lblLength2";
            this.lblLength2.Size = new System.Drawing.Size(21, 13);
            this.lblLength2.TabIndex = 21;
            this.lblLength2.Text = "cm";
            // 
            // lblLength1
            // 
            this.lblLength1.AutoSize = true;
            this.lblLength1.Location = new System.Drawing.Point(408, 386);
            this.lblLength1.Name = "lblLength1";
            this.lblLength1.Size = new System.Drawing.Size(21, 13);
            this.lblLength1.TabIndex = 20;
            this.lblLength1.Text = "cm";
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(438, 11);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(75, 23);
            this.btnConversion.TabIndex = 15;
            this.btnConversion.Text = "Metric";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // txtSysDescription
            // 
            this.txtSysDescription.Location = new System.Drawing.Point(9, 66);
            this.txtSysDescription.Multiline = true;
            this.txtSysDescription.Name = "txtSysDescription";
            this.txtSysDescription.Size = new System.Drawing.Size(205, 395);
            this.txtSysDescription.TabIndex = 14;
            // 
            // txtSysSpecie
            // 
            this.txtSysSpecie.AutoSize = true;
            this.txtSysSpecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSysSpecie.Location = new System.Drawing.Point(128, 16);
            this.txtSysSpecie.Name = "txtSysSpecie";
            this.txtSysSpecie.Size = new System.Drawing.Size(0, 20);
            this.txtSysSpecie.TabIndex = 12;
            // 
            // txtSysConservationStatus
            // 
            this.txtSysConservationStatus.Location = new System.Drawing.Point(114, 40);
            this.txtSysConservationStatus.Name = "txtSysConservationStatus";
            this.txtSysConservationStatus.Size = new System.Drawing.Size(100, 20);
            this.txtSysConservationStatus.TabIndex = 11;
            // 
            // txtSysLengthMax
            // 
            this.txtSysLengthMax.Location = new System.Drawing.Point(446, 409);
            this.txtSysLengthMax.Name = "txtSysLengthMax";
            this.txtSysLengthMax.Size = new System.Drawing.Size(41, 20);
            this.txtSysLengthMax.TabIndex = 10;
            this.txtSysLengthMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSysLengthMin
            // 
            this.txtSysLengthMin.Location = new System.Drawing.Point(368, 409);
            this.txtSysLengthMin.Name = "txtSysLengthMin";
            this.txtSysLengthMin.Size = new System.Drawing.Size(41, 20);
            this.txtSysLengthMin.TabIndex = 9;
            this.txtSysLengthMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Length Range";
            // 
            // txtSysHeightMax
            // 
            this.txtSysHeightMax.Location = new System.Drawing.Point(446, 383);
            this.txtSysHeightMax.Name = "txtSysHeightMax";
            this.txtSysHeightMax.Size = new System.Drawing.Size(41, 20);
            this.txtSysHeightMax.TabIndex = 7;
            this.txtSysHeightMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSysHeightMin
            // 
            this.txtSysHeightMin.Location = new System.Drawing.Point(368, 383);
            this.txtSysHeightMin.Name = "txtSysHeightMin";
            this.txtSysHeightMin.Size = new System.Drawing.Size(41, 20);
            this.txtSysHeightMin.TabIndex = 6;
            this.txtSysHeightMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Height Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Min Weight";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblWeight4);
            this.groupBox3.Controls.Add(this.lblWeight3);
            this.groupBox3.Controls.Add(this.txtSysFemaleMaxWeight);
            this.groupBox3.Controls.Add(this.txtSysFemaleMinWeight);
            this.groupBox3.Location = new System.Drawing.Point(440, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(73, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Female";
            // 
            // lblWeight4
            // 
            this.lblWeight4.AutoSize = true;
            this.lblWeight4.Location = new System.Drawing.Point(47, 48);
            this.lblWeight4.Name = "lblWeight4";
            this.lblWeight4.Size = new System.Drawing.Size(19, 13);
            this.lblWeight4.TabIndex = 19;
            this.lblWeight4.Text = "kg";
            // 
            // lblWeight3
            // 
            this.lblWeight3.AutoSize = true;
            this.lblWeight3.Location = new System.Drawing.Point(47, 22);
            this.lblWeight3.Name = "lblWeight3";
            this.lblWeight3.Size = new System.Drawing.Size(19, 13);
            this.lblWeight3.TabIndex = 18;
            this.lblWeight3.Text = "kg";
            // 
            // txtSysFemaleMaxWeight
            // 
            this.txtSysFemaleMaxWeight.Location = new System.Drawing.Point(6, 45);
            this.txtSysFemaleMaxWeight.Name = "txtSysFemaleMaxWeight";
            this.txtSysFemaleMaxWeight.Size = new System.Drawing.Size(41, 20);
            this.txtSysFemaleMaxWeight.TabIndex = 1;
            this.txtSysFemaleMaxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSysFemaleMinWeight
            // 
            this.txtSysFemaleMinWeight.Location = new System.Drawing.Point(6, 19);
            this.txtSysFemaleMinWeight.Name = "txtSysFemaleMinWeight";
            this.txtSysFemaleMinWeight.Size = new System.Drawing.Size(41, 20);
            this.txtSysFemaleMinWeight.TabIndex = 0;
            this.txtSysFemaleMinWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWeight2);
            this.groupBox2.Controls.Add(this.lblWeight1);
            this.groupBox2.Controls.Add(this.txtSysMaleMaxWeight);
            this.groupBox2.Controls.Add(this.txtSysMaleMinWeight);
            this.groupBox2.Location = new System.Drawing.Point(362, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(72, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Male";
            // 
            // lblWeight2
            // 
            this.lblWeight2.AutoSize = true;
            this.lblWeight2.Location = new System.Drawing.Point(46, 48);
            this.lblWeight2.Name = "lblWeight2";
            this.lblWeight2.Size = new System.Drawing.Size(19, 13);
            this.lblWeight2.TabIndex = 17;
            this.lblWeight2.Text = "kg";
            // 
            // lblWeight1
            // 
            this.lblWeight1.AutoSize = true;
            this.lblWeight1.Location = new System.Drawing.Point(46, 22);
            this.lblWeight1.Name = "lblWeight1";
            this.lblWeight1.Size = new System.Drawing.Size(19, 13);
            this.lblWeight1.TabIndex = 16;
            this.lblWeight1.Text = "kg";
            // 
            // txtSysMaleMaxWeight
            // 
            this.txtSysMaleMaxWeight.Location = new System.Drawing.Point(6, 45);
            this.txtSysMaleMaxWeight.Name = "txtSysMaleMaxWeight";
            this.txtSysMaleMaxWeight.Size = new System.Drawing.Size(41, 20);
            this.txtSysMaleMaxWeight.TabIndex = 1;
            this.txtSysMaleMaxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSysMaleMinWeight
            // 
            this.txtSysMaleMinWeight.Location = new System.Drawing.Point(6, 19);
            this.txtSysMaleMinWeight.Name = "txtSysMaleMinWeight";
            this.txtSysMaleMinWeight.Size = new System.Drawing.Size(41, 20);
            this.txtSysMaleMinWeight.TabIndex = 0;
            this.txtSysMaleMinWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conservation Status";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMain.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.ErrorImage")));
            this.pictureBoxMain.Image = global::ArcheryWorx.Properties.Resources.nowbow2;
            this.pictureBoxMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.InitialImage")));
            this.pictureBoxMain.Location = new System.Drawing.Point(220, 40);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(286, 256);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 25;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Click += new System.EventHandler(this.pictureBoxMain_Click);
            // 
            // HuntingWorx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxUsrSpecies);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(721, 533);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(721, 533);
            this.Name = "HuntingWorx";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HuntingWorx";
            this.Load += new System.EventHandler(this.HuntingWorx_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsrSpecies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSysFemaleMaxWeight;
        private System.Windows.Forms.TextBox txtSysFemaleMinWeight;
        private System.Windows.Forms.TextBox txtSysMaleMaxWeight;
        private System.Windows.Forms.TextBox txtSysMaleMinWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSysHeightMax;
        private System.Windows.Forms.TextBox txtSysHeightMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSysLengthMax;
        private System.Windows.Forms.TextBox txtSysLengthMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSysConservationStatus;
        private System.Windows.Forms.Label txtSysSpecie;
        private System.Windows.Forms.TextBox txtSysDescription;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.Label lblLength4;
        private System.Windows.Forms.Label lblLength3;
        private System.Windows.Forms.Label lblLength2;
        private System.Windows.Forms.Label lblLength1;
        private System.Windows.Forms.Label lblWeight4;
        private System.Windows.Forms.Label lblWeight3;
        private System.Windows.Forms.Label lblWeight2;
        private System.Windows.Forms.Label lblWeight1;
        private System.Windows.Forms.PictureBox pictureBoxMain;
    }
}