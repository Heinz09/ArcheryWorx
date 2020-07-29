using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ArcheryWorx
{
    public partial class frmYourSetup : Form
    {
        public frmYourSetup()
        {
            InitializeComponent();
        }

        private void CheckArcher()
        {
            frmArcheryWorx tmpArchery = (frmArcheryWorx)this.MdiParent;
            string MyArcher = tmpArchery.GetArcher();
            string path = Directory.GetCurrentDirectory().ToString() + "\\Archers\\" + MyArcher + ".xml";

            cArcher tmpArcher = new cArcher();            
            //MessageBox.Show(path);
            if (path != "")
            {
                tmpArcher = tmpArcher.GetArcher(path);
                lblName.Text = tmpArcher.Name;
                lblDrawLength.Text = tmpArcher.DrawLength;
                lblDrawWeight.Text = tmpArcher.DrawWeight;
                lblDoB.Text = tmpArcher.DoB;
                lblGender.Text = tmpArcher.Gender;
                lblHandiness.Text = tmpArcher.Handiness;
            }
        }

        private void YourSetup_Load(object sender, EventArgs e)
        {
            CheckArcher();
        }
    }
}
