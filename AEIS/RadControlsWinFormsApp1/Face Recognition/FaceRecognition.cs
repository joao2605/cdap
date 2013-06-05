using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AEIS
{
    public partial class FaceRecognition : UserControl
    {
        WebCam webcam;
        FaceReco FR = new FaceReco();

        public FaceRecognition()
        {
            InitializeComponent();
        }

        private void FaceRecognition_Load(object sender, EventArgs e)
        {
            //lable initilization
            lblHours.Region = Round.GetRoundedRegion(53, 53);
            lblMinits.Region = Round.GetRoundedRegion(53, 53);
            lblSeconds.Region = Round.GetRoundedRegion(53, 53);
            //initialize the camera input 
            webcam = new WebCam();
            webcam.InitializeWebCam(ref picCandidate);
            

        }

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            timShutter.Enabled = true;
        }

        private void timShutter_Tick(object sender, EventArgs e)
        {
            emguImgFace.Image = FR.FaceDetection((Image)picCandidate.Image);
        }

        private void radGroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            webcam.Continue();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //start the camera
            webcam.Start();

            btnOff.Enabled = true;
            btnPause.Enabled = true;
            btnDetection.Enabled = true;
        }

        private void dtnDetection_Click(object sender, EventArgs e)
        {
            timShutter.Enabled = true;
        }
    }
}
