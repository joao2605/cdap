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
    }
}
