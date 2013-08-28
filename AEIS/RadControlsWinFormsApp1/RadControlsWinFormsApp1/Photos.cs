using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.IO;

namespace AEIS
{
    public partial class Photos : Telerik.WinControls.UI.ShapedForm
    {
        WebCam webcam;
        FaceReco FR = new FaceReco();
        Capture grabber;
        public Image<Gray, byte> result;
        public Image<Gray, byte> gray = null;
        //Load haarcascades for face detection
        HaarCascade face;
        Image<Bgr, Byte> currentFrame;
        Image<Gray, byte>TrainedFace = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        //thread handling
        EventHandler capture1;
        string candidate_ID;

        public Photos(string candidateID)
        {
            this.candidate_ID = candidateID;
            InitializeComponent();
        }

        private void Photos_Load(object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Capture("video001.mp4");
            grabber.QueryFrame();
            //Initialize the FrameGraber event           

            capture1 = new EventHandler(FrameGrabber);
            Application.Idle += capture1;


            lblCanddate.Text = candidate_ID;
             
        }
        void FrameGrabber(object sender, EventArgs e)
        {
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //Utility UTl = new Utility();            

            //Get the current frame form capture device
            //Image<Bgr, Byte> currentFrame = UTl.ImageToBgrByte(Image);
            try
            {
                currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            }
            catch (Exception exp)
            {
                grabber = new Capture("video001.mp4");
            }
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
            imgCameraView.Image = currentFrame;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            try
            {
                Application.Idle -= capture1;
                this.Dispose();
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Problem");
                this.Dispose();

            }
        }

        public void FillBoxByFace(ImageBox image)
        {
            //Get a gray frame from capture device
            gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face,1.2,10,Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                break;
            }

            //resize face detected image for force to compare the same size with the 
            //test image with cubic interpolation type method
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //trainingImages.Add(TrainedFace);
            //labels.Add(textBox1.Text);

            //Show face added in gray scale
            image.Image = TrainedFace;

        }

        private void btnCapture1_Click(object sender, EventArgs e)
        {
            FillBoxByFace(ImgOne);
        }

        private void btnCapture2_Click(object sender, EventArgs e)
        {
            FillBoxByFace(ImgTwo);
        }

        private void btnCapture3_Click(object sender, EventArgs e)
        {
            FillBoxByFace(ImgThree);
        }

        private void btnCapture4_Click(object sender, EventArgs e)
        {
            FillBoxByFace(ImgFour);
        }

        private void btnSaveImages_Click(object sender, EventArgs e)
        {
                        
            labels.Add(candidate_ID);
            labels.Add(candidate_ID);
            labels.Add(candidate_ID);
            labels.Add(candidate_ID);            

            trainingImages.Add((Image<Gray, byte>)ImgOne.Image);
            trainingImages.Add((Image<Gray, byte>)ImgTwo.Image);
            trainingImages.Add((Image<Gray, byte>)ImgThree.Image);
            trainingImages.Add((Image<Gray, byte>)ImgFour.Image);

            //Write the number of triained faces in a file text for further load
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

            //Write the labels of triained faces in a file text for further load
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face_"+candidate_ID+"_" + i + ".bmp");
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
            }

            try
            {
                Application.Idle -= capture1;
                this.Dispose();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Problem");
                this.Dispose();

            }
        }

        private void Photos_Leave(object sender, EventArgs e)
        {
            
        }

        private void radGroupBox4_Click(object sender, EventArgs e)
        {

        }
    }
}