using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AEIS
{
    

    public partial class SeatingPositions : Telerik.WinControls.UI.ShapedForm
    {
        private int examid = -1;


        public SeatingPositions(int id)
        {
            InitializeComponent();
            this.examid = id;


            DataSet ds = DB_Connect.ExecuteQuery("SELECT C.candidate_name_initials , CP.position_id FROM candidate_position CP LEFT JOIN candidate_tab C ON CP.candidate_id = C.candidate_id WHERE CP.exam_id = "+examid+" ORDER BY CP.position_id");
            gvSeatingPositions.DataSource = ds.Tables[0];

            
        }

     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radLabel4_Click(object sender, EventArgs e)
        {

        }

        private void radTrackBar3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void radLabel17_Click(object sender, EventArgs e)
        {

        }

        private void radTrackBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void radTrackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SeatingPositions_Load(object sender, EventArgs e)
        {
   
        }
    }
}