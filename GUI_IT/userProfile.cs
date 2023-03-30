using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_IT;

namespace GUI_IT
{
    public partial class frmUserProf : Form
    {
        private SessionRegister newUser_;

        public frmUserProf(SessionRegister newUser)
        {
            InitializeComponent();
            newUser_ = newUser;
            lblNameUser.Text = newUser_.FullName;
            lblUserEmail.Text = newUser_.Email;
            lblUserRole.Text = newUser_.UserType;
            lblUserUsername.Text = newUser_.Username;
            lblUserPassword.Text = newUser_.Password;
        }   

        private void linklblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblUserPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
