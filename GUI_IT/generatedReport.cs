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
        public generatedReport(int x)
        {
            InitializeComponent();
            txtID.Text = x.ToString();
            txtCategory.Text = Sql.getTicketCategory(x);
            txtITMem.Text = Sql.getTicketassign(x);
            txtRaisedUser.Text = Sql.getTicketUser(x);
            txtStatus.Text = Sql.getTicketStat(x);
            txtUrgency.Text = Sql.getTicketPriority(x);
            txtSummary.Text = Sql.getTicketDescription(x);
            textBox1.Text = Sql.getColl(x);
            id = x;
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
