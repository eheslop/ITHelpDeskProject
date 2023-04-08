﻿using Microsoft.Data.SqlClient;
using GUI_IT;

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
        private SessionRegister newUser_;
        public string User { get; set; }
        public string emaill { get; set; }
        public string FullName { get; set; }

        public frmProjectMember(SessionRegister newUser)
        {
            newUser_ = newUser;
            InitializeComponent();
            pnlTickets.Visible = true;
            pnlProblemList.Visible = false;
            lblUser.Text = newUser_.FirstName + "!";
            lblLoggedIn.Text = "Logged in as: " + newUser_.FirstName;
            User = newUser_.Username;
            emaill = newUser_.Email;
            FullName = newUser_.FullName;
            Fill();
            combo();
        }


        private void Fill()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string x = User;
            string query = "Select * from Tickets where Username = '" + User + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVM.DataSource = dt;
            DGVM.EditMode = DataGridViewEditMode.EditOnEnter;
            con.Close();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxType.ResetText();
            cbxType.SelectedIndex = -1;
            cbxUrgency.ResetText();
            cbxUrgency.SelectedIndex = -1;
            txtProblemDescribe.Clear();
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            // SessionRegister newUser;

            string Category = cbxType.Text.ToString();
            string Description = txtProblemDescribe.Text.ToString();
            string Priority = cbxUrgency.Text.ToString();

            int id = Sql.count();
            Sql.RaiseTicket(id, FullName, User, Category, Description, emaill, Priority);
            Email.sendEmail("Raised Ticket", User, 0, id);
            MessageBox.Show("Your ticket was raised successfully, and you will recieve email updates regarding the status of your ticket.", "Ticket Successfully Raised!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cbxType.ResetText();
            cbxType.SelectedIndex = -1;
            cbxUrgency.ResetText();
            cbxUrgency.SelectedIndex = -1;
            txtProblemDescribe.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void btnReopenClear_Click(object sender, EventArgs e)
        {
            cbxReopenReason.ResetText();
            cbxReopenReason.SelectedIndex = -1;
            txtReopenTicket.Clear();
            //txtID.Clear();
        }

        private void combo()
        {
            cbxid.DataSource = Sql.Solved(User);
            cbxid.DisplayMember = "Id";
        }
        private void btnReopenTicket_Click(object sender, EventArgs e)
        {
            string reason = cbxReopenReason.Text.ToString();
            string info = txtReopenTicket.Text.ToString();
            string x = cbxid.Text.ToString();
            int y = System.Convert.ToInt32(x);
            string ema = emaill;
            Sql.reraise(y, User, ema, reason, info);
        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            frmUserProf UserProfile = new frmUserProf(newUser_);
            UserProfile.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin LoginScreen = new FrmLogin();
            this.Hide();
            LoginScreen.ShowDialog();
            this.Close();
        }

        private void btnOnlineHelp_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = false;
            this.Text = "IT Help Desk Project Member Online Help";
            cbxType.ResetText();
            cbxType.SelectedIndex = -1;
            cbxUrgency.ResetText();
            cbxUrgency.SelectedIndex = -1;
            txtProblemDescribe.Clear();
        }

        private void btnProblemList_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = true;
            this.Text = "IT Help Desk Project Member Problem List";
            cbxType.ResetText();
            cbxType.SelectedIndex = -1;
            cbxUrgency.ResetText();
            cbxUrgency.SelectedIndex = -1;
            txtProblemDescribe.Clear();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = true;
            pnlProblemList.Visible = false;
            this.Text = "IT Help Desk Project Member Ticket Dashboard";
        }
    }
}
