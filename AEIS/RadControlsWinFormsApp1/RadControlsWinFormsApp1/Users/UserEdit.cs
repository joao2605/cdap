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
    public partial class UserEdit : UserControl
    {
        public UserEdit()
        {
            InitializeComponent();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            User USR = new User();
            DataSet ds = USR.getUserList(txtUserID.Text);

            gridUsers.DataSource = ds.Tables["Users"].DefaultView;


        }

        private void gridUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblUserID.Text = gridUsers.Rows[e.RowIndex].Cells["user_id"].Value.ToString();
            txtFirstName.Text = gridUsers.Rows[e.RowIndex].Cells["first_name"].Value.ToString();
            txtLastName.Text = gridUsers.Rows[e.RowIndex].Cells["last_name"].Value.ToString();
            lblTitle.Text = gridUsers.Rows[e.RowIndex].Cells["title"].Value.ToString();
            lblUserLevel.Text = gridUsers.Rows[e.RowIndex].Cells["user_level"].Value.ToString();
            txtUserName.Text = gridUsers.Rows[e.RowIndex].Cells["user_name"].Value.ToString();
            txtEmailAdd.Text = gridUsers.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtPassword.Text = "";
            TxtConfPass.Text = "";
            lblDate.Text = gridUsers.Rows[e.RowIndex].Cells["created_date"].Value.ToString();
            lblTime.Text = gridUsers.Rows[e.RowIndex].Cells["created_time"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Utility utl = new Utility();
            byte[] photo = utl.ConvertImageToBytes(picUser.Image);

            User usr = new User(lblUserID.Text, txtFirstName.Text, txtLastName.Text, lblTitle.Text, lblUserLevel.Text, txtUserName.Text, txtPassword.Text, txtEmailAdd.Text, Convert.ToDateTime(lblDate.Text), lblTime.Text,photo);

            if (txtPassword.Text != "")
            {
                if (usr.UpdateUser(usr))
                {
                    MessageBox.Show("User Modification is successful!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Txt();
                }
                else
                {
                    MessageBox.Show("Modification Rejected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty password not allowed", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Txt()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            TxtConfPass.Text = "";
            txtUserName.Text = "";
            txtEmailAdd.Text = "";

        }
    }
}
