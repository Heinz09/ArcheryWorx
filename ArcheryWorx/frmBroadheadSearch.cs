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
    public partial class frmBroadheadSearch : Form
    {
        public frmBroadheadSearch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Populate()
        {            
            cBroadheadTools tmpTools = new cBroadheadTools();
            List<cBroadheads> tmpList = tmpTools.GetBroadheads();

            for (int i = 0; i < tmpList.Count; i++)
                listBroadheads.Items.Add(tmpList[i].TipID+":"+ tmpList[i].Manufacturer+" "+tmpList[i].TipName+" "+tmpList[i].Grains+"gr");

            lblCount.Text = tmpList.Count.ToString()+ " Broadheads filtered.";                
        }

        private void Populate(string query)
        {
            cBroadheadTools tmpTools = new cBroadheadTools();
            List<cBroadheads> tmpList = tmpTools.GetBroadheads(query);

            for (int i = 0; i < tmpList.Count; i++)
                listBroadheads.Items.Add(tmpList[i].TipID+":"+ tmpList[i].Manufacturer + " " + tmpList[i].TipName + " " + tmpList[i].Grains + "gr");                

            lblCount.Text = tmpList.Count.ToString() + " Broadheads filtered.";
        }

        private void frmBroadheadSearch_Load(object sender, EventArgs e)
        {                       
            Populate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBroadheads.Items.Clear();
            string query = "";

            if (comboBoxManufacturer.Text != "Any")
            {
                if (query != "") query += " AND Manufacturer = \"" + comboBoxManufacturer.Text + "\"";
                else query += " WHERE Manufacturer = \"" + comboBoxManufacturer.Text + "\"";
            }

            if (comboBoxGrains.Text != "Any")
            {
                if (query != "") query += " AND Grains = \"" + comboBoxGrains.Text + "\"";
                else query += " WHERE Grains = \"" + comboBoxGrains.Text + "\"";
            }

            if (comboBoxBroadheadType.Text != "Any")
            {
                string searchVal;
                if (comboBoxBroadheadType.Text == "Fixed") searchVal = "f";
                else if (comboBoxBroadheadType.Text == "Mechanical") searchVal = "m";
                else searchVal = "s";

                if (query != "") query += " AND Type = \"" + searchVal + "\"";
                else query += " WHERE Type = \"" + searchVal + "\"";
            }

            Populate(query);
        }

        private void listBroadheads_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmpStr = "";
            bool bTemp = false;

            for (int i = 0; i < listBroadheads.Text.Length; i++)
            {
                if (listBroadheads.Text[i].ToString() == ":") bTemp = true;

                if (!bTemp)
                {
                    tmpStr += listBroadheads.Text[i];
                }
            }

            cBroadheadTools tmpTools = new cBroadheadTools();

            cBroadheads tmpTip = tmpTools.FindBroadhead(tmpStr);

            lblManufacturer.Text = tmpTip.Manufacturer;
            lblBladeCount.Text = tmpTip.BladeCount.ToString();
            lblCuttingDiameter.Text = tmpTip.CuttingDiameter.ToString()+"\"";
            lblGrains.Text = tmpTip.Grains.ToString()+"gr";
            lblName.Text = tmpTip.TipName;

            if (tmpTip.Type == "f") lblType.Text = "Fixed Blade";           
            else if (tmpTip.Type == "m") lblType.Text = "Mechanical Blade";
            else lblType.Text = "Small Game";
        }
    }
}
