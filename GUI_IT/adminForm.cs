using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
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
        private SessionRegister newUser_;

        private Rectangle buttonOriginalRectangle;
        private Rectangle originalFormSize;
        private DataTable dt;
        private SqlDataAdapter da;

        public frmAdmin(SessionRegister newUser)
        {
            newUser_ = newUser;
            InitializeComponent();
            pnlReportGenerate.Visible = false;
            lblLoggedIn.Text = "Logged in as: " + newUser_.FirstName;
            lblUser.Text = newUser_.FirstName + "!";
            Fill();
            Fill1();
            combo();
            combo1();
            Fill9();
            /*combo2();
            combo3();*/
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Text = "IT Help Desk Admin Registration";
            pnlReportGenerate.Visible = false;
            lblAdminHeader.Text = "New User Registration";
            lblAdminHeader.Location = new Point(429, 101);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.Text = "IT Help Desk Admin Report Generation";
            pnlReportGenerate.Visible = true;
            lblAdminHeader.Text = "Report Generation";
            lblAdminHeader.Location = new Point(459, 101);
        }

        private void combo()
        {
            cbxSolvedID.DataSource = Sql.SelectSol();
            cbxSolvedID.DisplayMember = "Id";
        }

        private void combo1()
        {
            cbxUnsolvedID.DataSource = Sql.SelectTick();
            cbxUnsolvedID.DisplayMember = "Id";
        }

        /*
        private void combo2()
        {
            cbxu.DataSource = Sql.ITname();
            cbxu.DisplayMember = "Name";
        }

        private void combo3()
        {
            cbxuu.DataSource = Sql.PMname();
            cbxuu.DisplayMember = "Name";
        }*/

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

        private void pnlRegistration_Paint(object sender, PaintEventArgs e)
        {

        }


        /*private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string query = "Select * from Registration";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVR.DataSource = dt;
            con.Close();
        }*/

        private void Fill()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string query = "Select * from Registration";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVR.DataSource = dt;
            DGVR.EditMode = DataGridViewEditMode.EditOnEnter;
            con.Close();

        }


        /*private void btnSubmit_Click(object sender, EventArgs e)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            DataTable dt = new DataTable();
            string query = "UPDATE Registration";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Update(dt);
            this.DGVR.Refresh();
        }*/


        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            frmUserProf UserProfile = new frmUserProf(newUser_);
            UserProfile.ShowDialog();
        }

        private void Fill1()
        {

            DGVV.DataSource = Sql.ticketsUnsolvedAll();
            DGVV.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void Fill2()
        {

            DGVV.DataSource = Sql.ticketssolvedAll();
            DGVV.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void btnUnsolvedView_Click(object sender, EventArgs e)
        {
            Fill1();
        }

        private void btnSolvedView_Click(object sender, EventArgs e)
        {
            Fill2();
        }

        private void Fill9()
        {
            DGVGR.DataSource = Sql.Report();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string x = cbxSolvedID.Text.ToString();
            int y = System.Convert.ToInt32(x);
            if (Sql.Exists1(y) == true)
            {

            }
            else
            {
                string b = Sql.getTicketassign(y);
                string c = Sql.getTicketPriority(y);
                string d = Sql.getTicketUser(y);
                string g = Sql.getTicketCategory(y);
                string l = Sql.solution(y); 
                string f = Sql.getTicketDescription(y);
                string h = "Solved";
                string n = Sql.getColl(y);
                Sql.report(y, c, b, d, g, f, l, newUser_.Username, h, n);
            }
            generatedReport report = new generatedReport(y);
            report.ShowDialog();
            // MessageBox.Show("Your report regarded the solved ticket of your choosing has been successfully submitted.", "Solved Ticket Report Submitted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnrefre_Click_1(object sender, EventArgs e)
        {
            Fill();
        }

        private void btnApproveDeny_Click_1(object sender, EventArgs e)
        {
            frmstatusUpdate UpdateUserStatus = new frmstatusUpdate();
            UpdateUserStatus.ShowDialog();
        }

        private void btnSubmitUnsolved_Click(object sender, EventArgs e)
        {
            string x = cbxUnsolvedID.Text.ToString();
            int y = System.Convert.ToInt32(x);
            if (Sql.Exists1(y) == true)
            {

            }
            else
            {
                string b = Sql.getTicketassign(y);
                string c = Sql.getTicketPriority(y);
                string d = Sql.getTicketUser(y);
                string g = Sql.getTicketCategory(y);
                string l = "NONE";
                string f = Sql.getTicketDescription(y);
                string h = Sql.getTicketStat(y);
                string n = Sql.getColl(y);
                Sql.report(y, c, b, d, g, f, l, newUser_.Username, h,n);
            }
            generatedReport report = new generatedReport(y);
            report.ShowDialog();
            /*string x = txtTicketID.Text.ToString();
            string b = Sql.getTicketassign(y);
                string c = Sql.getTicketPriority(y);
                string d = Sql.getTicketUser(y);
                string g = Sql.getTicketCategory(y);
                string l = Sql.solution(y);
                string f = Sql.getTicketDescription(y);
                string h = Sql.getTicketStat(y);
            string h = "Unsolved";
            Sql.report(y, c, b, d, g, f, l, newUser_.Username, h);*/

            // MessageBox.Show("Your report regarded the unsolved ticket of your choosing has been successfully submitted.", "Unsolved Ticket Report Submitted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DGVGR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}