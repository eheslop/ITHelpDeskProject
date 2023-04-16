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
using Microsoft.VisualBasic.ApplicationServices;

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
            combo1();
            combo2();
        }


        private void Fill1()
        {
            string x = newUser_.Username;

            Shared.DataSource = Sql.Sharedd(x);
            //GVS.EditMode = DataGridViewEditMode.EditOnEnter;

        }

        private void combo()
        {
            cbxn.DataSource = Sql.ITname();
            cbxn.DisplayMember = "Name";
        }

        private void Fill2()
        {
            string x = newUser_.Username;
            string y = "Solved";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string query = "Select * from Tickets where AssignedTo = '" + x + "' and Status != '" + y + "'; ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //DGVS.DataSource = dt;
            DGVShare.DataSource = dt;
            DGVShare.EditMode = DataGridViewEditMode.EditOnEnter;
            con.Close();

        }


        private void combo1()
        {
            cbxid.DataSource = Sql.Shareddd(newUser_.Username);
            cbxid.DisplayMember = "Id";
        }

        private void combo2()
        {
            cbxid2.DataSource = Sql.ticketsSolved(newUser_.Username);
            cbxid2.DisplayMember = "Id";
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

        private void btnSolveClear_Click(object sender, EventArgs e)
        {
            txtSolution.Clear();
            cbxid.ResetText();
            cbxid.SelectedIndex = -1;
        }

        private void btnSolveTicket_Click(object sender, EventArgs e)
        {
            string x = cbxid.Text.ToString();
            int y = System.Convert.ToInt32(x);
            string z = Sql.tickuser(y);
            string k = Sql.tickemail(y);
            string j = txtSolution.Text.ToString();
            Sql.solve(y, newUser_.Username, z, k, j);
            MessageBox.Show("Your solution for the ticket of your choosing has now been submitted, thank you.", "Ticket Solved Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Email.sendEmail("Solved Ticket", newUser_.Username, 0, Convert.ToInt32(x));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            cbxid2.ResetText();
            cbxid2.SelectedIndex = -1;
            cbxn.ResetText();
            cbxn.SelectedIndex = -1;
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            string x = cbxid2.Text.ToString();
            int y = System.Convert.ToInt32(x);
            string a = cbxn.Text.ToString();
            string b = Sql.getUser(a);
            string c = txtEmail.Text.ToString();
            Sql.Addcoll(b, y);
            Sql.add2(b, y, c);
            MessageBox.Show("The ticket you wished to share has now been sent to the user of your choosing.", "Ticket Shared Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmITSupport_Load(object sender, EventArgs e)
        {

        }
    }
}
