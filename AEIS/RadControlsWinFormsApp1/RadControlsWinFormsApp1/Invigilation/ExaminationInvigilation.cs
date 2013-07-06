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
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using Emgu.CV.VideoSurveillance;
using System.Xml.Linq;
using System.Collections;

namespace AEIS
{
    public partial class ExaminationInvigilation : UserControl
    {

        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int t;

        DataSet dsPos = null;
        bool displayPosNum = true;

        private MotionHistory _motionHistory;
        private IBGFGDetector<Bgr> _forgroundDetector;

        VideoWriter captureOutput; //save video
        XDocument xdoc; //xml reading

        Queue<int> motionQueue = new Queue<int>(100);
        Queue<int> helpQueue = new Queue<int>(100);
        private int examid = -1;
        bool green1, green2, green3, green4, red1, red2, red3, red4 = false;
        int green1cnt, green2cnt, green3cnt, green4cnt, red1cnt, red2cnt, red3cnt, red4cnt = 0;
        public static bool showNames = true;
        public static bool showPos = true;
        public static bool showHand = true;
        public static bool showMotion = false;
        public static bool showGridLines = true;
        public static bool recordVideo = false;
        public static int  severetyThreshold = 30;

        static string path = "C:\\Users\\NEON\\Desktop\\";
        int excnt = 0;
        string[] vidlist = { path+"vids\\MVI_3649_1_2.avi",
                            path+"vids\\MVI_3649_1_5.avi",
                            path+"vids\\MVI_3649_1_3.avi",                          
                            path+"vids\\MVI_3649_1_6.avi",
                            path+"vids\\MVI_3649_1_2.avi",
                            path+"vids\\MVI_3649_1_5.avi",
                            path+"vids\\MVI_3649_1_3.avi",                          
                            path+"vids\\MVI_3649_1_6.avi",
                            path+"vids\\MVI_3649_1_2.avi",
                            path+"vids\\MVI_3649_1_5.avi",
                            path+"vids\\MVI_3649_1_3.avi",                          
                            path+"vids\\MVI_3649_1_6.avi",
                            path+"vids\\MVI_3649_1_2.avi",
                            path+"vids\\MVI_3649_1_5.avi",
                            path+"vids\\MVI_3649_1_3.avi",                          
                            path+"vids\\MVI_3649_1_6.avi",
                            path+"vids\\MVI_3649_1_4.avi",
                            };

        public ExaminationInvigilation()
        {
            InitializeComponent();
            //Load haarcascades for hand detection
            face = new HaarCascade(path + "haars\\haarcascade_hand3.xml");

            DataSet ds = DB_Connect.ExecuteQuery("SELECT E.exam_id , S.subject_name FROM examination_tab E LEFT JOIN subject_tab S ON E.exam_subject_id = S.subject_id");
            cbExam.DataSource = ds.Tables[0];
            cbExam.DisplayMember = "subject_name";
            cbExam.ValueMember = "exam_id";


            dsPos = DB_Connect.ExecuteQuery("SELECT HP.position_id, HP.pos_x, HP.pos_y , C.candidate_name_initials FROM examination_tab E LEFT JOIN hall_position HP ON E.exam_hall_id = HP.hall_id LEFT JOIN candidate_position CP ON HP.position_id = CP.position_id AND E.exam_id = CP.exam_id LEFT JOIN candidate_tab C ON CP.candidate_id = C.candidate_id WHERE E.exam_id = 8");


        }


