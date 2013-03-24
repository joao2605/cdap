using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AEIS
{
    public partial class Login : Telerik.WinControls.UI.ShapedForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (radTxtUserName.Text == "")
            {
                MessageBox.Show("Please enter Username..!","Empty field");
            }
            if (radTxtPassWord.Text == "")
            {
                MessageBox.Show("Please enter Password..!", "Empty field");
            }
            else
            {
                Main newmain = new Main();
                this.Hide();
                newmain.Show();
            }

            
        }
    }
}