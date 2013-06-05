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
    public partial class Candidates_Home : UserControl
    {
        public Candidates_Home()
        {
            InitializeComponent();
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void Candidates_Load(object sender, EventArgs e)
        {
            pnlMainCandidate.Region = Round.GetRoundedRegion(807, 558);
            
        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            pnlMainCandidate.Controls.Clear();
            var newCandidate = new CandidateAdd();
            pnlMainCandidate.Controls.Add(newCandidate);
        }

        private void btnViewCandidate_Click(object sender, EventArgs e)
        {
            pnlMainCandidate.Controls.Clear();
            var ViewCandidate = new CandidateView();
            pnlMainCandidate.Controls.Add(ViewCandidate);
        }

        private void btnUpdateDeleteCand_Click(object sender, EventArgs e)
        {
            pnlMainCandidate.Controls.Clear();
            var UpdateDeleteCandidate = new CandidateUpdateDelete();
            pnlMainCandidate.Controls.Add(UpdateDeleteCandidate);
        }

        private void btnViewCandidate_MouseHover(object sender, EventArgs e)
        {
            btnViewCandidate.ForeColor = Color.Orange;
        }

        private void btnViewCandidate_MouseLeave(object sender, EventArgs e)
        {
            btnViewCandidate.ForeColor = Color.Black;
        }

        private void btnAddCandidate_MouseHover(object sender, EventArgs e)
        {
            btnAddCandidate.ForeColor = Color.Orange;
        }

        private void btnAddCandidate_MouseLeave(object sender, EventArgs e)
        {
            btnAddCandidate.ForeColor = Color.Black;
        }

        private void btnUpdateDeleteCand_MouseHover(object sender, EventArgs e)
        {
            btnUpdateDeleteCand.ForeColor = Color.Orange;
        }

        private void btnUpdateDeleteCand_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateDeleteCand.ForeColor = Color.Black;
        }
    }
}
