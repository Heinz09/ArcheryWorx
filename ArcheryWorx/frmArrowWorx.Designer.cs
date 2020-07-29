namespace ArcheryWorx
{
    partial class frmArrowWorx
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
            this.txtUsrShaftLength = new System.Windows.Forms.TextBox();
            this.txtUsrGpI = new System.Windows.Forms.TextBox();
            this.comboBoxUsrTipWeight = new System.Windows.Forms.ComboBox();
            this.comboBoxUsrNock = new System.Windows.Forms.ComboBox();
            this.comboBoxUsrFletches = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxUsrShafts = new System.Windows.Forms.ComboBox();
            this.comboBoxUsrInsert = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxUsrNockAdapter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblSysFOC = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSysTotalWeight = new System.Windows.Forms.Label();
            this.lblSysTipWeight = new System.Windows.Forms.Label();
            this.lblSysShaftWeight = new System.Windows.Forms.Label();
            this.lblSysRearWeight = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsrShaftLength
            // 
            this.txtUsrShaftLength.Location = new System.Drawing.Point(112, 86);
            this.txtUsrShaftLength.Name = "txtUsrShaftLength";
            this.txtUsrShaftLength.Size = new System.Drawing.Size(151, 20);
            this.txtUsrShaftLength.TabIndex = 2;
            this.txtUsrShaftLength.Text = "30";
            this.txtUsrShaftLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsrGpI
            // 
            this.txtUsrGpI.Location = new System.Drawing.Point(112, 113);
            this.txtUsrGpI.Name = "txtUsrGpI";
            this.txtUsrGpI.Size = new System.Drawing.Size(151, 20);
            this.txtUsrGpI.TabIndex = 3;
            this.txtUsrGpI.Text = "10";
            this.txtUsrGpI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxUsrTipWeight
            // 
            this.comboBoxUsrTipWeight.FormattingEnabled = true;
            this.comboBoxUsrTipWeight.Items.AddRange(new object[] {
            "75",
            "85",
            "95",
            "100",
            "125",
            "150",
            "175",
            "200"});
            this.comboBoxUsrTipWeight.Location = new System.Drawing.Point(112, 140);
            this.comboBoxUsrTipWeight.Name = "comboBoxUsrTipWeight";
            this.comboBoxUsrTipWeight.Size = new System.Drawing.Size(151, 21);
            this.comboBoxUsrTipWeight.TabIndex = 4;
            this.comboBoxUsrTipWeight.Text = "100";
            // 
            // comboBoxUsrNock
            // 
            this.comboBoxUsrNock.FormattingEnabled = true;
            this.comboBoxUsrNock.Location = new System.Drawing.Point(112, 168);
            this.comboBoxUsrNock.Name = "comboBoxUsrNock";
            this.comboBoxUsrNock.Size = new System.Drawing.Size(151, 21);
            this.comboBoxUsrNock.TabIndex = 5;
            this.comboBoxUsrNock.Text = "No Nock Selected";
            // 
            // comboBoxUsrFletches
            // 
            this.comboBoxUsrFletches.FormattingEnabled = true;
            this.comboBoxUsrFletches.Location = new System.Drawing.Point(112, 225);
            this.comboBoxUsrFletches.Name = "comboBoxUsrFletches";
            this.comboBoxUsrFletches.Size = new System.Drawing.Size(151, 21);
            this.comboBoxUsrFletches.TabIndex = 7;
            this.comboBoxUsrFletches.Text = "No Fletches Selected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shaft Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grains / Inch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tip Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fletches:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Arrow Shaft";
            // 
            // comboBoxUsrShafts
            // 
            this.comboBoxUsrShafts.FormattingEnabled = true;
            this.comboBoxUsrShafts.Location = new System.Drawing.Point(9, 32);
            this.comboBoxUsrShafts.Name = "comboBoxUsrShafts";
            this.comboBoxUsrShafts.Size = new System.Drawing.Size(254, 21);
            this.comboBoxUsrShafts.TabIndex = 0;
            this.comboBoxUsrShafts.Text = "No Arrow Shaft Selected";
            this.comboBoxUsrShafts.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsrShafts_SelectedIndexChanged);
            // 
            // comboBoxUsrInsert
            // 
            this.comboBoxUsrInsert.FormattingEnabled = true;
            this.comboBoxUsrInsert.Location = new System.Drawing.Point(112, 59);
            this.comboBoxUsrInsert.Name = "comboBoxUsrInsert";
            this.comboBoxUsrInsert.Size = new System.Drawing.Size(151, 21);
            this.comboBoxUsrInsert.TabIndex = 1;
            this.comboBoxUsrInsert.Text = "No Insert Selected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Inserts:";
            // 
            // comboBoxUsrNockAdapter
            // 
            this.comboBoxUsrNockAdapter.FormattingEnabled = true;
            this.comboBoxUsrNockAdapter.Location = new System.Drawing.Point(112, 195);
            this.comboBoxUsrNockAdapter.Name = "comboBoxUsrNockAdapter";
            this.comboBoxUsrNockAdapter.Size = new System.Drawing.Size(151, 21);
            this.comboBoxUsrNockAdapter.TabIndex = 6;
            this.comboBoxUsrNockAdapter.Text = "No Nock Adapter Selected";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nock Adapter:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 273);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUsrShaftLength);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtUsrGpI);
            this.groupBox1.Controls.Add(this.comboBoxUsrNockAdapter);
            this.groupBox1.Controls.Add(this.comboBoxUsrTipWeight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxUsrNock);
            this.groupBox1.Controls.Add(this.comboBoxUsrInsert);
            this.groupBox1.Controls.Add(this.comboBoxUsrFletches);
            this.groupBox1.Controls.Add(this.comboBoxUsrShafts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 255);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arrow Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblNote);
            this.groupBox2.Controls.Add(this.lblSysFOC);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblSysTotalWeight);
            this.groupBox2.Controls.Add(this.lblSysTipWeight);
            this.groupBox2.Controls.Add(this.lblSysShaftWeight);
            this.groupBox2.Controls.Add(this.lblSysRearWeight);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(293, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 255);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculations";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Best Suited for:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(33, 195);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(10, 13);
            this.lblNote.TabIndex = 10;
            this.lblNote.Text = "-";
            // 
            // lblSysFOC
            // 
            this.lblSysFOC.AutoSize = true;
            this.lblSysFOC.Location = new System.Drawing.Point(33, 153);
            this.lblSysFOC.Name = "lblSysFOC";
            this.lblSysFOC.Size = new System.Drawing.Size(10, 13);
            this.lblSysFOC.TabIndex = 9;
            this.lblSysFOC.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "FOC";
            // 
            // lblSysTotalWeight
            // 
            this.lblSysTotalWeight.AutoSize = true;
            this.lblSysTotalWeight.Location = new System.Drawing.Point(33, 120);
            this.lblSysTotalWeight.Name = "lblSysTotalWeight";
            this.lblSysTotalWeight.Size = new System.Drawing.Size(10, 13);
            this.lblSysTotalWeight.TabIndex = 7;
            this.lblSysTotalWeight.Text = "-";
            // 
            // lblSysTipWeight
            // 
            this.lblSysTipWeight.AutoSize = true;
            this.lblSysTipWeight.Location = new System.Drawing.Point(33, 89);
            this.lblSysTipWeight.Name = "lblSysTipWeight";
            this.lblSysTipWeight.Size = new System.Drawing.Size(10, 13);
            this.lblSysTipWeight.TabIndex = 6;
            this.lblSysTipWeight.Text = "-";
            // 
            // lblSysShaftWeight
            // 
            this.lblSysShaftWeight.AutoSize = true;
            this.lblSysShaftWeight.Location = new System.Drawing.Point(33, 59);
            this.lblSysShaftWeight.Name = "lblSysShaftWeight";
            this.lblSysShaftWeight.Size = new System.Drawing.Size(10, 13);
            this.lblSysShaftWeight.TabIndex = 5;
            this.lblSysShaftWeight.Text = "-";
            // 
            // lblSysRearWeight
            // 
            this.lblSysRearWeight.AutoSize = true;
            this.lblSysRearWeight.Location = new System.Drawing.Point(33, 29);
            this.lblSysRearWeight.Name = "lblSysRearWeight";
            this.lblSysRearWeight.Size = new System.Drawing.Size(10, 13);
            this.lblSysRearWeight.TabIndex = 4;
            this.lblSysRearWeight.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total Weight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tip Weight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Shaft Weight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Rear Weight";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(93, 273);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 20;
            this.btnSaveAs.Text = "&Save As...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(174, 273);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(409, 273);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmArrowWorx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 307);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalc);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(512, 345);
            this.Name = "frmArrowWorx";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArrowWorx";
            this.Load += new System.EventHandler(this.ArrowWorx_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsrShaftLength;
        private System.Windows.Forms.TextBox txtUsrGpI;
        private System.Windows.Forms.ComboBox comboBoxUsrTipWeight;
        private System.Windows.Forms.ComboBox comboBoxUsrNock;
        private System.Windows.Forms.ComboBox comboBoxUsrFletches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxUsrShafts;
        private System.Windows.Forms.ComboBox comboBoxUsrInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxUsrNockAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSysTotalWeight;
        private System.Windows.Forms.Label lblSysTipWeight;
        private System.Windows.Forms.Label lblSysShaftWeight;
        private System.Windows.Forms.Label lblSysRearWeight;
        private System.Windows.Forms.Label lblSysFOC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;

    }
}