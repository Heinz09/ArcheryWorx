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
    public partial class frmSecretMenu : Form
    {
        public frmSecretMenu()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtAuth.Text == "Archer69")
            {
                txtAuth.Text = "";
                txtAuth.Visible = false;
                groupBoxSecret.Visible = true;
            }
            else this.Close();
        }

        private void frmSecretMenu_Load(object sender, EventArgs e)
        {
            lblArcherLoc.Text = Directory.GetCurrentDirectory()+"\\Archers\\";
            lblArrowLoc.Text = Directory.GetCurrentDirectory() + "\\Arrows\\";
            lblDbLocation.Text = Directory.GetCurrentDirectory() + "\\Data\\";
            lblImagesLoc.Text = Directory.GetCurrentDirectory() + "\\Img\\"; ;
        }

        private void lblDbLocation_Click(object sender, EventArgs e)
        {
            string tmp = lblDbLocation.Text;
            System.Diagnostics.Process.Start(@tmp);
        }

        private void lblArcherLoc_Click(object sender, EventArgs e)
        {
            string tmp = lblArcherLoc.Text;
            System.Diagnostics.Process.Start(@tmp);
        }

        private void lblArrowLoc_Click(object sender, EventArgs e)
        {
            string tmp = lblArrowLoc.Text;
            System.Diagnostics.Process.Start(@tmp);
        }

        private void lblImagesLoc_Click(object sender, EventArgs e)
        {
            string tmp = lblImagesLoc.Text;
            System.Diagnostics.Process.Start(@tmp);
        }

        private void lblURL_Click(object sender, EventArgs e)
        {
            string tmp = lblURL.Text;
            System.Diagnostics.Process.Start(@tmp);
        }

        private void txtAuth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
