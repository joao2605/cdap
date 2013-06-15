﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AEIS
{
    

    public partial class AlertLog : Telerik.WinControls.UI.ShapedForm
    {

        private int examid = -1;

        public AlertLog(int id)
        {
            InitializeComponent();

            this.examid = id;
            
            DataSet ds = DB_Connect.ExecuteQuery("SELECT E.exam_date As Date, S.subject_name AS Subject , A.position_id As Position , A.alert_type AS Type, A.alert_time AS Time FROM alert_tab A LEFT JOIN examination_tab E ON A.exam_id = E.exam_id LEFT JOIN subject_tab S ON E.exam_subject_id = S.subject_id WHERE A.exam_id =  "+examid+" ORDER BY A.alert_time desc");
            gvAlerts.DataSource = ds.Tables[0];

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