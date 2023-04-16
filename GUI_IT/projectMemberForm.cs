using Microsoft.Data.SqlClient;
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
            DGVM.DataSource = Sql.Raisedtickets(User);
            DGVM.EditMode = DataGridViewEditMode.EditOnEnter;
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
            cbxid.ResetText();
            cbxid.SelectedIndex = -1;
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = true;
            pnlProblemList.Visible = false;
            this.Text = "IT Help Desk Project Member Ticket Dashboard";
        }

        private void btnProblemList_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = true;
            this.Text = "IT Help Desk Project Member Problem List";
        }

        private void btnOnlineHelp_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = false;
            this.Text = "IT Help Desk Project Member Online Help";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin LoginScreen = new FrmLogin();
            this.Hide();
            LoginScreen.ShowDialog();
            this.Close();
        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            frmUserProf UserProfile = new frmUserProf(newUser_);
            UserProfile.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void btnTickets_Click_1(object sender, EventArgs e)
        {

        }

        private void lnklblEmailQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = false;
            pnlEmailQ.Visible = true;
            pnlGeneralQ.Visible = false;
            pnlPasswordQ.Visible = false;
            pnlTicketQ.Visible = false;
            
        }

        private void lnklblTicketQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = false;
            pnlEmailQ.Visible = false;
            pnlGeneralQ.Visible = false;
            pnlPasswordQ.Visible = false;
            pnlTicketQ.Visible = true;
        }

        private void lnklblPasswordQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = false;
            pnlEmailQ.Visible = false;
            pnlGeneralQ.Visible = false;
            pnlPasswordQ.Visible = true;
            pnlTicketQ.Visible = false;
        }

        private void lnklblGeneralQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = false;
            pnlEmailQ.Visible = false;
            pnlGeneralQ.Visible = true;
            pnlPasswordQ.Visible = false;
            pnlTicketQ.Visible = false;
        }

        private void btnPasswordBack_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = true;
            pnlEmailQ.Visible = false;
            pnlGeneralQ.Visible = false;
            pnlPasswordQ.Visible = false;
            pnlTicketQ.Visible = false;
        }

        private void brnBackEmail_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = true;
            pnlEmailQ.Visible = false;
            pnlGeneralQ.Visible = false;
            pnlPasswordQ.Visible = false;
            pnlTicketQ.Visible = false;
        }

        private void btnBackTicket_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = true;
            pnlEmailQ.Visible = false;
            pnlGeneralQ.Visible = false;
            pnlPasswordQ.Visible = false;
            pnlTicketQ.Visible = false;
        }

        private void btnBackGeneral_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = true;
            pnlEmailQ.Visible = false;
            pnlGeneralQ.Visible = false;
            pnlPasswordQ.Visible = false;
            pnlTicketQ.Visible = false;
        }
    }
}
