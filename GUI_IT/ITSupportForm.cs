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
    public partial class frmITSupport : Form
    {
        private SessionRegister newUser_;

        public frmITSupport(SessionRegister newUser)
        {
            newUser_ = newUser;
            InitializeComponent();
            lblUser.Text = newUser_.FirstName + "!";
            lblLoggedIn.Text = "Logged in as: " + newUser_.FirstName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin LoginScreen = new FrmLogin();
            this.Hide();
            LoginScreen.ShowDialog();
            this.Close();
        }

        private void tabShare_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void btnSolveClear_Click(object sender, EventArgs e)
        {
            txtSolution.Clear();
            txtSolveTicketID.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTicketID.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            frmUserProf UserProfile = new frmUserProf(newUser_);
            UserProfile.ShowDialog();
        }
    }
}
