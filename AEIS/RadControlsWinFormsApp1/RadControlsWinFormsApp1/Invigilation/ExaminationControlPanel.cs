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
    public partial class ExaminationControlPanel : UserControl
    {
        public ExaminationControlPanel()
        {
            InitializeComponent();

            DataSet ds = DB_Connect.ExecuteQuery("SELECT E.exam_id AS ID, E.exam_date AS DATE, S.subject_name AS Subject, E.exam_start_time AS START, E.exam_end_time AS Finish, H.hall_code AS Hall FROM examination_tab E LEFT JOIN subject_tab S ON E.exam_subject_id = S.subject_id LEFT JOIN hall_tab H ON E.exam_hall_id = H.hall_id ORDER BY E.exam_date DESC");
            dgvExaminationList.DataSource = ds.Tables[0];

            DataSet dssub = DB_Connect.ExecuteQuery("SELECT S.subject_id , S.subject_name FROM subject_tab S ORDER BY S.subject_name");
            cbSubject.DataSource = dssub.Tables[0];
            cbSubject.DisplayMember = "subject_name";
            cbSubject.ValueMember = "subject_id";

            DataSet dshall = DB_Connect.ExecuteQuery("SELECT H.hall_id , H.hall_code , H.hall_capacity FROM hall_tab H ORDER BY H.hall_code");
            cbHall.DataSource = dshall.Tables[0];
            cbHall.DisplayMember = "hall_code";
            cbHall.ValueMember = "hall_id";




        }

        private void dgvExaminationList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ExamId = 0;
            try
            {
                 ExamId = int.Parse(dgvExaminationList.SelectedRows[0].Cells[0].Value.ToString());
                 new SeatingPositions(ExamId).Show();
            }
            catch (Exception) { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           DB_Connect.InsertQuery("INSERT INTO examination_tab ( exam_date, exam_start_time, exam_end_time, exam_hall_id, exam_subject_id) VALUES  ('" + radDateTimePicker1.Value + "', '" + radDateTimePicker3.Value.TimeOfDay + "', '" + radDateTimePicker4.Value.TimeOfDay + "', " + cbSubject.SelectedValue + ", " + cbHall.SelectedValue + ");");
        }
    }
}
