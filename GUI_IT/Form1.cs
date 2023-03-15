using System.Windows.Forms;
using System;
using Microsoft.Data.SqlClient;
using System.Text;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace GUI_IT
{
    public partial class FrmLogin : Form
    {
        private SessionRegister regSession;
        public FrmLogin()
        {
            InitializeComponent();
            pnlSignUp.Visible = false;
            pnlForgotPassword.Visible = false;
            regSession = new SessionRegister();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();
            int exists = Sql.Login(user, password);
            if (exists == 0)
            {
                string role = Sql.Role(user);
                if (role == "Admin")
                {
                    frmAdmin adminLogIn = new frmAdmin();
                    this.Hide();
                    adminLogIn.ShowDialog();
                    this.Close();
                }
                else if (role == "Project Member")
                {
                    frmProjectMember projectMemberForm = new frmProjectMember();
                    this.Hide();
                    projectMemberForm.ShowDialog();
                    this.Close();
                }
                else if (role == "IT Support Team")
                {
                    // WIP
                    MessageBox.Show("Work In Progress!");
                }
                else if (role == "Report Manager")
                {
                    // WIP
                    MessageBox.Show("Work In Progress!");
                }
                else
                    MessageBox.Show("Invalid Role! Contact System Administrator!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            /* if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            {
                frmAdmin adminLogIn = new frmAdmin();
                this.Hide();
                adminLogIn.ShowDialog();
                this.Close();
            }
            else if (txtUsername.Text == "projectMem" && txtPassword.Text == "member")
            {
                frmProjectMember projectMemberForm = new frmProjectMember();
                this.Hide();
                projectMemberForm.ShowDialog();
                this.Close();
            }
            */
            else
            {
                MessageBox.Show("Incorrect Login Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtFirstName.Text.ToString() + " " + txtLastName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string role = cboUserType.Text.ToString();
            string user = name[0].ToString() + txtLastName.Text.ToString();

            Boolean accountExists = Sql.Exists(user);
            if (accountExists == false)
            {
                Random res = new Random();
                String str = "ABCDEFGHIJOPQRSTUVWXsYZ0123489!@#$%^&*?><abcdefghijklmnopqrswxyz0123456789";
                int size = 8;
                String randomstring = "";
                for (int i = 0; i < size; i++)
                {
                    int x = res.Next(str.Length);
                    randomstring = randomstring + str[x];
                }
                string pass = randomstring.ToString();
                Sql.Register(user, name, pass, email, role);
                Email.regEmail(user);
                MessageBox.Show("Account Created!\nCheck your email for your login credentials!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pnlSignUp.Visible = false;
                //pnlForgotPassword.Visible = false;

            }
            else
            {
                MessageBox.Show("Account Already Exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = false;
            pnlForgotPassword.Visible = false;
            this.Text = "IT Help Desk Login";
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = true;
            pnlForgotPassword.Visible = false;
            this.Text = "IT Help Desk Registration";
            txtEmail.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
        }

        private void lblRegisterAccount_Click(object sender, EventArgs e)
        {

        }

        private void pnlSignUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {

        }

        private void lblRegisterAccount_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linklblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlForgotPassword.Visible = true;
            pnlSignUp.Visible = false;
            this.Text = "IT Help Desk Forgot Password";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
