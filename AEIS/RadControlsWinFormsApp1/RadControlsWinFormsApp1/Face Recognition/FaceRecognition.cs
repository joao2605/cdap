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
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace AEIS
{
    public partial class FaceRecognition : UserControl
    {
        
        FaceReco FR = new FaceReco();
        Capture grabber;
        public Image<Gray, byte> result;
        public Image<Gray, byte> gray = null;
        //Load haarcascades for face detection
        HaarCascade face;
        Image<Bgr, Byte> currentFrame;
        int ContTrain, NumLabels, t;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        //for candidate ID list
        List<string> validCandidates = new List<string>();
        string name= null;

        //-------------------------------inti
        DataSet nameList;
        DataSet canyInformation;


        Candidate Candy = new Candidate();
        EventHandler cameraIN;

        public FaceRecognition()
        {
            InitializeComponent();


            DataSet ds = DB_Connect.ExecuteQuery("SELECT E.exam_id , (S.subject_name +' '+CAST(E.exam_start_time as varchar(5) )+' - '+CAST(E.exam_end_time as varchar(5) ) ) AS subject_name FROM examination_tab E LEFT JOIN subject_tab S ON E.exam_subject_id = S.subject_id");
            cmbExam.DataSource = ds.Tables[0];
            cmbExam.DisplayMember = "subject_name";
            cmbExam.ValueMember = "exam_id";


            //ReadExisting();
           
        }

        public void ReadExisting()
        {
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/DBImages/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                //get the first argument
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/DBImages/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public void populateLists()
        {
            labels.Clear();
            trainingImages.Clear();

            //unknown detection
            for (int a = 1; a < 5; a++)
            {
                //fill lables list 4 times with id
                labels.Add("unknown");

                string LoadFaces = "face_" + "unknown" + "_" + a + ".bmp";
                try
                {
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Images not exist");
                }
            }


            string studentID;
            //get list of candidates on examination
            Candidate candi = new Candidate();
            string sub = cmbExam.SelectedValue.ToString();
            //Get Student Details

            nameList = candi.getCandidateList(Convert.ToInt32(sub));

            try
            {
                canyInformation = candi.getCandidateInfo(Convert.ToInt32(lblCandidateID));
            }
            catch (Exception e)
            {

            }


            ///---------------------------Face Detection--------------------------------------
            //number of students
            string stCount = nameList.Tables[0].Rows.Count.ToString();
            //run iteration for each candidate
            foreach (DataRow row in nameList.Tables[0].Rows)
            {
                //get candidate Id
                studentID = row[0].ToString();
                

                //fill trainedImages list from disk on id
                for (int a = 1; a < 5; a++)
                {
                    //fill lables list 4 times with id
                    labels.Add(studentID);
                
                    string LoadFaces = "face_"+studentID+"_"+ a + ".bmp";
                    try
                    {
                        trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Images not exist");
                        break;
                    }
                }

                
            }

            MessageBox.Show("Found : " + stCount+" students for "+cmbExam.SelectedText.ToString()+" examination","Data Population is Completed");   
        }

        private void FaceRecognition_Load(object sender, EventArgs e)
        {
            //lable initilization
            lblHours.Region = Round.GetRoundedRegion(53, 53);
            lblMinits.Region = Round.GetRoundedRegion(53, 53);
            lblSeconds.Region = Round.GetRoundedRegion(53, 53);
            
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
            
        }

        private void radGroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Idle -= cameraIN;
            btnStart.Enabled = true;
            btnOff.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            //btnOff.Enabled = true;
           btnStart.Enabled = false;
           btnOff.Enabled = true;

            //Initialize the capture device
           grabber = new Capture("video001.mp4");
            grabber.QueryFrame();
            //Initialize the FrameGraber event
                        
            cameraIN=new EventHandler(FrameGrabber2);
            Application.Idle += cameraIN;
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
            emguImgFace.Image=currentFrame;
        }

        private void timHome_Tick(object sender, EventArgs e)
        {
            this.lblHours.Text = DateTime.Now.ToString("hh");
            this.lblMinits.Text = DateTime.Now.ToString("mm");
            this.lblSeconds.Text = DateTime.Now.ToString("ss");
            this.lblTt.Text = DateTime.Now.ToString("tt");
        }

        private void FaceRecognition_Leave(object sender, EventArgs e)
        {
            Application.Idle -= cameraIN;
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        public void FrameGrabber2(object sender, EventArgs e)
        {
            NamePersons.Add("");

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
                grabber = new Capture("video002.mp4");
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


                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);

                    name = recognizer.Recognize(result);

                    //Draw the label for each face detected and recognized
                    //currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                }

                //NamePersons[t - 1] = name;
                NamePersons.Add("");


                                
            t = 0;

            //Names concatenation of persons recognized
            //for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            //{
            //    names = names + NamePersons[nnn] + ", ";
            //}
            //Show the faces procesed and recognized
            emguImgFace.Image = currentFrame;
            lblCandidateID.Text = name;
            name = "";
            //Clear the list(vector) of names
            NamePersons.Clear();

        }

        private void emguImgFace_Click(object sender, EventArgs e)
        {

        }

        //populate images from DB
        
       
        private void btnPopulate_Click_1(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            populateLists();
        }

        private void lblCandidateID_TextChanged(object sender, EventArgs e)
        {
            resetButtons();
            lblAuthanticity.Text = "";
            string candi_ID = "";
            int seatNo = 0;


            Candidate candi = new Candidate();
            //populate candidate information
            try
            {
                canyInformation = candi.getCandidateInfo(Convert.ToInt32(lblCandidateID.Text));
            }
            catch (Exception ex)
            {

            }
            try
            {
                foreach (DataRow rowCan in canyInformation.Tables[0].Rows)
                {
                    //get candidate Id
                    candi_ID = rowCan[0].ToString();

                    lblFullName.Text = rowCan[0].ToString();
                    lblInitName.Text = rowCan[1].ToString();
                    lbltitle.Text = rowCan[2].ToString();
                }
            }
            catch (Exception ex)
            {

            }

            //show seat allocation
            foreach (DataRow row in nameList.Tables[0].Rows)
            {
                //get candidate Id
                candi_ID = row[0].ToString();

                if (lblCandidateID.Text == candi_ID)
                {
                    seatNo = Convert.ToInt32(row[1]);
                }
            }

            switch (seatNo)
            {
                case 0:
                    break;
                case 1:
                    HighlightChair(chair01);
                    break;
                case 2:
                    HighlightChair(chair02);
                    break;
                case 3:
                    HighlightChair(chair03);
                    break;
                case 4:
                    HighlightChair(chair04);
                    break;
            }

            if (lblCandidateID.Text == "" || lblCandidateID.Text == "unknown")
            {
                lblAuthanticity.ForeColor = Color.Red;
                lblAuthanticity.Text = "Unauthorized";
            }
            else
            {
                lblAuthanticity.ForeColor = Color.Green;
                lblAuthanticity.Text = "Authorized";
            }

        }

        public void HighlightChair(Button btnChair)
        {
            btnChair.BackColor = Color.Orange;

        }

        public void resetButtons()
        {
            chair01.BackColor = Color.White;
            chair02.BackColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnAttMark_Click(object sender, EventArgs e)
        {

        }

        private void cmbExam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        
       
    }
}
