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
    public partial class frmAdmin : Form
    {
        private Rectangle buttonOriginalRectangle;
        private Rectangle originalFormSize;

        public frmAdmin()
        {
            InitializeComponent();
            pnlRegistration.Visible = false;
            pnlReportGenerate.Visible = false;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Text = "IT Help Desk Admin Homepage";
            pnlRegistration.Visible = false;
            pnlReportGenerate.Visible = false;
        }
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Text = "IT Help Desk Admin Registration";
            pnlRegistration.Visible = true;
            pnlReportGenerate.Visible = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.Text = "IT Help Desk Admin Report Generation";
            pnlRegistration.Visible = false;
            pnlReportGenerate.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin LoginScreen = new FrmLogin();
            this.Hide();
            LoginScreen.ShowDialog();
            this.Close();
        }

        private void Rectangle1_Click(object sender, EventArgs e)
        {

        }

        private void pnlMyAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlReportGenerate_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
