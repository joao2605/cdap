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
    public partial class UserSummary : UserControl
    {
        public UserSummary()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            User usr = new User();

            bool x = usr.sendMail("gsr.shyamike@gmail.com", "Working", "ABC", "123");
        }
    }
}
