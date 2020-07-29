using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace ArcheryWorx
{
    public partial class frmArcherWorx : Form
    {
        public frmArcherWorx()
        {
            InitializeComponent();
        }

        private int getAge(string sAge)
        {
            string tmpRet = "";
        
            bool bStrip = false;
            
            for (int i = 0; i < sAge.Length; i++)
            {
                if (!bStrip)
                {
                    switch (sAge[i])
                    {
                        case '.': bStrip = true; break;
                        case ':': bStrip = true; break;
                        default: tmpRet += sAge[i];
                            break;
                    }
                }
            }

            return Convert.ToInt16(tmpRet)/365;
        }

        private void Calculate()
        {
            BowPhysics awBowPhysics = new BowPhysics();
            double dHeight = 0;
            double dWeight = 0;

            if (btnConvert.Text == "Metric")
            {
                dHeight = Convert.ToDouble(txtUsrHeight.Text);
                dWeight = Convert.ToDouble(txtUsrWeight.Text);
            }
            else
            {                
                dHeight = Convert.ToDouble(LengthConvertToMeters(txtUsrHeight.Text));
                dWeight = Convert.ToDouble(WeightConvertToLBS(Convert.ToDouble( txtUsrWeight.Text)));
            }

            DateTime dtNow = Convert.ToDateTime(DateTime.Now);
            DateTime dtBorn = Convert.ToDateTime(dateTimePickerUsrAge.Value.ToString());

            var dtAge = dtNow - dtBorn;

            lblAge.Text = getAge(dtAge.ToString()).ToString();
            lblCalcDrawDistance.Text = awBowPhysics.GetRecommendedDrawDistance(dHeight).ToString() ;
            lblCalcDrawWeight.Text = awBowPhysics.GetRecommendedBowWeight(dWeight, comboBoxUsrGender.Text, getAge(dtAge.ToString()));
            txtUsrDrawLength.Text = Convert.ToString(Math.Round(Convert.ToDouble(lblCalcDrawDistance.Text)));
            txtUsrDrawWeight.Text = lblCalcDrawWeight.Text.Substring(0, 2).ToString();
            if (txtUsrName.Text=="")
                txtUsrName.Text = "Unknown";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ArcherWorx_Load(object sender, EventArgs e)
        {
            dateTimePickerUsrAge.Value = DateTime.Now.AddYears(-21);
            cCompoundBowTools cTools = new cCompoundBowTools();
            List<string> Bows = cTools.GetBows();
            foreach (string Bow in Bows)
            {
                comboBoxBows.Items.Add(Bow);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Calculate();
            
            cArcher tmpArcher = new cArcher();
            DateTime DoB = dateTimePickerUsrAge.Value;

            tmpArcher.Name = txtUsrName.Text;
            tmpArcher.Handiness = comboBoxHandiness.Text;
            tmpArcher.DrawWeight = txtUsrDrawWeight.Text;
            tmpArcher.DrawLength = txtUsrDrawLength.Text;
            tmpArcher.CompoundBow = comboBoxBows.Text;
            tmpArcher.Weight = txtUsrWeight.Text;
            tmpArcher.Height = txtUsrHeight.Text;
            tmpArcher.DoB = Convert.ToString(DoB.ToShortDateString());
            tmpArcher.Gender = comboBoxUsrGender.Text;
            
            if (tmpArcher.Name != "")
            {
                if (tmpArcher.SaveArcher(tmpArcher))
                    MessageBox.Show(tmpArcher.Name + " has been saved.");
                else
                    MessageBox.Show("An Error has occured.");
            }
            else
            {
                MessageBox.Show("Archer Name cannot be blank.");
                txtUsrName.Focus();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog bleh = new OpenFileDialog();

            string path = Directory.GetCurrentDirectory().ToString() + "\\Archers\\";//".";//"./Archers";

            bleh.InitialDirectory = path;
            bleh.ShowDialog();
            
            cArcher tmpArcher = new cArcher();
            
            if (bleh.FileName != "")
            {
                tmpArcher = tmpArcher.GetArcher(bleh.FileName);

                //MessageBox.Show(tmpArcher.Name + " is a " + tmpArcher.Gender + " who is " + tmpArcher.Handiness + " who was born " + tmpArcher.DoB);
                //tmpArcher = tmpArcher.GetArcher(path);
                comboBoxBows.Text = tmpArcher.CompoundBow;
                txtUsrName.Text = tmpArcher.Name;
                txtUsrDrawLength.Text = tmpArcher.DrawLength;
                txtUsrDrawWeight.Text = tmpArcher.DrawWeight;
                dateTimePickerUsrAge.Text = tmpArcher.DoB;
                comboBoxUsrGender.Text = tmpArcher.Gender;
                comboBoxHandiness.Text = tmpArcher.Handiness;
                txtUsrHeight.Text = tmpArcher.Height;
                txtUsrWeight.Text = tmpArcher.Weight;
            }            
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (btnConvert.Text == "Imperial")
            {
                //txtSysMaleMaxWeight.Text = WeightConvertToLBS(Convert.ToDouble(txtSysMaleMaxWeight.Text)).ToString();
                txtUsrHeight.Text = LengthConvertToMeters(txtUsrHeight.Text).ToString();
                txtUsrWeight.Text = WeightConvertToLBS(Convert.ToDouble(txtUsrWeight.Text)).ToString();
                lblHeight.Text = "m";
                lblWeight.Text = "kg";

                btnConvert.Text = "Metric";
            }
            else
            {

                txtUsrHeight.Text = Convert.ToString(LengthConvertToImperial( Convert.ToDouble(txtUsrHeight.Text)*100));
                txtUsrWeight.Text = WeightConvertToKG(Convert.ToDouble(txtUsrWeight.Text)).ToString();
                lblHeight.Text = "\'";
                lblWeight.Text = "lbs";
                btnConvert.Text = "Imperial";
            }
        }
        private double WeightConvertToLBS(double WeightKg)
        {
            return Math.Round((WeightKg / 2.2), 2);
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

            string returnval = Feet.ToString() + "' " + dTemp.ToString() + "\"";//+" - "+dTemp.ToString;
            return returnval;
        }

        private double LengthConvertToMeters(string ImperialMeasurements)
        {
            string feet = "";
            string inches = "";
            bool InchSwap = false;
            for (int i = 0; i < ImperialMeasurements.Length; i++)
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
            
            //Convert.ToInt16((((Convert.ToInt16(feet) * 12 * 2.54) + (Convert.ToInt16(inches) * 2.54))/100));

            if (inches == "") inches = "0";
            
            double dFeet = Convert.ToDouble(feet)*12*2.54/100;
            double dInches = Convert.ToDouble(inches)*2.54/100;
            
            return Math.Round(dFeet + dInches,2);
        }

    }
}