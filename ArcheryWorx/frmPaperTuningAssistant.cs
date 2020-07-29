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
    public partial class frmPaperTuningAssistant : Form
    {
        private bool MainImage = false;
        public frmPaperTuningAssistant()
        {
            InitializeComponent();
        }

        private void SwapImages(PictureBox inPictureBox)
        {
            string ProblemDescription = null;
            string Tester = inPictureBox.Tag.ToString();
            switch (Tester)
            {
                case "Top":
                    ProblemDescription = "High Tear\r\nPossible Corrections :\r\nMove nock point down\r\nMove rest up\r\nDecrease launcher stiffness\r\nShorten arrow length if possible";
                    break;
                case "Center":
                    ProblemDescription = "Perfect!";
                    break;
                case "Bottom":
                    ProblemDescription = "Low Tear\r\nPossible Corrections :\r\nRaise nocking point\r\nStiffen launcher stiffness";
                    break;
                case "Left":
                    ProblemDescription = "Left Tear\r\nPossible Corrections :\r\nMove rest/center shot towards riser \r\n(right-handed bow)\r\nMove cable guard towards arrow (decrease load on cable guard)\r\nAdjust wheel lean\r\nUse stiffer arrow\r\nDecrease draw weight";
                    break;
                case "Right":
                    ProblemDescription = "Right Tear\r\nPossible Corrections :\r\nMove rest/center shot away from riser \r\n(right-handed bow)\r\nMove cable guard away from arrow (increase load on cable guard)\r\n- Adjust wheel lean";
                    break;
                default:
                    ProblemDescription = "Select the image that most closely resembles your current tear.";
                    break;
            }
            if (!MainImage)
            {
                MainPictureBox.Image = inPictureBox.Image;
                MainPictureBox.BringToFront();
            }            
            else
            {                
                MainPictureBox.Image = null;
                MainPictureBox.SendToBack();
            }
            MainPictureBox.Enabled = !MainPictureBox.Enabled;
            MainImage = !MainImage;
            txtSysDescription.Text = ProblemDescription;
        }

        private void PictureBoxCenter_Click(object sender, EventArgs e)
        {
            SwapImages(PictureBoxCenter);
        }

        private void PictureBoxTop_Click(object sender, EventArgs e)
        {
            SwapImages(PictureBoxTop);
        }

        private void PictureBoxBottom_Click(object sender, EventArgs e)
        {
            SwapImages(PictureBoxBottom);
        }

        private void PictureBoxLeft_Click(object sender, EventArgs e)
        {
            SwapImages(PictureBoxLeft);
        }

        private void PictureBoxRight_Click(object sender, EventArgs e)
        {
            SwapImages(PictureBoxRight);
        }

        private void MainPictureBox_Click(object sender, EventArgs e)
        {
            SwapImages(MainPictureBox);
        }

        private void PaperTuningAssistant_Load(object sender, EventArgs e)
        {
            txtSysDescription.Text = "Setup your test as follows\r\nSet your paper sheet 6 feet in front of you,\r\n then place your target 6 feet behind the paper test.\r\nJust make sure that your arrow will hit the target afterwards.";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
