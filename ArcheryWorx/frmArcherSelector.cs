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
    public partial class frmArcherSelector : Form
    {
        string RetArcher = "";
        
        public string GetArcher()
        {
            this.Show();
            return RetArcher;
        }
        

        public frmArcherSelector()
        {
            InitializeComponent();
        }

        private void ArcherSelector_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            bool NoArcher = true;
            string path = "./Archers/";

            try
            {                
                string[] files = Directory.GetFiles(path, "*.xml");
                
                foreach (string file in files)
                {
                    string xfile = file.Substring(path.Length);
                    xfile = xfile.Substring(0, xfile.Length - 4);
                    listBoxArchers.Items.Add(xfile);
                    NoArcher = false;
                }
            }
            catch
            {
                Directory.CreateDirectory(path);
            }
                                 
            if (NoArcher)
            {                
                frmArcherWorx tmpWin = new frmArcherWorx();
                tmpWin.MdiParent = (frmArcheryWorx)this.MdiParent;
                tmpWin.Show();                
            }
        }

        private string Selected(ListBox tmpListbox)
        {
            if (tmpListbox.Text != "")
                return tmpListbox.Text;
            else return "Default";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Continue();
        }

        private void Continue()
        {
            frmArcheryWorx tmpAW = (frmArcheryWorx)this.MdiParent;
            tmpAW.SetArcher(Selected(listBoxArchers));
            this.Close();        
        }

        private void listBoxArchers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Continue();
        }
    }
}
