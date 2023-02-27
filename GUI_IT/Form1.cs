using System.Windows.Forms;
using System;
using Microsoft.Data.SqlClient;
using System.Text;

namespace GUI_IT
{
    public partial class FrmLogin : Form
    {
      //  private Rectangle buttonOriginalRectangle;
       // private Rectangle originalFormSize;
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
            if(exists == 0)
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
            string user = name[0].ToString() + txtLastName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string role = cboUserType.Text.ToString();
            Random res = new Random();
            String str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int size = 8;
            String randomstring = "";
            for (int i = 0; i < size; i++)
            {
                int x = res.Next(str.Length);
                randomstring = randomstring + str[x];
            }
            string pass = randomstring.ToString();
            Sql.Register(user, name, pass, email, role);
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

        //nobody touch this!!!
        private void FrmLogin_Load(object sender, EventArgs e)
        {
          //  originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
          //  buttonOriginalRectangle=new Rectangle(btnRegisterAccount.Location.X, btnRegisterAccount.Location.Y, btnRegisterAccount.Width, btnRegisterAccount.Height);
        }

       /* private void resizeControl(Rectangle r, Control c)
        {
            float xRatio=(float)(this.Width)/(float)(originalFormSize.Width);
            float yRatio=(float)(this.Height)/(float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth=(int)(r.Width * xRatio);
            int newHeight=(int)(r.Height * yRatio);

            c.Location = new Point(newX, newY); 
            c.Size=new Size(newWidth, newHeight);
        }
        */private void FrmLogin_Resize(object sender, EventArgs e)
        {
          //  resizeControl(buttonOriginalRectangle, btnRegisterAccount);
        }
    }
}