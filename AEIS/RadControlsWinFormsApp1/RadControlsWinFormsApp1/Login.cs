using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AEIS
{
    public partial class Login : Telerik.WinControls.UI.ShapedForm
    {
        //SQL connection variable
        public SqlConnection connection;
        //Global variables
        User USR = new User();
        string password, userlevel,username;
        DateTime logDate, logTime;
        

        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if ((txtUserId.Text == ""||txtPassWord.Text==""))
            {
                MessageBox.Show("Text fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string EntUserID = txtUserId.Text;
                string EntPassword = txtPassWord.Text;

                try
                {
                    this.connection = DBHandler.getConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                if (connection.State.ToString() == "Closed")
                {
                    connection.Open();
                }
                
                DataSet DS = USR.getPassword(txtUserId.Text);

                foreach (DataRow row in DS.Tables[0].Rows)
                {
                    for (int i = 0; i < DS.Tables[0].Columns.Count; i++)
                    {
                        userlevel = row[0].ToString().Trim();
                        password = row[1].ToString().Trim();
                        username = row[2].ToString().Trim();
                    }
                   
                }

                if (EntPassword == password)
                {
                    logDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-ddThh:mm:sszzz"));
                    Main main = new Main(username,userlevel,txtUserId.Text, logDate);
                    main.Show();
                    this.Hide(); //DWHZYWAQSR 

                    if (USR.InsertLogRecord(txtUserId.Text, logDate))
                    {
                        alertLogTracker.ContentText = "Login Tracked : " + logDate;
                        alertLogTracker.Show();
                    }
                    else
                    {
                        alertLogTracker.ContentText = "Failure Occured ..!";
                        alertLogTracker.Show();
                    }

                                                                                                                                                                        

                }
                else
                {

                    MessageBox.Show("Incorrect LogIn Information!Please Re-Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}