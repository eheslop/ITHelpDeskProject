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
    public partial class frmProjectMember : Form
    {
        public frmProjectMember()
        {
            InitializeComponent();
            pnlOnlineHelp.Visible = false;
            pnlProblemList.Visible = false;
            pnlTickets.Visible = false;
        }

        private void frmProjectMember_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin LoginScreen = new FrmLogin();
            this.Hide();
            LoginScreen.ShowDialog();
            this.Close();
        }

        private void btnHomeMember_Click(object sender, EventArgs e)
        {
            pnlOnlineHelp.Visible = false;
            pnlProblemList.Visible = false;
            pnlTickets.Visible = false;
            this.Text = "IT Help Desk Project Member Homepage";
        }

        private void btnOnlineHelp_Click(object sender, EventArgs e)
        {
            pnlOnlineHelp.Visible = true;
            pnlProblemList.Visible = false;
            pnlTickets.Visible = false;
            this.Text = "IT Help Desk Project Member Online Help";
        }

        private void btnProblemList_Click(object sender, EventArgs e)
        {
            pnlOnlineHelp.Visible = false;
            pnlProblemList.Visible = true;
            pnlTickets.Visible = false;
            this.Text = "IT Help Desk Project Member Problem List";
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            pnlOnlineHelp.Visible = false;
            pnlProblemList.Visible = false;
            pnlTickets.Visible = true;
            this.Text = "IT Help Desk Project Member Ticket Dashboard";
        }

        private void pnlOnlineHelp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