        void FrameGrabber(object sender, EventArgs e)
        {
            try
            {
                //Get the current frame form capture device
                currentFrame = grabber.QueryFrame().Resize(520, 340, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            }
            catch (NullReferenceException e1)
            {
                _motionHistory = new MotionHistory(2.0, 0.05, 0.5);
                _forgroundDetector = null;
                motionQueue.Clear(); helpQueue.Clear();
                grabber = new Capture(vidlist[excnt]);
                excnt++;
                if (excnt == 5) { excnt = 0; }
                currentFrame = grabber.QueryFrame().Resize(520, 340, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                green1= false;green2= false;green3= false;green4= false;
                red1= false;red2 = false;red3 = false;red4 = false;
            }

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,
          10,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {

                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //MessageBox.Show("wiidth " + f.rect.Width + " height " + f.rect.Height + " area " + f.rect.Width * f.rect.Height);
                if (f.rect.Width > 80) continue;
                
                //draw the face detected in the 0th (gray) channel with blue color
                if(showHand)
                currentFrame.Draw(f.rect, new Bgr(Color.LightGreen), 2);

                int nearespos = nearestPosition(f.rect.X, f.rect.Y);                


                if (helpQueue.ToArray().ToList().IndexOf(nearespos) == -1)
                {
                    // lbAlerts.Items.Add("Help request at #" + nearespos.ToString());

                    dgAlerts.Rows.Add("Help Request", nearespos.ToString());
                    DB_Connect.InsertQuery("INSERT INTO alert_tab(exam_id,position_id,alert_type,alert_time) VALUES(" + examid + "," + nearespos.ToString() + ",'H','" + DateTime.Now + "')");
                    dgAlerts.FirstDisplayedScrollingRowIndex = dgAlerts.RowCount - 1;

                    if (nearespos == 1) green1 = true;
                    else if (nearespos == 2) green2 = true;
                    else if (nearespos == 3) green3 = true;
                    else if (nearespos == 4) green4 = true;

                    if (helpQueue.Count == 10)
                    {
                        helpQueue.Dequeue();
                        helpQueue.Enqueue(nearespos);
                    }
                    else
                    {
                        helpQueue.Enqueue(nearespos);
                    }
                }



            }


            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = ProcessFrame(currentFrame);

            if (captureOutput == null && xdoc.Descendants("RecordVideo").First().Value == "1")
            {
                captureOutput = new VideoWriter(@"video" + DateTime.Now.Minute.ToString() + ".avi", (int)grabber.GetCaptureProperty(CAP_PROP.CV_CAP_PROP_FOURCC), 15, 520, 340, true);
            }

            if (currentFrame != null && xdoc.Descendants("RecordVideo").First().Value == "1")
            {
                captureOutput.WriteFrame<Bgr, Byte>(currentFrame);
            }


        }

        private int nearestPosition(int x, int y)
        {

            int nearest = 0;
            double shortestDistance = 100000000000;
            for (int i = 0; i < dsPos.Tables[0].Rows.Count; i++)
            {
                double distance;
                //distance = Math.Sqrt(Math.Pow(x - PointArray[i].X, 2) + Math.Pow(y - PointArray[i].Y, 2));
                distance = Math.Sqrt(Math.Pow(x - int.Parse(dsPos.Tables[0].Rows[i][1].ToString()), 2) + Math.Pow(y - int.Parse(dsPos.Tables[0].Rows[i][2].ToString()), 2));

                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    nearest = int.Parse(dsPos.Tables[0].Rows[i][0].ToString());
                }
            }
            return nearest;
        }


        //motion detection processing
        private Image<Bgr, Byte> ProcessFrame(Image<Bgr, Byte> image)
        {

            // using (Image<Bgr, Byte> image = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC))
            using (MemStorage storage = new MemStorage()) //create storage for motion components
            {
                if (_forgroundDetector == null)
                {
                    //_forgroundDetector = new BGCodeBookModel<Bgr>();
                    // _forgroundDetector = new FGDetector<Bgr>(Emgu.CV.CvEnum.FORGROUND_DETECTOR_TYPE.FGD);
                 
                        _forgroundDetector = new BGStatModel<Bgr>(image, Emgu.CV.CvEnum.BG_STAT_TYPE.FGD_STAT_MODEL);
                   
                }

                _forgroundDetector.Update(image);

                //    imageBoxFrameGrabber.Image = image;

                //update the motion history
                _motionHistory.Update(_forgroundDetector.ForgroundMask);

                #region get a copy of the motion mask and enhance its color
                double[] minValues, maxValues;
                Point[] minLoc, maxLoc;
                _motionHistory.Mask.MinMax(out minValues, out maxValues, out minLoc, out maxLoc);
                Image<Gray, Byte> motionMask = _motionHistory.Mask.Mul(255.0 / maxValues[0]);
                #endregion

                //create the motion image 
                Image<Bgr, Byte> motionImage = new Image<Bgr, byte>(motionMask.Size);
                //display the motion pixels in blue (first channel)
                motionImage[0] = motionMask;

                //Threshold to define a motion area, reduce the value to detect smaller motion
                double minArea = 100;

                storage.Clear(); //clear the storage
                Seq<MCvConnectedComp> motionComponents = _motionHistory.GetMotionComponents(storage);

                if (showGridLines)
                {
                    LineSegment2D line = new LineSegment2D(new Point(0, 169), new Point(520, 169));
                    LineSegment2D line2 = new LineSegment2D(new Point(259, 0), new Point(259, 340));

                    image.Draw(line, new Bgr(Color.White), 2);
                    image.Draw(line2, new Bgr(Color.White), 2);
                }


                if (displayPosNum)
                {
                    for (int i = 0; i < dsPos.Tables[0].Rows.Count; i++)
                    {
                        if(showPos)
                        image.Draw("# " + dsPos.Tables[0].Rows[i][0].ToString(), ref font, new Point(int.Parse(dsPos.Tables[0].Rows[i][1].ToString()) - 120, int.Parse(dsPos.Tables[0].Rows[i][2].ToString()) - 50), new Bgr(Color.Yellow));
                        if(showNames)
                        image.Draw(dsPos.Tables[0].Rows[i][3].ToString(), ref font, new Point(int.Parse(dsPos.Tables[0].Rows[i][1].ToString()) - 120, int.Parse(dsPos.Tables[0].Rows[i][2].ToString()) - 70), new Bgr(Color.Yellow));

                    }
                }


                if (red1 && red1cnt < 100)
                {
                    red1cnt++;
                    image.Draw(new Rectangle(0, 0, 255, 165), new Bgr(Color.Red), 3);

                    if (red1cnt == 99)
                    {
                        red1 = false;
                        red1cnt = 0;
                    }
                }
                if (red2 && red2cnt < 100)
                {
                    red2cnt++;
                    image.Draw(new Rectangle(262, 0, 257, 167), new Bgr(Color.Red), 3);


                    if (red2cnt == 99)
                    {
                        red2 = false;
                        red2cnt = 0;
                    }
                }
                if (red3 && red3cnt < 100)
                {
                    red3cnt++;
                    image.Draw(new Rectangle(0, 170, 260, 170), new Bgr(Color.Red), 3);


                    if (red3cnt == 99)
                    {
                        red3 = false;
                        red3cnt = 0;
                    }
                }
                if (red4 && red4cnt < 100)
                {
                    red4cnt++;
                    image.Draw(new Rectangle(260, 170, 260, 170), new Bgr(Color.Red), 3);


                    if (red4cnt == 99)
                    {
                        red4 = false;
                        red4cnt = 0;
                    }
                }


                if (green1 && green1cnt < 200)
                {
                    green1cnt++;
                    image.Draw(new Rectangle(0, 0, 255, 165), new Bgr(Color.Green), 3);

                    if (green1cnt == 199)
                    {
                        green1 = false;
                        green1cnt = 0;
                    }
                }
                if (green2 && green2cnt < 200)
                {
                    green2cnt++;
                    image.Draw(new Rectangle(262, 0, 257, 167), new Bgr(Color.Green), 3);


                    if (green2cnt == 199)
                    {
                        green2 = false;
                        green2cnt = 0;
                    }
                }
                if (green3 && green3cnt < 200)
                {
                    green3cnt++;
                    image.Draw(new Rectangle(0, 170, 260, 170), new Bgr(Color.Green), 3);


                    if (green3cnt == 199)
                    {
                        green3 = false;
                        green3cnt = 0;
                    }
                }
                if (green4 && green4cnt < 200)
                {
                    green4cnt++;
                    image.Draw(new Rectangle(260, 170, 260, 170), new Bgr(Color.Green), 3);


                    if (green4cnt == 199)
                    {
                        green4 = false;
                        green4cnt = 0;
                    }
                }

                //iterate through each of the motion component
                foreach (MCvConnectedComp comp in motionComponents)
                {
                    //reject the components that have small area;
                    if (comp.area < minArea) continue;


                    // find the angle and motion pixel count of the specific area
                    double angle, motionPixelCount;

                    _motionHistory.MotionInfo(comp.rect, out angle, out motionPixelCount);


                    //if (motionPixelCount > 100000) { image.Draw(l5 , new Bgr(Color.Red), 10);  } else { image.Draw(l5 , new Bgr(Color.Green), 10);  }
                    //reject the area that contains too few motion
                    // if (motionPixelCount < comp.area * 0.8) continue;
                    if (motionPixelCount < comp.area * 0.05) continue;

                    int nearpos = nearestPosition(comp.rect.X, comp.rect.Y);
                    //if (1000 > comp.area) continue;

                    //Draw each individual motion in red
                    //  DrawMotion(motionImage, comp.rect, angle, new Bgr(Color.Red));
                    if (nearpos == 3 && comp.area < 500) continue;
                    if (nearpos == 4 && comp.area < 500) continue;

                    if (comp.rect.X > 60 && comp.rect.Y > 60)
                    {
                        if (motionQueue.Count == 100)
                        {
                            motionQueue.Dequeue();
                            motionQueue.Enqueue(nearpos);

                        }
                        else
                        {
                            motionQueue.Enqueue(nearpos);
                        }



                       // LineSegment2D l5 = new LineSegment2D(new Point(comp.rect.X, comp.rect.Y), new Point(comp.rect.X, comp.rect.Y));
                       // image.Draw(l5, new Bgr(Color.Red), 10);
                      //  image.Draw(comp.area.ToString(), ref font, new Point(comp.rect.X, comp.rect.Y), new Bgr(Color.LightGreen));
                        if(showMotion)
                        image.Draw(comp.rect, new Bgr(Color.Yellow), 2);

                    }



                }

                // find and draw the overall motion angle
                double overallAngle, overallMotionPixelCount;
                _motionHistory.MotionInfo(motionMask.ROI, out overallAngle, out overallMotionPixelCount);
                // DrawMotion(motionImage, motionMask.ROI, overallAngle, new Bgr(Color.Green));

                //Display the amount of motions found on the current image
                //   UpdateText(String.Format("Total Motions found: {0}; Motion Pixel count: {1}", motionComponents.Total, overallMotionPixelCount));

                //Display the image of the motion
                // imageBoxFrameGrabber.Image = motionImage;  ///motion image

                return image;
            }
        }



        private void ExaminationInvigilation_Load(object sender, EventArgs e)
        {
            //lable initilization
            lblHours.Region = Round.GetRoundedRegion(53, 53);
            lblMinits.Region = Round.GetRoundedRegion(53, 53);
            lblSeconds.Region = Round.GetRoundedRegion(53, 53);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            xdoc = XDocument.Load("AEISConfig.xml");

            grabber = new Capture(path + "vids\\MVI_3649_1_1.avi");


            // grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            button1.Enabled = false;


            ///motion detection start
            if (grabber == null)
            {
                try
                {
                    grabber = new Capture();
                }
                catch (NullReferenceException excpt)
                {   //show errors if there is any
                    MessageBox.Show(excpt.Message);
                }
            }

            if (grabber != null) //if camera capture has been successfully created
            {
                _motionHistory = new MotionHistory(
                    2.0, //in second, the duration of motion history you wants to keep
                    0.05, //in second, parameter for cvCalcMotionGradient
                    0.5); //in second, parameter for cvCalcMotionGradient

                //Application.Idle += ProcessFrame;
            }
            ///motion detection end
        }


        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            this.lblHours.Text = DateTime.Now.ToString("hh");
            lblMinits.Text = DateTime.Now.ToString("mm");
            lblSeconds.Text = DateTime.Now.ToString("ss");
            lblTt.Text = DateTime.Now.ToString("tt");
        }

