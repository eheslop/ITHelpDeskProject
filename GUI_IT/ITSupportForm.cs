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
            Fill2();
            combo();
        }


        private void Fill1()
        {
            string x = newUser_.Username;
            string y = "Unsolved";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string query = "Select Distinct Tickets.Id, Name, Username, Category, Description, Category, Priority, Collaborators, AssignedTo FROM Tickets inner join SharedTickets  ON ( Tickets.Id = SharedTickets.Id ) Where AssignedTo = '" + x+"' AND Status = '"+y+"' OR SharedWith = '"+x+ "' AND Status = '"+y+"'; ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVS.DataSource = dt;
            DGVS.EditMode = DataGridViewEditMode.EditOnEnter;
            con.Close();

        }

        private void combo()
        {
            cbxn.DataSource = Sql.ITname();
            cbxn.DisplayMember = "Name";
        }

        private void Fill2()
        {
            string x = newUser_.Username;
            string y = "Unsolved";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string query = "Select * from Tickets where AssignedTo = '" + x + "' and Status = '" + y + "'; ";
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
            MessageBox.Show("Your solution for the ticket of your choosing has now been submitted, thank you.", "Ticket Solved Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Email.sendEmail("Solved Ticket", newUser_.Username, 0, x);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            string x = txtTicketID.Text.ToString();
            int y = System.Convert.ToInt32(x);
            string a = cbxn.Text.ToString();
            string b = Sql.getUser(a);
            string c = txtEmail.Text.ToString();
            Sql.Addcoll(b, y);
            Sql.add2(b, y, c);
            MessageBox.Show("The ticket you wished to share has now been sent to the user of your choosing.", "Ticket Shared Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTicketID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            FrmLogin LoginScreen = new FrmLogin();
            this.Hide();
            LoginScreen.ShowDialog();
            this.Close();
        }

        private void ProfilePictureBox_Click_1(object sender, EventArgs e)
        {
            frmUserProf UserProfile = new frmUserProf(newUser_);
            UserProfile.ShowDialog();
        }

        private void btnSolveClear_Click_1(object sender, EventArgs e)
        {
            txtSolution.Clear();
            txtSolveTicketID.Clear();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtTicketID.Clear();
            txtEmail.Clear();
        }
    }
}
