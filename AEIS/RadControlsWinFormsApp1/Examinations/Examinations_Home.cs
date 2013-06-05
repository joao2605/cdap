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
    public partial class Examinations_Home : UserControl
    {
        public Examinations_Home()
        {
            InitializeComponent();
        }

        private void btnExamInvigilation_Click(object sender, EventArgs e)
        {
            pnlMainExamination.Controls.Clear();
            var Invigilate = new ExaminationInvigilation();
            pnlMainExamination.Controls.Add(Invigilate);
        }

        private void btnExamInvigilation_MouseHover(object sender, EventArgs e)
        {
            btnExamInvigilation.ForeColor = Color.Orange;
        }

        private void btnExamInvigilation_MouseLeave(object sender, EventArgs e)
        {
            btnExamInvigilation.ForeColor = Color.Black;
        }

        private void btnExaminationArchive_Click(object sender, EventArgs e)
        {
            pnlMainExamination.Controls.Clear();
            var archive = new ExaminationArchive();
            pnlMainExamination.Controls.Add(archive);
        }

        private void btnExaminationArchive_MouseHover(object sender, EventArgs e)
        {
            btnExaminationArchive.ForeColor = Color.Orange;
        }

        private void btnExaminationArchive_ClientSizeChanged(object sender, EventArgs e)
        {
            btnExaminationArchive.ForeColor = Color.Black;
        }
    }
}
