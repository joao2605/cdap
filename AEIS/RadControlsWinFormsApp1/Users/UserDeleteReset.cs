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
    public partial class UserDeleteReset : UserControl
    {
        public UserDeleteReset()
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
            lblFirstName.Text = gridUsers.Rows[e.RowIndex].Cells["first_name"].Value.ToString();
            lblLastName.Text = gridUsers.Rows[e.RowIndex].Cells["last_name"].Value.ToString();
            lblTitle.Text = gridUsers.Rows[e.RowIndex].Cells["title"].Value.ToString();
            lblUserLevel.Text = gridUsers.Rows[e.RowIndex].Cells["user_level"].Value.ToString();
            lblUsername.Text = gridUsers.Rows[e.RowIndex].Cells["user_name"].Value.ToString();
            lblEmail.Text = gridUsers.Rows[e.RowIndex].Cells["email"].Value.ToString();
            lblCreatedDate.Text = gridUsers.Rows[e.RowIndex].Cells["created_date"].Value.ToString();
            lblCreatedTime.Text = gridUsers.Rows[e.RowIndex].Cells["created_time"].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            User usr = new User();

            if (usr.DeleteUser(lblUserID.Text))
            {
                MessageBox.Show("User Removed successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Deletion incompleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
