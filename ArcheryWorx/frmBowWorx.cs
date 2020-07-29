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
    public partial class frmBowWorx : Form
    {
        private cArcher MyArcherClass = new cArcher();
        private string MyArcher = "";
        private double MyDrawWeight;
        private double MyDrawDistance;
        
        public frmBowWorx()
        {
            InitializeComponent();            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {            
            if (groupBoxSysBowSpecs.Text == "Bow Specifications") MessageBox.Show("Calculations done with no selected bow");

            Compare();

            BowPhysics cPhysics = new BowPhysics();                        

            double cIBOSpeed = Convert.ToDouble(txtUsrIBOSpeed.Text);
            double cDrawWeight = Convert.ToDouble(txtUsrDrawWeight.Text);
            double cDrawLength = Convert.ToDouble(txtUsrDrawLength.Text);
            double cArrowWeight = Convert.ToDouble(txtUsrArrowWeight.Text);
            double cStringWeight = Convert.ToDouble(txtUsrStringWeight.Text);

            double cVelocity = cPhysics.CalcBowSpeed(cIBOSpeed, cDrawWeight, cDrawLength, cArrowWeight, cStringWeight);
            double cKineticEnergy = cPhysics.CalcKE(cVelocity, cArrowWeight);

            txtCalcBowSpeed.Text = cVelocity.ToString();
            txtCalcKE.Text = cKineticEnergy.ToString();
            txtCalcMomentum.Text = cPhysics.CalcMom(cVelocity, cArrowWeight).ToString();
            lblRecommendedGame.Text = cPhysics.CalcMaxGame(cKineticEnergy);
            lblArrowLength.Text = "A minimum arrow length of "+cPhysics.CalcMinArrowLength(cDrawLength).ToString()+"\"";
            lblArrowWeight.Text = "A minumum arrow weight of "+cPhysics.CalcMinArrowWeight(cDrawWeight).ToString()+"grains";
        }

        private void Populate()
        {
            comboBoxBows.Text = "Any";
            List<string> tmpList = new List<string>();

            cCompoundBowTools cBowTools = new cCompoundBowTools();

            tmpList = cBowTools.GetBows();

            for (int i = 0; i < tmpList.Count; i++)
                listBoxSysBows.Items.Add(tmpList[i]);

            txtUsrDrawLength.Text = MyDrawDistance.ToString();
            txtUsrDrawWeight.Text = MyDrawWeight.ToString();
        }

        private void GetBowSpecs(string BowName)
        {
            cCompoundBowTools cTools = new cCompoundBowTools();

            cCompoundBow Tmp = cTools.GetBowSpecs(listBoxSysBows.Text);

            groupBoxSysBowSpecs.Text = Tmp.BowName.ToString();
            lblSysAxleToAxle.Text = Tmp.AxleToAxleLength.ToString();
            lblSysBraceHeight.Text = Tmp.BraceHeight.ToString();
            lblSysIBOSpeed.Text = Tmp.IBOSpeed.ToString();
            lblSysLetOff.Text = Tmp.LetOff.ToString();
            lblSysMaxDrawLength.Text = Tmp.MaxDrawDistance.ToString();
            lblSysMaxDrawWeight.Text = Tmp.MaxDrawWeight.ToString();
            lblSysMinDrawLength.Text = Tmp.MinDrawDistance.ToString();
            lblSysMinDrawWeight.Text = Tmp.MinDrawWeight.ToString();
            lblSysWeight.Text = Tmp.Weight.ToString();
            
            txtUsrIBOSpeed.Text = lblSysIBOSpeed.Text;

            if (checkBoxUsrWarnings.Checked)
            {
                if ((Convert.ToDouble(txtUsrDrawWeight.Text)) > (Convert.ToDouble(lblSysMaxDrawWeight.Text)))
                {
                    MessageBox.Show("The selected bow's Draw Weight it below your preffered draw weight");
                    txtUsrDrawWeight.Text = lblSysMaxDrawWeight.Text;
                }

                if ((Convert.ToDouble(txtUsrDrawWeight.Text)) < (Convert.ToDouble(lblSysMinDrawWeight.Text)))
                {
                    MessageBox.Show("The selected bow's Minimum Draw Weight it above your preffered draw weight");
                    txtUsrDrawWeight.Text = lblSysMinDrawWeight.Text;
                }

                if (Convert.ToDouble(txtUsrDrawLength.Text) > Convert.ToDouble(lblSysMaxDrawLength.Text))
                {
                    MessageBox.Show("The selected bow's Draw Length is too short for you.");
                    txtUsrDrawLength.Text = lblSysMaxDrawLength.Text;
                }

                if (Convert.ToDouble(txtUsrDrawLength.Text) < Convert.ToDouble(lblSysMinDrawLength.Text))
                {
                    MessageBox.Show("The selected bow's Minimum Draw Length is too much for you.");
                    txtUsrDrawLength.Text = lblSysMaxDrawLength.Text;
                }

            }
        }

        private void BowWorx_Load(object sender, EventArgs e)
        {
            if (!CheckArcher()) MessageBox.Show("Your archer is not properly configured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Populate();
        }

        /// <summary>
        /// Checks to see if the archer is properly configured
        /// </summary>
        /// <returns>True if all is good.</returns>
        private bool CheckArcher()
        {
            frmArcheryWorx tmpArchery = (frmArcheryWorx)this.MdiParent;
            MyArcher = tmpArchery.GetArcher();
            string path = Directory.GetCurrentDirectory().ToString() + "\\Archers\\"+MyArcher+".xml";

            cArcher tmpArcher = new cArcher();

            //MessageBox.Show(path);
            if (path != "")
            {
                tmpArcher = tmpArcher.GetArcher(path);
                try
                {
                    MyDrawDistance = Convert.ToDouble(tmpArcher.DrawLength);
                    MyDrawWeight = Convert.ToDouble(tmpArcher.DrawWeight);
                    return true;
                }
                catch
                {
                    return false;
                }                
            }
            return false;
        }

        private void listBoxSysBows_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBowSpecs(listBoxSysBows.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmArcherSelector tmpArcherSelector = new frmArcherSelector();
            tmpArcherSelector.Show();       
        }

        private void Compare()
        {
            txtCalcBowspeedCompare.Text = txtCalcBowSpeed.Text;
            txtCalcKECompare.Text = txtCalcKE.Text;
            txtCalcMomentumCompare.Text = txtCalcMomentum.Text;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            Compare();
        }

        private void checkBoxUsrWarnings_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxUsrWarnings.Checked)
                MessageBox.Show("Warnings are now disabled.");
        }

        private void comboBoxBows_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = "";
            List<string> tmpList = new List<string>();
            cCompoundBowTools cTools = new cCompoundBowTools();

            if (comboBoxBows.Text != "Any")
            {
                search = "Name Like \"" + comboBoxBows.Text + "%\" ";
                tmpList = cTools.FindBows(search);
            }
            else tmpList = cTools.GetBows();
            
            listBoxSysBows.Items.Clear();
            for (int i = 0; i < tmpList.Count; i++)
                listBoxSysBows.Items.Add(tmpList[i]);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Load the arrow and make a nice little icon");
            cArrow tmp = LoadArrow();

            txtUsrArrowWeight.Text = tmp.TotalWeight;

            if (Convert.ToDouble(tmp.ShaftLength) < (Convert.ToDouble(txtUsrDrawLength.Text))) MessageBox.Show("Your arrows might be too short. Please check appropriate arrow length");
            
        }

        private cArrow LoadArrow()
        {
            cArrow cReturnVal = new cArrow();
            OpenFileDialog bleh = new OpenFileDialog();

            string path = Directory.GetCurrentDirectory().ToString() + "\\Arrows\\";

            bleh.InitialDirectory = path;
            bleh.ShowDialog();
            
            if (bleh.FileName != "")
            {
                cReturnVal = cReturnVal.GetArrow(bleh.FileName);
            }
            return cReturnVal;
        }
    }
}
