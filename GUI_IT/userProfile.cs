﻿using System;
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

        public string pass { get; set; }
        public frmUserProf(SessionRegister newUser)
        {
            InitializeComponent();
            newUser_ = newUser;
            lblNameUser.Text = newUser_.FullName;
            lblUserEmail.Text = newUser_.Email;
            lblUserRole.Text = newUser_.UserType;
            lblUserUsername.Text = newUser_.Username;
            lblUserPassword.Text = newUser_.Password;
            pnlChangePassword.Visible = false;
        }

        private void linklblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlChangePassword.Visible = true;
        }

        private void lblUserPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblNameUser_Click(object sender, EventArgs e)
        {

        }

        private void lblUserRole_Click(object sender, EventArgs e)
        {

        }

        private void linklblNoPassChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlChangePassword.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string user = newUser_.Username;
            pass = txtConfirmPass.Text.ToString();
            string confirm = txtnewPass.Text.ToString();
            if (pass == confirm)
            {
                Sql.cngpass(user, pass);
                MessageBox.Show("Your Password has been Changed!");
                reload();
                pnlChangePassword.Visible = false;
            }
            else
            {
                MessageBox.Show("Those Passwords do not match, Try again!");
            }
        }

        public void reload()
        {
            lblNameUser.Text = newUser_.FullName;
            lblUserEmail.Text = newUser_.Email;
            lblUserRole.Text = newUser_.UserType;
            lblUserUsername.Text = newUser_.Username;
            lblUserPassword.Text = pass;
        }
    }
}
