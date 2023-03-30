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
    public partial class frmReportManage : Form
    {
        private SessionRegister newUser_;

        public frmReportManage(SessionRegister newUser)
        {
            newUser_ = newUser;
            InitializeComponent();
            Fill();
            Fill1();
            lblUser.Text = newUser_.FirstName + "!";
            lblLoggedIn.Text = "Logged in as: " + newUser_.FirstName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin LoginScreen = new FrmLogin();
            this.Hide();
            LoginScreen.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            string query = "Select * from Tickets";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVT.DataSource = dt;
            con.Close();
        }

        private void lblLoggedIn_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            frmUserProf UserProfile = new frmUserProf(newUser_);
            UserProfile.ShowDialog();
        }

        private void txtTicketID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string x = txtTicketID.Text.ToString();
            int y = System.Convert.ToInt32(x);
            string z = txtUsername.Text.ToString();
            string f = txtEmail.Text.ToString();
            Sql.Addcoll(z, y);
            Sql.add2(z, y, f);
        }

        private void Fill1()
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
            DGVAssign.DataSource = dt;
            DGVAssign.EditMode = DataGridViewEditMode.EditOnEnter;
            con.Close();

        }

        private void tabAssign_Click(object sender, EventArgs e)
        {

        }
    }
}
private void btnClear_Click(object sender, EventArgs e)
{
    txtTicketID.Clear();
    txtUsername.Clear();
    txtEmail.Clear();
}
    }
}
