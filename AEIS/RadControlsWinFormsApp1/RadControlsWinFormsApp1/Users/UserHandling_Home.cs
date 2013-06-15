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
    public partial class UserHandling_Home : UserControl
    {
        public UserHandling_Home()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            pnlMainUser.Controls.Clear();
            var AddNewUser = new UserAddNew();
            pnlMainUser.Controls.Add(AddNewUser);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            pnlMainUser.Controls.Clear();
            var EditUser = new UserEdit();
            pnlMainUser.Controls.Add(EditUser);
        }

        private void btnResetDeleteUser_Click(object sender, EventArgs e)
        {
            pnlMainUser.Controls.Clear();
            var DeleteResetUser = new UserDeleteReset();
            pnlMainUser.Controls.Add(DeleteResetUser);
        }

        private void btnAddUser_MouseHover(object sender, EventArgs e)
        {
            btnAddUser.ForeColor = Color.Orange;
        }

        private void btnAddUser_MouseLeave(object sender, EventArgs e)
        {
            btnAddUser.ForeColor = Color.Black;
        }

        private void btnEditUser_MouseHover(object sender, EventArgs e)
        {
            btnEditUser.ForeColor = Color.Orange;
        }

        private void btnEditUser_MouseLeave(object sender, EventArgs e)
        {
            btnEditUser.ForeColor = Color.Black;
        }

        private void btnResetDeleteUser_MouseHover(object sender, EventArgs e)
        {
            btnResetDeleteUser.ForeColor = Color.Orange;
        }

        private void btnResetDeleteUser_MouseLeave(object sender, EventArgs e)
        {
            btnResetDeleteUser.ForeColor = Color.Black;
        }

        private void btnUserDetailSum_Click(object sender, EventArgs e)
        {
            pnlMainUser.Controls.Clear();
            var UserSum = new UserSummary();
            pnlMainUser.Controls.Add(UserSum);
        }
    }
}