        private void imageBoxFrameGrabber_Click(object sender, EventArgs e)
        {
            if (imageBoxFrameGrabber.Width != 800)
            {
                radGroupBox2.Visible = false;
                radGroupBox3.Visible = false;
                radGroupBox7.Visible = false;
                radGroupBox4.Width = 810;
                radGroupBox4.Height = 610;
                imageBoxFrameGrabber.Width = 800;
                imageBoxFrameGrabber.Height = 600;
                imageBoxFrameGrabber.SetZoomScale(1.5, new Point(0, 0));
                dgAlerts.Visible = false;
            }
            else
            {
                radGroupBox2.Visible = true;
                radGroupBox3.Visible = true;
                radGroupBox7.Visible = true;
                radGroupBox4.Width = 542;
                radGroupBox4.Height = 357;
                imageBoxFrameGrabber.Width = 526;
                imageBoxFrameGrabber.Height = 321;
                imageBoxFrameGrabber.SetZoomScale(1.0, new Point(0, 0));
                dgAlerts.Visible = true;
            }
        }

        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            //foreach (int i in motionQueue.GroupBy(x => x).OrderByDescending(g => g.Count()).Select(g => g.Key) )
            var selectedCategories = motionQueue.GroupBy(x => x).OrderByDescending(g => g.Count()).Select(g => new { pos = g.Key, cnt = g.Count() });
            foreach (var pos in selectedCategories)
            {
                bool isAlert = false;
                if (severetyThreshold < pos.cnt) { isAlert = true; }
                if (isAlert)
                {
                    if (pos.pos == 1) red1 = true;
                    else if (pos.pos == 2) red2 = true;
                    else if (pos.pos == 3) red3 = true;
                    else if (pos.pos == 4) red4 = true;

                    //lbAlerts.Items.Add("Suspicious Act at #" + pos.pos.ToString());
                    dgAlerts.Rows.Add("Suspicious Act", pos.pos.ToString());

                    DB_Connect.InsertQuery("INSERT INTO alert_tab(exam_id,position_id,alert_type,alert_time) VALUES(" + examid + "," + pos.pos.ToString() + ",'S','" + DateTime.Now + "')");

                    dgAlerts.FirstDisplayedScrollingRowIndex = dgAlerts.RowCount - 1;
                }
                motionQueue.Clear();

            }

        }

