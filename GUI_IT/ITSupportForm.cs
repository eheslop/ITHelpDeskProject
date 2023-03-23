﻿using System;
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
        private SessionRegister newUser;

        public frmITSupport(SessionRegister newUser)
        {
            InitializeComponent();
            lblUser.Text = newUser.Username + "!";
            lblLoggedIn.Text = "Logged in as: " + newUser.Username;
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
            frmUserProf UserProfile = new frmUserProf();
            UserProfile.ShowDialog();
        }
    }
}
