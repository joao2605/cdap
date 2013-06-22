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

            DataSet ds = DB_Connect.ExecuteQuery("SELECT E.exam_date AS Date , S.subject_name AS Subject, E.exam_start_time AS Start , E.exam_end_time AS Finish , E.exam_hall_id AS Hall FROM examination_tab E LEFT JOIN subject_tab S ON E.exam_subject_id = S.subject_id ORDER BY E.exam_date desc");
            dgvExaminationList.DataSource = ds.Tables[0];

        }
    }
}
