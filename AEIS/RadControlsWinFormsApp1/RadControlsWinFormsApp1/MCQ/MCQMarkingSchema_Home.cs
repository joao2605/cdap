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
    public partial class MCQMarkingSchema_Home : UserControl
    {
        public MCQMarkingSchema_Home()
        {
            InitializeComponent();
        }

        private void btnMCQAnswerSheet_Click(object sender, EventArgs e)
        {
            pnlMainMCQ.Controls.Clear();
            var MCQMarkingSchemaAdd = new MCQMarkingSchemaAdd();
            pnlMainMCQ.Controls.Add(MCQMarkingSchemaAdd);
        }

       

        private void btnMarkngMCQ_Click(object sender, EventArgs e)
        {
            pnlMainMCQ.Controls.Clear();
            var MCQMarkingSchemaUpdate = new MCQMarkingSchemaUpdate();
            pnlMainMCQ.Controls.Add(MCQMarkingSchemaUpdate);
        }

        private void btnMCQReport_Click(object sender, EventArgs e)
        {
            pnlMainMCQ.Controls.Clear();
            var MCQMarkingSchemaDelete = new MCQMarkingSchemaDelete();
            pnlMainMCQ.Controls.Add(MCQMarkingSchemaDelete);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            pnlMainMCQ.Controls.Clear();
            var MCQMarkingSchemaView = new MCQMarkingSchemaView();
            pnlMainMCQ.Controls.Add(MCQMarkingSchemaView);
        }

        private void btnMCQAnswerSheet_MouseHover(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.Orange;
        }

        private void btnMCQAnswerSheet_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.Black;
        }

        private void btnView_MouseHover(object sender, EventArgs e)
        {
            btnView.ForeColor = Color.Orange;
        }

        private void btnView_MouseLeave(object sender, EventArgs e)
        {
            btnView.ForeColor = Color.Black;
        }

        private void btnMarkngMCQ_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.Orange;
        }

        private void btnMarkngMCQ_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.Black;
        }

        private void btnMCQReport_MouseHover(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.Orange;
        }

        private void btnMCQReport_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.Black;
        }

       
    }
}
