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
    public partial class frmHuntingWorx : Form
    {
        public frmHuntingWorx()
        {
            InitializeComponent();
        }

        private void HuntingWorx_Load(object sender, EventArgs e)
        {
            cDataController db = new cDataController();
            db.OpenDatabase("./data/AW.db");

            DataTable dtTmp = db.ExecuteQuery("select * from Species");

            foreach (DataRow row in dtTmp.Rows)
            {
                //for (int i = 0; i < dtTmp.Columns.Count; i++)
                listBoxUsrSpecies.Items.Add(row["GeneralName"]);
                //comboBoxUsrShafts.Items.Add(row[i]);
            }
        }


        private void GetInfo(string sName)
        {
            if (sName != "")
            {
                cDataController db = new cDataController();
                db.OpenDatabase("./data/AW.db");
                DataTable dtTmp = db.ExecuteQuery("select * from Species where GeneralName='" + sName + "'");

                foreach (DataRow row in dtTmp.Rows)
                {
                    txtSysSpecie.Text = row["GeneralName"].ToString();
                    txtSysConservationStatus.Text = row["ConservationStatus"].ToString();
                    
                    txtSysFemaleMaxWeight.Text = row["FemaleWeightMax"].ToString();
                    txtSysFemaleMinWeight.Text = row["FemaleWeightMin"].ToString();
                    txtSysMaleMaxWeight.Text = row["MaleWeightMax"].ToString();
                    txtSysMaleMinWeight.Text = row["MaleWeightMin"].ToString();

                    txtSysHeightMax.Text = row["HeightMax"].ToString();
                    txtSysHeightMin.Text = row["HeightMin"].ToString();
                    txtSysLengthMax.Text = row["LengthMax"].ToString();
                    txtSysLengthMin.Text = row["LengthMin"].ToString();

                    txtSysDescription.Text = row["Description"].ToString();
                    
                    string Image1 = "./img/" + row["Image1"].ToString();
                    //string Image1 = "\""+Directory.GetCurrentDirectory() + "\\img\\" + row["Image1"].ToString()+"\"";
                    //MessageBox.Show(Image1);
                    //pictureBox.ImageLocation = Image1; //ArcheryWorx.Properties.Resources.Right_Tear;
                    //this.pictureBox1.Image = Image.FromFile(PicURI);
                    pictureBoxMain.Image = Image.FromFile(Image1);
                    pictureBoxMain.Refresh();
                }
            }
            else MessageBox.Show("No Animal Selected");
        }

        private void listBoxUsrSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInfo(listBoxUsrSpecies.Text);
            conversion_imperial = false;
            btnConversion.Text = "Metric";
        }        

        private double WeightConvertToLBS(double WeightKg)
        {
            return Math.Round( (WeightKg / 2.2),2);            
        }

        private double WeightConvertToKG(double WeightLbs)
        {
            return Math.Round((WeightLbs * 2.2), 2);
        }

        private string LengthConvertToImperial(double LengthCM)
        {
            double dTemp = LengthCM / 2.54;

            int Feet = 0;

            while (dTemp > 12)
            {
                Feet++;
                dTemp = dTemp - 12;
            }

            dTemp = Math.Round(dTemp, 0);

            string returnval = Feet.ToString() + "' "+dTemp.ToString()+"\"";//+" - "+dTemp.ToString;
            return returnval;
        }

        private int LengthConvertToCentimeters(string ImperialMeasurements)
        {
            string feet = "";
            string inches = "";
            bool InchSwap = false;
            for (int i = 0; i<ImperialMeasurements.Length; i++)
            {
                char LoopChar = ImperialMeasurements[i];

                if (LoopChar != '\'')
                {
                    if (LoopChar != '"')
                    {
                        if (!InchSwap) feet += LoopChar;
                        else inches += LoopChar;                
                    }
                }
                
                if (LoopChar == '\'')
                {
                    InchSwap = true;
                }
                
            }
            
            int iRetval = Convert.ToInt16( ((Convert.ToInt16(feet) * 12 * 2.54) + (Convert.ToInt16(inches) * 2.54)));                        
            return iRetval;
        }

        bool conversion_imperial = false;
        private void btnConversion_Click(object sender, EventArgs e)
        {
            
            if (conversion_imperial)
            {
                btnConversion.Text = "Metric";

                txtSysMaleMaxWeight.Text= WeightConvertToLBS(Convert.ToDouble(txtSysMaleMaxWeight.Text)).ToString();
                txtSysMaleMinWeight.Text = WeightConvertToLBS(Convert.ToDouble(txtSysMaleMinWeight.Text)).ToString();
                txtSysFemaleMaxWeight.Text = WeightConvertToLBS(Convert.ToDouble(txtSysFemaleMaxWeight.Text)).ToString();
                txtSysFemaleMinWeight.Text = WeightConvertToLBS(Convert.ToDouble(txtSysFemaleMinWeight.Text)).ToString();

                txtSysHeightMin.Text = LengthConvertToCentimeters(txtSysHeightMin.Text).ToString();
                txtSysHeightMax.Text = LengthConvertToCentimeters(txtSysHeightMax.Text).ToString();
                txtSysLengthMax.Text = LengthConvertToCentimeters(txtSysLengthMax.Text).ToString();
                txtSysLengthMin.Text = LengthConvertToCentimeters(txtSysLengthMin.Text).ToString();

                lblLength1.Text = "cm";
                lblLength2.Text = "cm";
                lblLength3.Text = "cm";
                lblLength4.Text = "cm";

                lblWeight1.Text = "kg";
                lblWeight2.Text = "kg";
                lblWeight3.Text = "kg";
                lblWeight4.Text = "kg";
            }
            else
            {
                btnConversion.Text = "Imperial";
                
                txtSysMaleMaxWeight.Text = WeightConvertToKG(Convert.ToDouble(txtSysMaleMaxWeight.Text)).ToString();
                txtSysMaleMinWeight.Text = WeightConvertToKG(Convert.ToDouble(txtSysMaleMinWeight.Text)).ToString();
                txtSysFemaleMaxWeight.Text = WeightConvertToKG(Convert.ToDouble(txtSysFemaleMaxWeight.Text)).ToString();
                txtSysFemaleMinWeight.Text = WeightConvertToKG(Convert.ToDouble(txtSysFemaleMinWeight.Text)).ToString();

                txtSysHeightMin.Text = LengthConvertToImperial(Convert.ToDouble(txtSysHeightMin.Text));
                txtSysHeightMax.Text = LengthConvertToImperial(Convert.ToDouble(txtSysHeightMax.Text));
                txtSysLengthMax.Text = LengthConvertToImperial(Convert.ToDouble(txtSysLengthMax.Text));
                txtSysLengthMin.Text = LengthConvertToImperial(Convert.ToDouble(txtSysLengthMin.Text));

                lblLength1.Text = "";
                lblLength2.Text = "";
                lblLength3.Text = "";
                lblLength4.Text = "";

                lblWeight1.Text = "lbs";
                lblWeight2.Text = "lbs";
                lblWeight3.Text = "lbs";
                lblWeight4.Text = "lbs";
            }
            conversion_imperial = !conversion_imperial;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog bleh = new OpenFileDialog();
            bleh.InitialDirectory = "./";
            bleh.ShowDialog();
            pictureBox.ImageLocation = bleh.FileName;
            */
            OpenFileDialog bleh = new OpenFileDialog();
            bleh.ShowDialog();
            //pictureBox.ImageLocation = bleh.FileName.ToString();
        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(pictureBoxMain.ImageLocation);
        }
    }
}