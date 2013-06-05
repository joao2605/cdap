using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using AEIS.Properties;
using System.IO;

namespace AEIS
{
    public partial class Main : Telerik.WinControls.UI.ShapedForm
    {
        //Global resources
        

        public Main()
        {
            
            InitializeComponent();

        }

        private void ShapedForm1_Load(object sender, EventArgs e)
        {

            this.Region = Round.GetRoundedRegion(1024, 700);
            this.btnCandidates.Region = Round.GetRoundedRegion(130, 40);
            this.btnHome.Region = Round.GetRoundedRegion(70, 40);
            this.btnMini.Region = Round.GetRoundedRegion(30, 27);
            this.btnMcqHandling.Region = Round.GetRoundedRegion(130, 40);
            this.btnUserHandling.Region = Round.GetRoundedRegion(125, 40);
            this.btnRecognition.Region = Round.GetRoundedRegion(130, 40);
            this.btnExaminations.Region = Round.GetRoundedRegion(130, 40);
            this.btnReports.Region = Round.GetRoundedRegion(130, 40);
            this.btnHelp.Region = Round.GetRoundedRegion(145, 40);
            this.pnlBackGround.Region = Round.GetRoundedRegion(1014, 690);
            this.pnlHedder.Region = Round.GetRoundedRegion(1014, 98);

            this.pnlFunctionViewr.Controls.Clear();
            var Home = new Home();
            this.pnlFunctionViewr.Controls.Add(Home);
            ClearButtonBackground();
            btnHome.BackColor = Color.Orange;
            
        }

        private void ClearButtonBackground()
        {
            //reset ribbon
            Color BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");
            this.btnCandidates.BackColor = BackColor;
            this.btnHome.BackColor = BackColor;
            this.btnMcqHandling.BackColor = BackColor;
            this.btnUserHandling.BackColor = BackColor;
            this.btnRecognition.BackColor = BackColor;
            this.btnExaminations.BackColor = BackColor;
            this.btnReports.BackColor = BackColor;
            this.btnHelp.BackColor = BackColor;
            //
            this.btnCandidates.ForeColor = Color.Black;
            this.btnHome.ForeColor = Color.Black;
            this.btnMcqHandling.ForeColor = Color.Black;
            this.btnUserHandling.ForeColor = Color.Black;
            this.btnRecognition.ForeColor = Color.Black;
            this.btnExaminations.ForeColor = Color.Black;
            this.btnReports.ForeColor = Color.Black;
            this.btnHelp.ForeColor = Color.Black;
            
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButton4_MouseHover(object sender, EventArgs e)
        {
           // radButton4.ForeColor = Color.Red;
        }

        private void radButton4_MouseLeave(object sender, EventArgs e)
        {
           // radButton4.ForeColor = Color.Black;
            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_MouseHover(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnCandidates.BackColor = Color.LightGray;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Orange; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMcqHandling_Click(object sender, EventArgs e)
        {
            //replace the elements from Candidates user controler
            this.pnlFunctionViewr.Controls.Clear();
            var mcqHandler = new recognition();
            this.pnlFunctionViewr.Controls.Add(mcqHandler);
            //change the background color
            ClearButtonBackground();
            btnMcqHandling.ForeColor = Color.White;
            btnMcqHandling.BackColor = Color.Orange;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //replace the elements from Candidates user controler
            this.pnlFunctionViewr.Controls.Clear();
            var Home = new Home();
            this.pnlFunctionViewr.Controls.Add(Home);
            //change the background color
            ClearButtonBackground();
            btnHome.BackColor = Color.Orange;
            btnHome.ForeColor = Color.White;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            btnMini.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnMini.ForeColor = Color.Orange;
        }

        private void pnlHedder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCandidates_Click(object sender, EventArgs e)
        {
            //replace the elements from Candidates user controler
            this.pnlFunctionViewr.Controls.Clear();
            var CandidateWindow = new Candidates_Home();
            this.pnlFunctionViewr.Controls.Add(CandidateWindow);
            //change the background color
            ClearButtonBackground();
            btnCandidates.ForeColor = Color.White;
            btnCandidates.BackColor = Color.Orange;
        }

        private void btnRecognition_Click(object sender, EventArgs e)
        {
            //replace the elements from Candidates user controler
            this.pnlFunctionViewr.Controls.Clear();
            var Recognition = new FaceRecognition();
            this.pnlFunctionViewr.Controls.Add(Recognition);
            //change the background color
            ClearButtonBackground();
            btnRecognition.ForeColor = Color.White;
            btnRecognition.BackColor = Color.Orange;
        }

        private void btnInvigilation_Click(object sender, EventArgs e)
        {
            //replace the elements from Candidates user controler
            this.pnlFunctionViewr.Controls.Clear();
            var Invigiation = new Examinations_Home();
            this.pnlFunctionViewr.Controls.Add(Invigiation);
            //change the background color
            ClearButtonBackground();
            btnExaminations.ForeColor = Color.White;
            btnExaminations.BackColor = Color.Orange;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //replace the elements from Candidates user controler
            this.pnlFunctionViewr.Controls.Clear();
            var Reports = new Reports();
            this.pnlFunctionViewr.Controls.Add(Reports);
            //change the background color
            ClearButtonBackground();
            btnReports.ForeColor = Color.White;
            btnReports.BackColor = Color.Orange;
        }

        private void btnUserHandling_Click(object sender, EventArgs e)
        {
            //replace the elements from Candidates user controler
            this.pnlFunctionViewr.Controls.Clear();
            var UserHandling = new UserHandling_Home();
            this.pnlFunctionViewr.Controls.Add(UserHandling);
            //change the background color
            ClearButtonBackground();
            btnUserHandling.ForeColor = Color.White;
            btnUserHandling.BackColor = Color.Orange;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            //minimise the window in to task bar
            this.WindowState = FormWindowState.Minimized;            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //replace the elements from Candidates user controler
            this.pnlFunctionViewr.Controls.Clear();
            var HelpSupport = new HelpAndSupport();
            this.pnlFunctionViewr.Controls.Add(HelpSupport);
            //change the background color
            ClearButtonBackground();
            btnHelp.ForeColor = Color.White;
            btnHelp.BackColor = Color.Orange;

        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            this.btnSettings.ForeColor = Color.Gold;
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            this.btnLogout.ForeColor = Color.Gold;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogout.ForeColor = Color.DarkOrange;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            this.btnSettings.ForeColor = Color.YellowGreen;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settings = new SettingsWindow();
            settings.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void pnlFunctionViewr_Paint(object sender, PaintEventArgs e)
        {

        }

        

        
    }
}