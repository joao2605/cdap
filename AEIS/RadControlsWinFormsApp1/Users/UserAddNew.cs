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
    public partial class UserAddNew : UserControl
    {
        Utility UTL = new Utility();

        public UserAddNew()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aEISDataSet);

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            this.txtUsername.Text = "";
            this.txtPassword.Text = "";
            this.txtLastName.Text = "";
            this.txtFirstName.Text = "";
            this.txtEmail.Text = "";
            this.txtConPassword.Text = "";
            lstTitle.SelectedIndex = 0;
            lstUserLevels.SelectedIndex = 0;
            
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            
            byte[] userPhoto = UTL.ConvertImageToBytes(picUser.Image);
            
            User newUser = new User(lblUserID.Text, txtFirstName.Text, txtLastName.Text, lstTitle.SelectedText, lstUserLevels.SelectedText, txtUsername.Text, txtPassword.Text, txtEmail.Text, Convert.ToDateTime(lblCreatedDate.Value.ToShortDateString()), lblCreatedTime.Text,userPhoto);

            if(newUser.InsertUser(newUser))
            {
                MessageBox.Show("New user crated successfuly!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insert incompleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserAddNew_Load(object sender, EventArgs e)
        {
            resetForm();
        }

        public void resetForm()
        {
            
            lblUserID.Text= UTL.RandomString(1);
        }
    }
}