        private void MinuteTimer_Tick(object sender, EventArgs e)
        {
            helpQueue.Clear();
        }

        private void cbExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView examDataView = (DataRowView)cbExam.SelectedItem;
            if (examDataView[0] != null)
            {

                examid = int.Parse(examDataView[0].ToString());
                DataSet ds = DB_Connect.ExecuteQuery("SELECT E.* FROM examination_tab E WHERE E.exam_id =" + examDataView[0].ToString());
               
                lblStartTimeVal.Text = ds.Tables[0].Rows[0][2].ToString();
                lblEndTimeVal.Text = ds.Tables[0].Rows[0][3].ToString();
              
            }

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radLabel4_Click(object sender, EventArgs e)
        {

        }

        private void radGroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radLabel14_Click(object sender, EventArgs e)
        {

        }

        private void radLabel15_Click(object sender, EventArgs e)
        {

        }

        private void radLabel13_Click(object sender, EventArgs e)
        {

        }

        private void radLabel11_Click(object sender, EventArgs e)
        {

        }

        private void radGroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void radGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {

        }

        private void radRadioButton2_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {

        }

        private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            new InvigilationSettings().Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {

        }

        private void radLabel10_Click(object sender, EventArgs e)
        {

        }

        private void radLabel9_Click(object sender, EventArgs e)
        {

        }

        private void radLabel8_Click(object sender, EventArgs e)
        {

        }

        private void radLabel7_Click(object sender, EventArgs e)
        {

        }

        private void radLabel6_Click(object sender, EventArgs e)
        {

        }

        private void radLabel5_Click(object sender, EventArgs e)
        {

        }

        private void radLabel3_Click(object sender, EventArgs e)
        {

        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void radLabel17_Click(object sender, EventArgs e)
        {

        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void radTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void radTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radLabel12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            grabber.Dispose();
            
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            new AlertLog(examid).Show();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            new SeatingPositions(examid).Show();
        }

        private void severetyTrack_ValueChanged(object sender, EventArgs e)
        {
            severetyThreshold = severetyTrack.Value;
        }

       





    }
}
