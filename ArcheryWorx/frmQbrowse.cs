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
    public partial class frmQbrowse : Form
    {
        public frmQbrowse()
        {
            InitializeComponent();
        }

        public void GotoURL(string url)
        {
            MessageBox.Show("You are being redirect to an external website not affiliated with ArcheryWorx","Notice");
            webBrowser1.Navigate(url);
        }
    }
}
