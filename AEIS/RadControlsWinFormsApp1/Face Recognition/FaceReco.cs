using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Windows.Forms;


namespace AEIS
{
    class FaceReco
    {
        public Image<Gray, byte> result;
        public Image<Gray, byte> gray = null;
        //Load haarcascades for face detection
        HaarCascade face;

        public Image<Bgr, Byte> FaceDetection(Image Image)
        {
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            Utility UTl = new Utility();            

            //Get the current frame form capture device
            Image<Bgr, Byte> currentFrame = UTl.ImageToBgrByte(Image);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face,1.2,10,Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,new Size(20, 20));

            //Action for element detected        
            try
            {
                MCvAvgComp f = facesDetected[0][0];
           
            result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //draw the face detected in the 0th (gray) channel with blue color
            currentFrame.Draw(f.rect, new Bgr(Color.GreenYellow), 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Camera Error: Empty frames arrived. "+ex.Message.ToString());
                
            }
            return currentFrame;
        }

    }
}
