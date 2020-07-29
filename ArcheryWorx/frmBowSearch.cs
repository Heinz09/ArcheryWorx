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
    public partial class frmBowSearch : Form
    {
        private string MyArcher = "";
        private double MyDrawWeight;
        private double MyDrawDistance;

        public frmBowSearch()
        {
            InitializeComponent();
        }

        public string ConvertToFraction(double Number)
        {
            string ReturnVal = "";
            double BaseNumber = Math.Floor(Number);
            
            string Fraction = Convert.ToString(Number - BaseNumber);

            switch (Fraction)
            {
                case "0.875":
                    {
                        Fraction = "7/8";
                        break;
                    }
                case "0.8":
                    {
                        Fraction = "4/5";
                        break;
                    }
                case "0.75":
                    {
                        Fraction = "¾";
                        break;
                    }
                case "0.625":
                    {
                        Fraction = "5/8";
                        break;
                    }
                case "0.6":
                    {
                        Fraction = "3/5";
                        break;
                    }
                case "0.5":
                    {
                        Fraction = "½";
                        break;
                    }
                case "0.4":
                    {
                        Fraction = "2/5";
                        break;
                    }
                case "0.375":
                    {
                        Fraction = "3/8";
                        break;
                    }
                case "0.25":
                    {
                        Fraction = "¼";
                        break;
                    }
                case "0.2":
                    {
                        Fraction = "1/5";
                        break;
                    }
                case "0.125":
                    {
                        Fraction = "1/8";
                        break;
                    }
                case "0":
                    {
                        Fraction = "";
                        break;
                    }
            }

            ReturnVal = BaseNumber +" "+ Fraction;

            return ReturnVal;
        }


        private void BowSearch_Load(object sender, EventArgs e)
        {
            List<string> tmpList = new List<string>();

            cCompoundBowTools cBowTools = new cCompoundBowTools();

            tmpList = cBowTools.GetBows(); 
            //--------------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < tmpList.Count; i++)
                listBoxSysBows.Items.Add(tmpList[i]);
            //--------------------------------------------------------------------------------------------------------------------------------------------------

            listBoxSysBows.Items.Clear();
            for (int i = 0; i < tmpList.Count; i++)
                listBoxSysBows.Items.Add(tmpList[i]);

            lblCount.Text = tmpList.Count.ToString() + " Bows";

            frmArcheryWorx tmpArchery = (frmArcheryWorx)this.MdiParent;
            MyArcher = tmpArchery.GetArcher();
            string path = Directory.GetCurrentDirectory().ToString() + "\\Archers\\" + MyArcher + ".xml";

            cArcher tmpArcher = new cArcher();

            //MessageBox.Show(path);
            if (path != "")
            {
                tmpArcher = tmpArcher.GetArcher(path);
                MyDrawDistance = Convert.ToDouble(tmpArcher.DrawLength);
                MyDrawWeight = Convert.ToDouble(tmpArcher.DrawWeight);
            }
            txtUsrDrawLength.Text = MyDrawDistance.ToString();
            txtUsrDrawWeight.Text = MyDrawWeight.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            string search = "";

            if (comboBoxName.Text != "Any")
                search += "Name Like \"" + comboBoxName.Text + "%\" ";
            else
                search += "Name Like \"%\"";

            if (txtUsrDrawWeight.Text != "")
                search += "and MinDrawWeight<=" + txtUsrDrawWeight.Text + " and MaxDrawWeight >=" + txtUsrDrawWeight.Text + " ";

            if (txtUsrDrawLength.Text != "")
                search += "and MinDrawLength <= " + txtUsrDrawLength.Text + " and MaxDrawLength>=" + txtUsrDrawLength.Text + " ";            

            if (txtUsrBraceHeight.Text != "")
                search += "and BraceHeight <= " + txtUsrBraceHeight.Text + " ";

            if (txtUsrMaxAtA.Text != "")
                search += "and AxleToAxle <= " + txtUsrMaxAtA.Text + " ";

            if (txtUsrMinAtA.Text != "")
                search += "and AxleToAxle >= " + txtUsrMinAtA.Text + " ";

            if (txtMaxWeight.Text != "")
                search += "and Weight <= " + txtMaxWeight.Text + " ";

            List<string> tmpList = new List<string>();

            cCompoundBowTools cTools = new cCompoundBowTools();

            tmpList = cTools.FindBows(search);
            
            listBoxSysBows.Items.Clear();
            for (int i = 0; i < tmpList.Count; i++)
                listBoxSysBows.Items.Add(tmpList[i]);

            lblCount.Text = tmpList.Count.ToString() + " Bows";
        }

        private void btnToBlockA_Click(object sender, EventArgs e)
        {
            cCompoundBowTools cTools = new cCompoundBowTools();

            cCompoundBow Tmp = cTools.GetBowSpecs(listBoxSysBows.Text);
            
            groupBoxA.Text = Tmp.BowName.ToString();
            lblAAtA.Text = Tmp.AxleToAxleLength.ToString();
            lblABraceHeight.Text = Tmp.BraceHeight.ToString();
            lblAIBOSpeed.Text = Tmp.IBOSpeed.ToString();
            lblALetoff.Text = Tmp.LetOff.ToString();
            lblAMaxDrawLength.Text = Tmp.MaxDrawDistance.ToString();
            lblAMaxDrawWeight.Text = Tmp.MaxDrawWeight.ToString();
            lblAMinDrawLength.Text = Tmp.MinDrawDistance.ToString();
            lblAMinDrawWeight.Text = Tmp.MinDrawWeight.ToString();
            lblAWeight.Text = Tmp.Weight.ToString();            
        }

        private void btnToBlockB_Click(object sender, EventArgs e)
        {
            cCompoundBowTools cTools = new cCompoundBowTools();

            cCompoundBow Tmp = cTools.GetBowSpecs(listBoxSysBows.Text);

            groupBoxB.Text = Tmp.BowName.ToString();
            lblBAtA.Text = Tmp.AxleToAxleLength.ToString();
            lblBBraceHeight.Text = Tmp.BraceHeight.ToString();
            lblBIBOSpeed.Text = Tmp.IBOSpeed.ToString();
            lblBLetoff.Text = Tmp.LetOff.ToString();
            lblBMaxDrawLength.Text = Tmp.MaxDrawDistance.ToString();
            lblBMaxDrawWeight.Text = Tmp.MaxDrawWeight.ToString();
            lblBMinDrawLength.Text = Tmp.MinDrawDistance.ToString();
            lblBMinDrawWeight.Text = Tmp.MinDrawWeight.ToString();
            lblBWeight.Text = Tmp.Weight.ToString();
        }

        private void listBoxSysBows_SelectedIndexChanged(object sender, EventArgs e)
        {
            cCompoundBowTools cTools = new cCompoundBowTools();

            cCompoundBow Tmp = cTools.GetBowSpecs(listBoxSysBows.Text);
            
            groupBoxA.Text = Tmp.BowName.ToString();
            lblAAtA.Text = ConvertToFraction(Tmp.AxleToAxleLength).ToString();
            lblABraceHeight.Text = ConvertToFraction(Tmp.BraceHeight).ToString();
            lblAIBOSpeed.Text = Tmp.IBOSpeed.ToString();
            lblALetoff.Text = Tmp.LetOff.ToString();
            lblAMaxDrawLength.Text = ConvertToFraction(Tmp.MaxDrawDistance).ToString();
            lblAMaxDrawWeight.Text = ConvertToFraction(Tmp.MaxDrawWeight).ToString();
            lblAMinDrawLength.Text = ConvertToFraction(Tmp.MinDrawDistance).ToString();
            lblAMinDrawWeight.Text = ConvertToFraction(Tmp.MinDrawWeight).ToString();
            lblAWeight.Text = ConvertToFraction(Tmp.Weight).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
