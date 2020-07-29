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
    public partial class frmArrowWorx : Form
    {
        public frmArrowWorx()
        {
            InitializeComponent();
        }

        private void ArrowWorx_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            cDataController db = new cDataController();
            db.OpenDatabase("./data/AW.db");
            
            DataTable dtTmp = db.ExecuteQuery("select Name from Arrows");

            foreach (DataRow row in dtTmp.Rows)
            {
                for (int i = 0; i < dtTmp.Columns.Count; i++)
                    comboBoxUsrShafts.Items.Add(row[i]);          
            }

            dtTmp = db.ExecuteQuery("select Name from Nocks");

            foreach (DataRow row in dtTmp.Rows)
            {
                for (int i = 0; i < dtTmp.Columns.Count; i++)
                    comboBoxUsrNock.Items.Add(row[i]);
            }
            
            dtTmp = db.ExecuteQuery("select Name from Inserts");

            foreach (DataRow row in dtTmp.Rows)
            {
                for (int i = 0; i < dtTmp.Columns.Count; i++)
                    comboBoxUsrInsert.Items.Add(row[i]);           
            }

            dtTmp = db.ExecuteQuery("select Name from NockAdapters");

            foreach (DataRow row in dtTmp.Rows)
            {
                for (int i = 0; i < dtTmp.Columns.Count; i++)
                    comboBoxUsrNockAdapter.Items.Add(row[i]);
            }

            dtTmp = db.ExecuteQuery("select Name from Fletches");

            foreach (DataRow row in dtTmp.Rows)
            {
                comboBoxUsrFletches.Items.Add(row["Name"]);
            }
        }

        private double GetComboBoxValue(ComboBox cbInput, string sSearch)
        {
            string tmpSearch = cbInput.Text;
            double dRetvalue = 0;

            cDataController db = new cDataController();
            db.OpenDatabase("./data/AW.db");
            string query = "select * from " + sSearch + " where Name='" + tmpSearch + "'";
            //MessageBox.Show(query);
            DataTable dtTmp = db.ExecuteQuery(query);

            foreach (DataRow row in dtTmp.Rows)
            {
                dRetvalue = Convert.ToDouble(row["Weight"]);
            }
            
            return dRetvalue;
        }

         /*
            11-16	fita
            6-12	3d
            10-15	field
            10-15	hunting
         */
        private string GetFOCRecommendation(string FOC)
        {
            double dFOC = Convert.ToDouble(FOC);

            FOC = "";


            if ((dFOC >= 11) & (dFOC <= 16))
                FOC += "FITA\r\n";

            if ((dFOC >= 10) & (dFOC <= 15))
                FOC += "Hunting\r\nField\r\n";

            if ((dFOC >= 6) & (dFOC <= 12))
                FOC += "3D\r\n";
             
            if ((FOC == "") & (dFOC < 6)) FOC = "Try to increase the FOC\r\n for a more useful arrow.";

            if ((FOC == "") & (dFOC > 16)) FOC = "Try to decrease the FOC\r\n for a more useful arrow.";
            return FOC;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();            
        }

        private void Calculate()
        {
            BowPhysics awBowPhysics = new BowPhysics();

            double dShaftLength = Convert.ToDouble(txtUsrShaftLength.Text);
            double dShaftGpI = Convert.ToDouble(txtUsrGpI.Text);
            double dTipWeight = Convert.ToDouble(comboBoxUsrTipWeight.Text); //usrTipWeightDropDown.Entry.Text);
            double dInsertWeight = GetComboBoxValue(comboBoxUsrInsert, "Inserts");
            double dNockWeight = GetComboBoxValue(comboBoxUsrNock, "Nocks");
            double dFletchWeight = GetComboBoxValue(comboBoxUsrFletches, "Fletches");

            double dTotalFletchingWeight = dFletchWeight * 3;
            double dRearWeight = dNockWeight + dFletchWeight * 3;
            double dTotalTipWeight = dTipWeight + dInsertWeight;
            double dTotalShaftWeight = dShaftLength * dShaftGpI;
            double dTotalArrowWeight = dTotalShaftWeight + dTotalTipWeight + dRearWeight;

            string sFOC = awBowPhysics.CalcFOC(dNockWeight, dShaftLength, dTotalFletchingWeight, dShaftGpI, dTipWeight);

            lblSysRearWeight.Text = dRearWeight.ToString();
            lblSysTipWeight.Text = dTotalTipWeight.ToString();
            lblSysShaftWeight.Text = dTotalShaftWeight.ToString();
            lblSysTotalWeight.Text = dTotalArrowWeight.ToString();

            lblSysFOC.Text = sFOC + " %";
            lblNote.Text = GetFOCRecommendation(sFOC);
        }
        private void comboBoxUsrShafts_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Weight = Convert.ToDouble(GetComboBoxValue(comboBoxUsrShafts,"arrows"));
            txtUsrGpI.Text = Weight.ToString();    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        
        private void SaveAs()
        {
            Calculate();
            
            cArrow tmpArrow = new cArrow(
                                    comboBoxUsrShafts.Text,
                                    comboBoxUsrInsert.Text,
                                    comboBoxUsrNock.Text,
                                    comboBoxUsrNockAdapter.Text,
                                    txtUsrShaftLength.Text,
                                    txtUsrGpI.Text,
                                    comboBoxUsrTipWeight.Text,
                                    comboBoxUsrFletches.Text,
                                    lblSysRearWeight.Text,
                                    lblSysShaftWeight.Text,
                                    lblSysTipWeight.Text,
                                    lblSysTotalWeight.Text,
                                    lblSysFOC.Text
                                        );
            
            string path = Directory.GetCurrentDirectory().ToString() + "\\Arrows\\";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML |*.xml";
            saveFileDialog1.Title = "Save an XML Arrow File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                //System.IO.FileStream fs =
                //   (System.IO.FileStream)saveFileDialog1.OpenFile();
                tmpArrow.SaveArrow(tmpArrow, saveFileDialog1.FileName);
                MessageBox.Show("Arrow Saved.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadArrow();
            Calculate();
        }

        private void LoadArrow()
        {
            OpenFileDialog bleh = new OpenFileDialog();

            string path = Directory.GetCurrentDirectory().ToString() + "\\Arrows\\";

            bleh.InitialDirectory = path;
            bleh.ShowDialog();            

            if (bleh.FileName != "")
            {
                cArrow tmpArrow = new cArrow();
                tmpArrow = tmpArrow.GetArrow(bleh.FileName);

                comboBoxUsrShafts.Text = tmpArrow.ArrowShaft;
                comboBoxUsrInsert.Text = tmpArrow.Insert;
                comboBoxUsrNock.Text = tmpArrow.Nock;
                comboBoxUsrNockAdapter.Text = tmpArrow.NockAdapter;
                txtUsrShaftLength.Text = tmpArrow.ShaftLength;
                txtUsrGpI.Text = tmpArrow.GpI;
                comboBoxUsrTipWeight.Text = tmpArrow.TipWeight;
                comboBoxUsrFletches.Text = tmpArrow.Fletches;
                lblSysRearWeight.Text = tmpArrow.TotalRearWeight;
                lblSysShaftWeight.Text = tmpArrow.TotalShaftWeight;
                lblSysTipWeight.Text = tmpArrow.TotalTipWeight;
                lblSysTotalWeight.Text = tmpArrow.TotalWeight;
                lblSysFOC.Text = tmpArrow.FOC;
  
            }
        }
    }
}
