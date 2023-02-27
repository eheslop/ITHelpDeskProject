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
            pnlTickets.Visible = false;
            pnlProblemList.Visible = false;
            pnlOnlineHelp.Visible = false;
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
            pnlTickets.Visible = false;
            pnlProblemList.Visible = false;
            pnlOnlineHelp.Visible = false;
            this.Text = "IT Help Desk Project Member Homepage";
        }

        private void btnOnlineHelp_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = false;
            pnlOnlineHelp.Visible = true;
            this.Text = "IT Help Desk Project Member Online Help";
        }

        private void btnProblemList_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = true;
            pnlOnlineHelp.Visible = false;
            this.Text = "IT Help Desk Project Member Problem List";
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = true;
            pnlProblemList.Visible = false;
            pnlOnlineHelp.Visible = false;
            this.Text = "IT Help Desk Project Member Raising Tickets";
        }

        private void pnlOnlineHelp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
