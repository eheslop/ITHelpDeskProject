﻿using System;
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
            combo();
            lblUser.Text = newUser_.FirstName + "!";
            lblLoggedIn.Text = "Logged in as: " + newUser_.FirstName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Fill()
        {
            string x = "Unsolved";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string query = "Select * from Tickets where Status = '" + x + "'; ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVT.DataSource = dt;
            con.Close();
        }

        private void combo()
        {
            cbxname.DataSource = Sql.ITname();
            cbxname.DisplayMember = "Name";
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
            string query = "Select * from Tickets where Status = '" + x + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVAssign.DataSource = dt;
            DGVAssign.EditMode = DataGridViewEditMode.EditOnEnter;
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
            string query = "Select * from Tickets where Status = '" + x + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVT.DataSource = dt;
            DGVAssign.EditMode = DataGridViewEditMode.EditOnEnter;
            con.Close();

        }

        private void DGVT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
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

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtTicketID.Clear();
            txtEmail.Clear();
        }

        private void btnAssign_Click_1(object sender, EventArgs e)
        {
            string x = txtTicketID.Text.ToString();
            int y = System.Convert.ToInt32(x);
            string k = cbxn.Text.ToString();
            string z = Sql.getUser(k);
            string f = txtEmail.Text.ToString();
            Sql.Addcoll(z, y);
            Sql.add2(z, y, f);
        }

        private void btnUnsolved_Click_1(object sender, EventArgs e)
        {
            Fill();
        }

        private void btnSolved_Click_1(object sender, EventArgs e)
        {
            Fill2();
        }

        private void btnViewUnsolvedTable_Click(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
