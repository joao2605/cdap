using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        private void UserSummary_Load(object sender, EventArgs e)
        {
            User USR = new User();
            DataSet DS = USR.getLogTrack();
            string userID;
            int count;
            //generate chart
            chart1.Series.Add("Login_Rate");
            chart1.Series["Login_Rate"].ChartType = SeriesChartType.Column;
            chart1.Series["Login_Rate"].ChartArea = "ChartArea1";
            chart1.Series["Login_Rate"].BackSecondaryColor = Color.White;
            chart1.Series["Login_Rate"].BackGradientStyle = GradientStyle.TopBottom;

            int rowCount = 0;

            foreach (DataRow row in DS.Tables[0].Rows)
            {
               
                userID = row[0].ToString().Trim();
                count = Convert.ToInt32(row[1]);

                chart1.Series["Login_Rate"].Points.AddXY(userID, count);
                
                rowCount++;
            }

            
            //fill the grid
            DataSet ds = USR.getLogInfo();
            gridUsers.DataSource = ds.Tables["Info"].DefaultView;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radGroupBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
