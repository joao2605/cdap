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
    public partial class CandidateAdd : UserControl
    {
        string file = "";
        string candidateID = "1504";

        public CandidateAdd()
        {
            InitializeComponent();
        }

        private void AddCandidate_Load(object sender, EventArgs e)
        {
            //load values to Examination ID combo box from database  
            DataSet dsTitle = DB_Connect.ExecuteQuery("SELECT DISTINCT title_id, title_name FROM title_tab ");

            ddlTitle.DataSource = dsTitle.Tables[0];
            ddlTitle.DisplayMember = "title_name";
            ddlTitle.ValueMember = "title_id";
            //ddlTitle.SelectedIndex = -1;              
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(txtID.Text.ToString());
            string fullName = txtFullName.Text.ToString();
            string nameInitials = txtNameInitials.Text.ToString();

            int titleId = int.Parse(ddlTitle.SelectedItem.Value.ToString());
           
           // DataSet dsTitleId = DB_Connect.ExecuteQuery("SELECT title_id FROM title_tab WHERE title_name = '"+ titleName +"'");
           //int titleId = int.Parse(dsTitleId.Tables[0].Rows[0][0].ToString());

            string nationality = txtNationality.Text.ToString();
            DateTime dob = dtpDOB.Value;
            string nic = txtNIC.Text.ToString();
            string addr_l1 = txtAddrL1.Text.ToString();
            string addr_l2 = txtAddrL2.Text.ToString();
            string addr_l3 = txtAddrL3.Text.ToString();
            string telNo = txtTelNo.Text.ToString();
            string email = txtEmail.Text.ToString();
            string img = file;

            char gender;

            bool isChecked = rbFemale.IsChecked;
            if (isChecked)
                gender = 'F';
            else
                gender = 'M';


            Candidate c = new Candidate(fullName, nameInitials, titleId, nationality, nic, dob, gender, addr_l1, addr_l2, addr_l3, telNo, email, img);

            try
            {
                c.insertCandidate(c);
                MessageBox.Show("Success");
                resetFields();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            Photos PH = new Photos("1602");
            PH.Show();

        }

        private void resetFields()
        {
            txtFullName.Text = "";
            txtNameInitials.Text = "";
            ddlTitle.SelectedIndex = -1;  
            txtNationality.Text = "";

            DateTime today = DateTime.Today;
            dtpDOB.Value = today;

            txtNIC.Text = "";
            txtAddrL1.Text = "";
            txtAddrL2.Text = "";
            txtAddrL3.Text = "";
            txtTelNo.Text = "";
            txtEmail.Text = "";
            //rbFemale.IsChecked = false;
            //rbMale.IsChecked = false;
            //pnlPhoto.BackgroundImage = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.ImageLocation = Application.StartupPath + "/TrainedFaces/face_" + candidateID + "_1.bmp";
                pictureBox2.ImageLocation = Application.StartupPath + "/TrainedFaces/face_" + candidateID + "_2.bmp";
                pictureBox3.ImageLocation = Application.StartupPath + "/TrainedFaces/face_" + candidateID + "_3.bmp";
                pictureBox4.ImageLocation = Application.StartupPath + "/TrainedFaces/face_" + candidateID + "_4.bmp";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image loading Error..!");
            }
        }
    }
}
