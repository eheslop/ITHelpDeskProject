using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GUI_IT
{
    public partial class frmITSupport : Form
    {
        private SessionRegister newUser_;

        public frmITSupport(SessionRegister newUser)
        {
            newUser_ = newUser;
            InitializeComponent();
            lblUser.Text = newUser_.FirstName + "!";
            lblLoggedIn.Text = "Logged in as: " + newUser_.FirstName;
            Fill1();
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

        }

        private void btnSolveClear_Click(object sender, EventArgs e)
        {
            txtSolution.Clear();
            txtSolveTicketID.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTicketID.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            frmUserProf UserProfile = new frmUserProf(newUser_);
            UserProfile.ShowDialog();
        }

        private void Fill1()
        {
            string x = newUser_.Username;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string query = "Select * from Tickets where AssignedTo = '" + x + "'; ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVS.DataSource = dt;
            DGVS.EditMode = DataGridViewEditMode.EditOnEnter;
            con.Close();

        }

        private void Fill2()
        {
            string x = newUser_.Username;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string query = "Select * from Tickets where AssignedTo = '" + x + "'; ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVShare.DataSource = dt;
            DGVShare.EditMode = DataGridViewEditMode.EditOnEnter;
            con.Close();

        }

        private void btnSolveTicket_Click(object sender, EventArgs e)
        {
            string x = txtSolveTicketID.Text.ToString();
            int y = System.Convert.ToInt32(x);
            string z = Sql.tickuser(y);
            string k = Sql.tickemail(y);
            string j = txtSolution.Text.ToString();
            Sql.solve(y, newUser_.Username, z, k, j);
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            FrmLogin LoginScreen = new FrmLogin();
            this.Hide();
            LoginScreen.ShowDialog();
            this.Close();
        }
    }
}
