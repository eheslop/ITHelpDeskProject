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
        private SessionRegister newUser;

        public string User { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }

        public frmProjectMember(SessionRegister newUser)
        {
            InitializeComponent();
            pnlTickets.Visible = true;
            pnlProblemList.Visible = false;
            lblUser.Text = newUser.FirstName + "!";
            lblLoggedIn.Text = "Logged in as: " + newUser.FirstName;
            User = newUser.Username;
            Email = newUser.Email;
            FullName = newUser.FullName;
            Fill();
        }

        private void frmProjectMember_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin LoginScreen = new FrmLogin();
            this.Hide();
            LoginScreen.ShowDialog();
            this.Close();
        }

        private void btnHomeMember_Click(object sender, EventArgs e)
        {
            pnlTickets.Visible = false;
            pnlProblemList.Visible = false;
            this.Text = "IT Help Desk Project Member Homepage";
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

        private void pnlOnlineHelp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxType.ResetText();
            cbxType.SelectedIndex = -1;
            cbxUrgency.ResetText();
            cbxUrgency.SelectedIndex = -1;
            txtProblemDescribe.Clear();
        }

        private void btnReopenClear_Click(object sender, EventArgs e)
        {
            cbxReopenReason.ResetText();
            cbxReopenReason.SelectedIndex = -1;
            txtReopenTicket.Clear();
            txtID.Clear();
        }

        private void pnlProblemList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            // SessionRegister newUser;

            string Category = cbxType.Text.ToString();
            string Description = txtProblemDescribe.Text.ToString();
            string Priority = cbxUrgency.Text.ToString();

            int id = Sql.count();
            Sql.RaiseTicket(id, FullName, User, Category, Description, Email, Priority);

            cbxType.ResetText();
            cbxType.SelectedIndex = -1;
            cbxUrgency.ResetText();
            cbxUrgency.SelectedIndex = -1;
            txtProblemDescribe.Clear();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblLoggedIn_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            frmUserProf UserProfile = new frmUserProf();
            UserProfile.ShowDialog();
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
    }
}
