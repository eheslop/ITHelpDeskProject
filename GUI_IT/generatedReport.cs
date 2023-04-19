using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_IT
{
    public partial class generatedReport : Form
    {
        public int id { get; set; }
        public generatedReport(int tID, int z)
        {
            InitializeComponent();
            txtID.Text = tID.ToString();
            txtCategory.Text = Sql.getTicketCategory(tID);
            txtITMem.Text = Sql.getTicketassign(tID);
            txtRaisedUser.Text = Sql.getTicketUser(tID);
            txtStatus.Text = Sql.getTicketStat(tID);
            txtUrgency.Text = Sql.getTicketPriority(tID);
            txtSummary.Text = Sql.getTicketDescription(tID);
            textBox1.Text = Sql.getColl(tID);
            txtSolution.Text = Sql.solution(tID);
            id = tID;
            if (z == 0)
            {
                txtSolution.Visible = true;
                txtExtra.Visible = false;
                btnsubmit.Visible = false;
                lblExtra.Visible = false;
                lblSolution.Visible = true;
                pnlExpandTicket.Visible = false;
                lblViewHeader.Visible = false;
            }
            else
            {
                txtSolution.Visible = false;
                txtExtra.Visible = true;
                btnsubmit.Visible = true;
                lblExtra.Visible = true;
                lblSolution.Visible = false;
                pnlExpandTicket.Visible = false;
                lblViewHeader.Visible = false;

            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string x = txtExtra.Text;
            Sql.addinfo(x, id);
            MessageBox.Show("You have successfully added extra information to this ticket!", "Ticket Successfully Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUrgency_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
