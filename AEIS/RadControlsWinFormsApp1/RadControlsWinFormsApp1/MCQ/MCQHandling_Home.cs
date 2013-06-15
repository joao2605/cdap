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
    public partial class recognition : UserControl
    {
        public recognition()
        {
            InitializeComponent();
        }

        private void btnMCQAnswerSheet_Click(object sender, EventArgs e)
        {
            pnlMainMCQ.Controls.Clear();
            var MCQAnswerSheet = new MCQAnswerSheet();
            pnlMainMCQ.Controls.Add(MCQAnswerSheet);
        }

        private void btnMarkingSchema_Click(object sender, EventArgs e)
        {
            pnlMainMCQ.Controls.Clear();
            var MCQMarkingSchema_Home = new MCQMarkingSchema_Home();
            pnlMainMCQ.Controls.Add(MCQMarkingSchema_Home);
        }

        private void btnMarkngMCQ_Click(object sender, EventArgs e)
        {
            pnlMainMCQ.Controls.Clear();
            var MCQMarking = new MCQMarking();
            pnlMainMCQ.Controls.Add(MCQMarking);
        }

        private void btnMCQReport_Click(object sender, EventArgs e)
        {
            pnlMainMCQ.Controls.Clear();
            var MCQReport = new MCQReport();
            pnlMainMCQ.Controls.Add(MCQReport);
        }

        private void btnMCQAnswerSheet_MouseHover(object sender, EventArgs e)
        {
            btnMCQAnswerSheet.ForeColor = Color.Orange;
        }

        private void btnMCQAnswerSheet_MouseLeave(object sender, EventArgs e)
        {
            btnMCQAnswerSheet.ForeColor = Color.Black;
        }

        private void btnMarkingSchema_MouseHover(object sender, EventArgs e)
        {
            btnMarkingSchema.ForeColor = Color.Orange;
        }

        private void btnMarkingSchema_MouseLeave(object sender, EventArgs e)
        {
            btnMarkingSchema.ForeColor = Color.Black;
        }

        private void btnMarkngMCQ_MouseHover(object sender, EventArgs e)
        {
            btnMarkngMCQ.ForeColor = Color.Orange;
        }

        private void btnMarkngMCQ_MouseLeave(object sender, EventArgs e)
        {
            btnMarkngMCQ.ForeColor = Color.Black;
        }

        private void btnMCQReport_MouseHover(object sender, EventArgs e)
        {
            btnMCQReport.ForeColor = Color.Orange;
        }

        private void btnMCQReport_MouseLeave(object sender, EventArgs e)
        {
            btnMCQReport.ForeColor = Color.Black;
        }
    }
}
