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
    public partial class frmShopSearch : Form
    {
        public frmShopSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShopSearch_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            cShopTools tmpTools = new cShopTools();

            List<string> tmpShops = tmpTools.GetShops();

            for (int i = 0; i < tmpShops.Count; i++)
                listBoxShops.Items.Add(tmpShops[i]);

        }

        private void listBoxShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill(listBoxShops.Text);
        }

        private void Fill(string ShopName)
        {
            cShopTools tmpTools = new cShopTools();
            
            cShop ShopDetails = tmpTools.GetShopDetails(ShopName);

            groupBoxShop.Text = ShopDetails.ShopName;
            txtDescription.Text = ShopDetails.Description;
            lblURL.Text = ShopDetails.URL;
            txtBrands.Text = ShopDetails.MainBrands;            
            lblIndoorRange.Text = ShopDetails.IndoorRange;
            lblOutdoorRange.Text = ShopDetails.OutdoorRange;
            lblBowTuning.Text = ShopDetails.BowTuning;
            lbl3Drange.Text = ShopDetails.a3DRange;
            lblFletching.Text = ShopDetails.Fletching;
            lblSales.Text = ShopDetails.Sales;
            lblArea.Text = ShopDetails.Area;
            lblGPS.Text = ShopDetails.GPS;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cShopTools tmpShopTools = new cShopTools();
            
            string search = "";

            if (txtArea.Text != "Any")
                search += "Area Like \"%" + txtArea.Text + "%\" ";
            else
                search += "Area Like \"%\"";

            if (checkBox3Drange.Checked) search += " AND i3DRange = \"Y\"";

            if (checkBoxIndoorRange.Checked) search += " AND IndoorRange = \"Y\"";

            if (checkBoxOutdoorRange.Checked) search += " AND OutdoorRange = \"Y\"";

            if (checkBoxBowService.Checked) search += " AND BowTuning = \"Y\"";

            List<string> tmpList = tmpShopTools.FindShops(search);

            listBoxShops.Items.Clear();
            for (int i = 0; i < tmpList.Count; i++)
                listBoxShops.Items.Add(tmpList[i]);
        }

        private void lblURL_Click(object sender, EventArgs e)
        {
            frmQbrowse tmpBrowser = new frmQbrowse();
            tmpBrowser.GotoURL(lblURL.Text);
            tmpBrowser.Show();  
        }
    }
}
