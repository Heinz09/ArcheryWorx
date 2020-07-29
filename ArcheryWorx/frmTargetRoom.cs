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
    public partial class frmTargetRoom : Form
    {
        public frmTargetRoom()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.
            printPreviewDialog1.Show();
        }
    }
}
