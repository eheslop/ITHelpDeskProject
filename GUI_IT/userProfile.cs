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
        private SessionRegister newUser;

        public frmUserProf(SessionRegister newUser)
        {
            InitializeComponent();
            lblNameUser.Text = newUser.FullName;
            /*lblUserEmail.Text = newUser.Email;
            lblUserRole.Text = newUser.UserType;
            lblUserUsername.Text = newUser.Username;
            lblUserPassword.Text = newUser.Password;*/
        }

        private void linklblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
