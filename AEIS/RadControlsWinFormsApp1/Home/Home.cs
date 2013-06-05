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
    public partial class Home : UserControl
    {
        System.Timers.Timer timer = new System.Timers.Timer(1);
        public Home()
        {
            InitializeComponent();
            timer.AutoReset = true;
            timer.SynchronizingObject = this;
            timer.Elapsed += timer_Elapsed;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            pnlDescription.Width += 20;

            if (pnlDescription.Height == 860)
                timer.Stop();                      
        }
        

        private void Home_Load(object sender, EventArgs e)
        {
            //allert handling
            alertWelcome.ContentText = "Hi friends it's look great. The system is going to decorate with popup facility.";
            alertWelcome.Show();
            //Control initializing
            pnlDescription.BackColor = Color.FromArgb(220,Color.YellowGreen);
            pnlDescription.Region = Round.GetRoundedRegion(190, 370);
            pnlVideoStream.BackColor = Color.FromArgb(220, Color.Gray);
            pnlVideoStream.Region = Round.GetRoundedRegion(215, 182);
            pnlGrid.BackColor = Color.FromArgb(220, Color.Gray);
            pnlGrid.Region = Round.GetRoundedRegion(215, 182);
            pnlMessage.BackColor = Color.FromArgb(220, Color.Gray);
            pnlMessage.Region = Round.GetRoundedRegion(215, 182);
            pnlPlayRec.BackColor = Color.FromArgb(220, Color.Gray);
            pnlPlayRec.Region = Round.GetRoundedRegion(215, 182);
            pnlFaceReco.BackColor = Color.FromArgb(220, Color.Gray);
            pnlFaceReco.Region = Round.GetRoundedRegion(215, 182);
            pnlReport.BackColor = Color.FromArgb(220, Color.Gray);
            pnlReport.Region = Round.GetRoundedRegion(215, 182);
            //lable initilization
            lblHours.Region = Round.GetRoundedRegion(53,53);
            lblMinits.Region = Round.GetRoundedRegion(53,53);
            lblSeconds.Region = Round.GetRoundedRegion(53, 53);
        }

        private void pnlDescription_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDescription_MouseHover(object sender, EventArgs e)
        {
            //start animation
            timer.Start();
            pnlDescription.Region = Round.GetRoundedRegion(860, 370);
            pnlDescription.BackColor = Color.YellowGreen;

            
        }

        private void pnlDescription_MouseLeave(object sender, EventArgs e)
        {
            //desable the timer
            timer.Stop();
            pnlDescription.Width = 190;
            pnlDescription.BackColor = Color.FromArgb(220, Color.YellowGreen);
            pnlDescription.Region = Round.GetRoundedRegion(190, 370);
                      
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timHome_Tick(object sender, EventArgs e)
        {
            this.lblHours.Text = DateTime.Now.ToString("hh");
            this.lblMinits.Text = DateTime.Now.ToString("mm");
            this.lblSeconds.Text = DateTime.Now.ToString("ss");
            this.lblTt.Text = DateTime.Now.ToString("tt");
        }

        private void lblDigiClock_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
