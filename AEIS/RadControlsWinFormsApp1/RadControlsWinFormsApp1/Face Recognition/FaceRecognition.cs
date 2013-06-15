using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace AEIS
{
    public partial class FaceRecognition : UserControl
    {
        WebCam webcam;
        FaceReco FR = new FaceReco();
        Capture grabber;
        public Image<Gray, byte> result;
        public Image<Gray, byte> gray = null;
        //Load haarcascades for face detection
        HaarCascade face;
        Image<Bgr, byte> currentFrame;

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
            //webcam.InitializeWebCam(ref picCandidate);
            

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
            //emguImgFace.Image = FR.FaceDetection((Image)picCandidate.Image);
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
            //webcam.Start();

            //btnOff.Enabled = true;
            //btnPause.Enabled = true;
            //btnDetection.Enabled = true;

            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
        }

        private void dtnDetection_Click(object sender, EventArgs e)
        {
            timShutter.Enabled = true;
        }

        void FrameGrabber(object sender, EventArgs e)
        {
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //Utility UTl = new Utility();            

            //Get the current frame form capture device
            //Image<Bgr, Byte> currentFrame = UTl.ImageToBgrByte(Image);
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            //Action for element detected        
            try
            {
                MCvAvgComp f = facesDetected[0][0];

                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.White), 2);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Camera Error: Empty frames arrived" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            emguImgFace.Image = currentFrame;
        }

        private void timHome_Tick(object sender, EventArgs e)
        {
            this.lblHours.Text = DateTime.Now.ToString("hh");
            this.lblMinits.Text = DateTime.Now.ToString("mm");
            this.lblSeconds.Text = DateTime.Now.ToString("ss");
            this.lblTt.Text = DateTime.Now.ToString("tt");
        }
    }
}
