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
    public partial class frmNavigator : Form
    {
        public frmNavigator()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to quit?", "Leave Archery Worx", MessageBoxButtons.YesNo);
            if (dlgResult==DialogResult.Yes) MdiParent.Close();           
        }

        private void btnSysArcherWorx_Click(object sender, EventArgs e)
        {
            frmArcherWorx awWindow = new frmArcherWorx();
            awWindow.MdiParent = this.MdiParent;
            awWindow.Show();
        }

        private void btnSysArcherArrow_Click(object sender, EventArgs e)
        {
            frmArrowWorx awWindow = new frmArrowWorx();
            awWindow.MdiParent = this.MdiParent;
            awWindow.Show();
        }

        private void btnSysBowWorx_Click(object sender, EventArgs e)
        {
            frmBowWorx bwWindow = new frmBowWorx();
            bwWindow.MdiParent = this.MdiParent;
            bwWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHuntingWorx hwWindow = new frmHuntingWorx();
            hwWindow.MdiParent = this.MdiParent;
            hwWindow.Show();
        }
    }
}
