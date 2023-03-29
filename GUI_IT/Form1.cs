using System.Windows.Forms;
using System;
using Microsoft.Data.SqlClient;
using System.Text;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net.Mail;
using Microsoft.Identity.Client;

namespace GUI_IT
{
    public partial class FrmLogin : Form
    {
        private SessionRegister newUser;

        public FrmLogin()
        {
            InitializeComponent();
            newUser = new SessionRegister();
            pnlSignUp.Visible = false;
            pnlForgotPassword.Visible = false;
            lblIncorrectLogin.Visible = false;
            lblInvalidRole.Visible = false;
            lblAlreadyExists.Visible = false;
            btnOpenEye.FlatAppearance.BorderSize = 0;
            btnOpenEye.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnClosedEye.FlatAppearance.BorderSize = 0;
            btnClosedEye.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            newUser.Username = txtUsername.Text.ToString();
            newUser.Password = txtPassword.Text.ToString();
            newUser.Email = Sql.getEmail(newUser.Username);
            newUser.FirstName = Sql.getName(newUser.Username);
            newUser.FullName = Sql.getfullName(newUser.Username);
            int exists = Sql.Login(newUser.Username, newUser.Password);
            if (exists == 0)
            {
                newUser.UserType = Sql.Role(newUser.Username);
                if (newUser.UserType == "Admin")
                {
                    frmAdmin adminLogIn = new frmAdmin(newUser);
                    this.Hide();
                    adminLogIn.ShowDialog();
                    this.Close();
                }
                else if (newUser.UserType == "Project Member")
                {
                    frmProjectMember projectMemberForm = new frmProjectMember(newUser);
                    this.Hide();
                    projectMemberForm.ShowDialog();
                    this.Close();
                }
                else if (newUser.UserType == "IT Support Team")
                {
                    frmITSupport ITSupportForm = new frmITSupport(newUser);
                    this.Hide();
                    ITSupportForm.ShowDialog();
                    this.Close();
                }
                else if (newUser.UserType == "Report Manager")
                {
                    frmReportManage ReportManageForm = new frmReportManage(newUser);
                    this.Hide();
                    ReportManageForm.ShowDialog();
                    this.Close();
                }
                else
                    //MessageBox.Show("Invalid Role! Contact System Administrator!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblInvalidRole.Visible = true;

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
                //MessageBox.Show("Incorrect Login Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblIncorrectLogin.Visible = true;
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Random res1 = new Random();
            String str1 = "0123456789";
            int size1 = 4;
            String randomstring1 = "";
            for (int i = 0; i < size1; i++)
            {
                int x = res1.Next(str1.Length);
                randomstring1 = randomstring1 + str1[x];
            }
            string name = txtFirstName.Text.ToString() + " " + txtLastName.Text.ToString();
            string first = txtFirstName.Text.ToString();
            string last = txtLastName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string role = cboUserType.Text.ToString();
            string user = name[0].ToString() + txtLastName.Text.ToString() + randomstring1.ToString();
            Boolean accountExists = Sql.Exists(user);
            Boolean validEmail = Email.isValid(email);
            if (accountExists == false && validEmail == true)
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
                Sql.Register(user, name, first, last, pass, email, role);
                Email.sendEmail("Registration", user);
                MessageBox.Show("Account Created!\nCheck your email for your login credentials!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pnlSignUp.Visible = false;
                //pnlForgotPassword.Visible = false;

            }
            else if (accountExists == true)
            {
                //MessageBox.Show("Account Already Exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblAlreadyExists.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Email!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = false;
            pnlForgotPassword.Visible = false;
            lblIncorrectLogin.Visible = false;
            lblInvalidRole.Visible = false;
            lblAlreadyExists.Visible = false;
            this.Text = "IT Help Desk Login";
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = true;
            pnlForgotPassword.Visible = false;
            lblIncorrectLogin.Visible = false;
            lblInvalidRole.Visible = false;
            lblAlreadyExists.Visible = false;
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
            lblIncorrectLogin.Visible = false;
            lblInvalidRole.Visible = false;
            lblAlreadyExists.Visible = false;
            this.Text = "IT Help Desk Forgot Password";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenEye_Click(object sender, EventArgs e)
        {
            btnOpenEye.Visible = false;
            btnClosedEye.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnClosedEye_Click(object sender, EventArgs e)
        {
            btnOpenEye.Visible = true;
            btnClosedEye.Visible = false;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void lblAlreadyExists_Click(object sender, EventArgs e)
        {

        }
    }
}
