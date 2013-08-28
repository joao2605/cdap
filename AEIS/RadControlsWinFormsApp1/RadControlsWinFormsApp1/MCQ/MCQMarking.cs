using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using AForge.Math.Geometry;
using System.IO;
using System.Xml;
using OMR;
using OMR.XML;


namespace AEIS
{
    public partial class MCQMarking : UserControl
    {
        string paper = "";
        string file = "";
        int examId;
        int markingSchemeId;
        OpticalReader rr = new OpticalReader();
        int candidateId;

        public MCQMarking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load values to Examination ID combo box from database  
            DataSet dsMarks = DB_Connect.ExecuteQuery("SELECT DISTINCT e.exam_id, s.subject_name, e.exam_date,  (s.subject_name + ' - ' + CAST(e.exam_date as varchar(10) ) ) AS displayValue FROM subject_tab s, examination_tab e WHERE s.subject_id = e.exam_subject_id ORDER BY e.exam_id desc;");
                   
            ddlExamId.DataSource = dsMarks.Tables[0];
            ddlExamId.DisplayMember = "displayValue";
            ddlExamId.ValueMember = "exam_id";
            ddlExamId.SelectedIndex = -1;

           
        }

     
        private void radButton1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate(); Application.DoEvents();
            Rectangle[] Blocks = new Rectangle[]
            {
                OMRSheetReader.GetSheetPropertyLocation("sheets", OMREnums.OMRSheet.A550, OMREnums.OMRProperty.tensBlock1),
                OMRSheetReader.GetSheetPropertyLocation("sheets", OMREnums.OMRSheet.A550, OMREnums.OMRProperty.tensBlock2),
                OMRSheetReader.GetSheetPropertyLocation("sheets", OMREnums.OMRSheet.A550, OMREnums.OMRProperty.tensBlock3),
                OMRSheetReader.GetSheetPropertyLocation("sheets", OMREnums.OMRSheet.A550, OMREnums.OMRProperty.tensBlock4)
            };

            List<Bitmap[]> bmps = new List<Bitmap[]>();
            for (int i = 0; i < 4; i++)
            {
                bmps.Add(rr.SliceOMarkBlock(panel1.BackgroundImage, Blocks[i], 10));
            }
            
            DataSet dsMarks = DB_Connect.ExecuteQuery("SELECT a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40 FROM mcq_marking_scheme_tab WHERE marking_scheme_id = '" + markingSchemeId + "';");
            
            int[] ans_arr;
            ans_arr = new int[40];
            string img_path = txtFileName.Text.ToString();
            
            int cnt = 0;
            int result = 0;
       
                foreach (Bitmap[] blk in bmps)
                {
                    foreach (Bitmap line in blk)
                    {
                       
                        ans_arr[cnt] = rr.rateSlice(line, 5);
                        
                      
                        if (ans_arr[cnt] == int.Parse( dsMarks.Tables[0].Rows[0][cnt].ToString() ) )
                        {
                            result++;
                        }

                        
                        cnt++;
                      
                    }
                }

          
            DB_Connect.InsertQuery("INSERT INTO mcq_answers_tab(candidate_id,exam_id,answersheet_path,a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12,a13,a14,a15,a16,a17,a18,a19,a20,a21,a22,a23,a24,a25,a26,a27,a28,a29,a30,a31,a32,a33,a34,a35,a36,a37,a38,a39,a40,total_mark) VALUES('"+ candidateId +"','"+ examId +"','" + img_path + "', " + ans_arr[0] + ", " + ans_arr[1] + ", " + ans_arr[2] + ", " + ans_arr[3] + "," + ans_arr[4] + "," + ans_arr[5] + "," + ans_arr[6] + "," + ans_arr[7] + "," + ans_arr[8] + "," + ans_arr[9] + "," + ans_arr[10] + "," + ans_arr[11] + "," + ans_arr[12] + "," + ans_arr[13] + "," + ans_arr[14] + "," + ans_arr[15] + "," + ans_arr[16] + "," + ans_arr[17] + "," + ans_arr[18] + "," + ans_arr[19] + "," + ans_arr[20] + ", " + ans_arr[21] + "," + ans_arr[22] + "," + ans_arr[23] + "," + ans_arr[24] + "," + ans_arr[25] + "," + ans_arr[26] + "," + ans_arr[27] + "," + ans_arr[28] + "," + ans_arr[29] + "," + ans_arr[30] + "," + ans_arr[31] + "," + ans_arr[32] + "," + ans_arr[33] + "," + ans_arr[34] + "," + ans_arr[35] + "," + ans_arr[36] + "," + ans_arr[37] + "," + ans_arr[38] + "," + ans_arr[39] + ","+result+");");
           
          

            lblResult.Text = result.ToString();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {

            candidateId = int.Parse(rr.getRegNumOfSheet(panel1.BackgroundImage, OMREnums.OMRSheet.A550, "sheets.xml", false).ToString());
            lblRegNo.Text = candidateId.ToString();

                        
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //prompts the user to open a file
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog. indicate the return value of the dialog box
            if (result == DialogResult.OK) // Test result. if the OK button is pressed
            {
                string file = openFileDialog1.FileName; //set the string containing the file name selected in the file dialog box

                txtFileName.Text = file.ToString(); //display the file path in the textbox

                paper = file;
                try
                {
                    string text = File.ReadAllText(file); //opens a text file, read all lines in the text file and then closes it
                    size = text.Length;
                    
                }
                catch (IOException)
                {
                }
                panel1.BackgroundImage = System.Drawing.Image.FromFile(paper); //sets the background image of the panel

                this.Invalidate(); //redraw the control
            }

           
                examId = int.Parse(ddlExamId.SelectedValue.ToString()); //selected exam id from the combo box
        

                DataSet dsM = DB_Connect.ExecuteQuery("SELECT marking_scheme_id FROM mcq_marking_scheme_tab WHERE exam_id = '" + examId + "';");

                markingSchemeId = int.Parse(dsM.Tables[0].Rows[0][0].ToString()); //get the marking scheme id corresponding to the selected exam id from the database
            
            
 
        }

       
       
    }
}
