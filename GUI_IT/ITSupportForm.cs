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
        public frmITSupport()
        {
            InitializeComponent();
            pnlTicketDashboard.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin LoginScreen = new FrmLogin();
            this.Hide();
            LoginScreen.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlTicketDashboard.Visible = false;
            this.Text = "IT Help Desk IT Support Team Homepage";
        }

        private void btnTicketDash_Click(object sender, EventArgs e)
        {
            pnlTicketDashboard.Visible = true;
            this.Text = "IT Help Desk IT Support Team Ticket Dashboard";
        }
    }
}