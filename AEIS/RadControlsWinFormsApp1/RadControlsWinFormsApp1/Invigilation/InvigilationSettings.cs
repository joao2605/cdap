using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AEIS
{
    

    public partial class InvigilationSettings : Telerik.WinControls.UI.ShapedForm
    {
       


        public InvigilationSettings()
        {
            InitializeComponent();       

            
        }

     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radLabel4_Click(object sender, EventArgs e)
        {

        }

        private void radTrackBar3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void radLabel17_Click(object sender, EventArgs e)
        {

        }

        private void radTrackBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void radTrackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SeatingPositions_Load(object sender, EventArgs e)
        {
            if (ExaminationInvigilation.showNames) {
                checkBox1.Checked = true;
            }

            if (ExaminationInvigilation.showPos)
            {
                checkBox2.Checked = true;
            }

            if (ExaminationInvigilation.showMotion)
            {
                checkBox3.Checked = true;
            }

            if (ExaminationInvigilation.recordVideo)
            {
                checkBox4.Checked = true;
            }

            if (ExaminationInvigilation.showHand)
            {
                checkBox5.Checked = true;
            }

            if (ExaminationInvigilation.showGridLines)
            {
                checkBox6.Checked = true;
            }
           
            label1.Text = ExaminationInvigilation.severetyThreshold.ToString();

        }

        private void radButton2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { ExaminationInvigilation.showNames = true; } else { ExaminationInvigilation.showNames = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) { ExaminationInvigilation.showPos = true; } else { ExaminationInvigilation.showPos = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) { ExaminationInvigilation.showMotion = true; } else { ExaminationInvigilation.showMotion = false; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true) { ExaminationInvigilation.recordVideo = true; } else { ExaminationInvigilation.recordVideo = false; }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true) { ExaminationInvigilation.showHand = true; } else { ExaminationInvigilation.showHand = false; }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true) { ExaminationInvigilation.showGridLines = true; } else { ExaminationInvigilation.showGridLines = false; }
        }

        private void severetyTrack_ValueChanged(object sender, EventArgs e)
        {
            ExaminationInvigilation.severetyThreshold = severetyTrack.Value;
            label1.Text = ExaminationInvigilation.severetyThreshold.ToString();
        }

    }
}