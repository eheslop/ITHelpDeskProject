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
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            string query = "Select * from Registration";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVR.DataSource = dt;
            DGVR.EditMode = DataGridViewEditMode.EditOnEnter;
            con.Close();

        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void tabExisting_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
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
        }

        private void btnApproveDeny_Click(object sender, EventArgs e)
        {
            frmstatusUpdate UpdateUserStatus = new frmstatusUpdate();
            UpdateUserStatus.ShowDialog();
        }

        private void lblLoggedIn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void btnrefre_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            frmUserProf UserProfile = new frmUserProf(newUser_);
            UserProfile.ShowDialog();
        }

        private void Fill1()
        {
            string x = "Unsolved";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string query = "Select * from Tickets where Status = '" +x+ "' ;";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVV.DataSource = dt;
            DGVV.EditMode = DataGridViewEditMode.EditOnEnter;
            con.Close();
        }

        private void Fill2()
        {
            string x = "Solved";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string query = "Select * from Tickets where Status = '" + x + "' ;";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVV.DataSource = dt;
            DGVV.EditMode = DataGridViewEditMode.EditOnEnter;
            con.Close();
        }
        private void DGVV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReportClear_Click(object sender, EventArgs e)
        {
            txtTicketIDSolve.Clear();
            txtEmailSolved.Clear();
            
            txtUserEmailSolved.Clear();
            
            txtTicketDescribeSolved.Clear();
            txtTicketDetailSolved.Clear();
        }

        private void btnClearUnsolved_Click(object sender, EventArgs e)
        {
            txtTicketID.Clear();
            txtITEmail.Clear();
            
            txtProjectEmail.Clear();
           
            txtTicketSummary.Clear();
            txtUnsolvedExplain.Clear();
        }

        private void btnUnsolvedView_Click(object sender, EventArgs e)
        {
            Fill1();
        }

        private void btnSolvedView_Click(object sender, EventArgs e)
        {
            Fill2();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string x = txtTicketIDSolve.Text.ToString();
            int y = System.Convert.ToInt32(x);
            string b = txtEmailSolved.Text.ToString();
            string c = cbxurg1.Text.ToString();
            string d = txtUserEmailSolved.Text.ToString();
            string g = cbxcat1.Text.ToString();
            string l = txtTicketDetailSolved.Text.ToString();
            string f = txtTicketDescribeSolved.Text.ToString();
            string h = "Solved";
            Sql.report(y, c, b, d, g, f, l, newUser_.Username, h);
        }

        private void btnSubmitUnsolved_Click(object sender, EventArgs e)
        {
            string x = txtTicketID.Text.ToString();
            int y = System.Convert.ToInt32(x);
            string b = txtITEmail.Text.ToString();
            string c = cbxurg.Text.ToString();
            string d = txtProjectEmail.Text.ToString();
            string g = cbxcat.Text.ToString();
            string f = txtTicketSummary.Text.ToString();
            string l = txtUnsolvedExplain.Text.ToString();
            string h = "Unsolved";
            Sql.report(y, c, b, d, g, f, l, newUser_.Username, h);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}