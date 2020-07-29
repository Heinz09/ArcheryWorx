using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArcheryWorx
{
    public partial class frmDataTable : Form
    {
        public frmDataTable()
        {
            InitializeComponent();
        }

        private void frmDataTable_Load(object sender, EventArgs e)
        {
            FillFields();
        }

        private bool FillFields()        
        {
            txtFPS1.Text = Convert.ToString(200);
            txtFPS2.Text = Convert.ToString(210);
            txtFPS3.Text = Convert.ToString(220);
            txtFPS4.Text = Convert.ToString(230);
            txtFPS5.Text = Convert.ToString(240);
            txtFPS6.Text = Convert.ToString(250);
            txtFPS7.Text = Convert.ToString(260);
            txtFPS8.Text = Convert.ToString(270);
            txtFPS9.Text = Convert.ToString(280);
            txtFPS10.Text = Convert.ToString(290);

            txtWeight1.Text = Convert.ToString(330);
            txtWeight2.Text = Convert.ToString(340);
            txtWeight3.Text = Convert.ToString(350);
            txtWeight4.Text = Convert.ToString(360);
            txtWeight5.Text = Convert.ToString(370);
            txtWeight6.Text = Convert.ToString(380);
            txtWeight7.Text = Convert.ToString(390);
            txtWeight8.Text = Convert.ToString(400);
            txtWeight9.Text = Convert.ToString(410);
            txtWeight10.Text = Convert.ToString(420);

            return true;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            
        }
    }
}
