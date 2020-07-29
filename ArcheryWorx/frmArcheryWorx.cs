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
    public partial class frmArcheryWorx : Form
    {
        private static string ArcherName = "N/A";

        public string Archer_Name
        {
            get { return ArcherName; }
            set { ArcherName = value; }
        }
                
        public frmArcheryWorx()
        {
            InitializeComponent();            
        }

        public void SetArcher(string InArcherName)
        {
            ArcherName = InArcherName;
            cArcherTools tmpTools = new cArcherTools();                        
            frmArcheryWorx.ActiveForm.Text = "Archery Worx [ "+ArcherName+" ]";
        }

        public string GetArcher()
        {
            if (ArcherName == "N/A")
            {            
                frmArcherSelector tmpArcherySelector = new frmArcherSelector();
                tmpArcherySelector.MdiParent = this;
                tmpArcherySelector.Show();
                return "NO ARCHER SELECTED";
            }
            else return ArcherName;
        }

        private void ArcheryWorx_Load(object sender, EventArgs e)
        {            
            frmNavigator nWindow = new frmNavigator();
            nWindow.MdiParent = this;
            nWindow.Show();
            GetArcher();
        }

        private void bowWorxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBowWorx bwWindow = new frmBowWorx();
            bwWindow.MdiParent = this;
            bwWindow.Show();
        }

        private void arrowWorxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArrowWorx awWindow = new frmArrowWorx();
            awWindow.MdiParent = this;
            awWindow.Show();
        }

        private void qBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQbrowse tmpQbrowser = new frmQbrowse();
            tmpQbrowser.MdiParent = this;
            tmpQbrowser.Show();
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArcherWorx tmpArcherWorx = new frmArcherWorx();
            tmpArcherWorx.MdiParent = this;
            tmpArcherWorx.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void manaulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\manual\\awxmanual.pdf");
        }

        private void navigatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNavigator nWindow = new frmNavigator();
            nWindow.MdiParent = this;
            nWindow.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAboutBox abWindow = new frmAboutBox();
            abWindow.MdiParent = this;
            abWindow.Show();
        }

        private void yourSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ArcherName);
            frmYourSetup tmpYourSetup = new frmYourSetup();
            tmpYourSetup.MdiParent = this;
            tmpYourSetup.Show();
        }

        private void selectorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmArcherSelector tmpArcherSelector = new frmArcherSelector();
            tmpArcherSelector.MdiParent = this;
            tmpArcherSelector.Show();
        }

        private void creatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmArcherWorx awWindow = new frmArcherWorx();
            awWindow.MdiParent = this;
            awWindow.Show();
        }

        private void paperTuningAssistantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaperTuningAssistant tmpPTA = new frmPaperTuningAssistant();
            tmpPTA.MdiParent = this;
            tmpPTA.Show();
        }

        private void bowSearchAssistantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBowSearch tmpBowSearch = new frmBowSearch();
            tmpBowSearch.MdiParent = this;
            tmpBowSearch.Show();
        }

        private void qBrowserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQbrowse tmpQbrowse = new frmQbrowse();
            tmpQbrowse.MdiParent = this;
            tmpQbrowse.Show();
        }

        private void shopSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShopSearch tmpShopSearch = new frmShopSearch();
            tmpShopSearch.MdiParent = this;
            tmpShopSearch.Show();
        }

        private void broadheadSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBroadheadSearch tmpBroadheadSearch = new frmBroadheadSearch();
            tmpBroadheadSearch.MdiParent = this;
            tmpBroadheadSearch.Show();
        }

        private void dataFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            //            
        }

        private void eventHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArcherHistory tmpHistory = new frmArcherHistory();
            tmpHistory.MdiParent = this;
            tmpHistory.Show();
        }

        private void targetRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTargetRoom tmpTarget = new frmTargetRoom();
            tmpTarget.MdiParent = this;
            tmpTarget.Show();
        }

        private void testFuncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataTable tmpTarget = new frmDataTable();
            tmpTarget.MdiParent = this;
            tmpTarget.Show();
        }
    }
}