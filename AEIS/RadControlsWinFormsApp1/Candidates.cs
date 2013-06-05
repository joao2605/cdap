using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadControlsWinFormsApp1
{
    public partial class Candidates : UserControl
    {
        public Candidates()
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
    }
}
