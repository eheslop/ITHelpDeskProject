using System.Windows.Forms;
using System;
using Microsoft.Data.SqlClient;
using System.Text;

namespace GUI_IT
{
    public partial class FrmLogin : Form
    {
        private Rectangle buttonRegRect;
        private Rectangle textBoxUsername;
        private Rectangle textBoxPassword;
        private Rectangle LabelDHAA;
        private Rectangle LoginButton;
        private Rectangle PasswordLabel;
        private Rectangle UsernameLabel;
        private Rectangle CheckBoxRemember;
        private Rectangle LinkLabelForgot;
        private Rectangle Picture;
        private Rectangle labelLogin;

        private Rectangle OriginalFormSize;

        private float originalLabelDHAASize;
        private float originaRegRectangleFSize;
        private float originaltextUsernameFSize;
        private float originaltextPasswordFSize;
        private float originalButtonLoginFSize;
        private float originalLabelPasswordFSize;
        private float originalLabelUsernameFSize;
        private float originalCheckBoxFSize;
        private float originalLinkLabelForgotFSize;
        private float originallabelLoginFSize;


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

                MessageBox.Show("Your Account Has Been Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lblSignIn_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBacktoLogin_Click(object sender, EventArgs e)
        {

        }

        private void pnlForgotPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            OriginalFormSize =new Rectangle(this.Location.X, this.Location.Y, this.Size.Width,this.Size.Height);
            buttonRegRect = new Rectangle(btnRegisterAccount.Location.X, btnRegisterAccount.Location.Y, btnRegisterAccount.Width, btnRegisterAccount.Height);
            textBoxUsername=new Rectangle(txtUsername.Location.X,txtUsername.Location.Y, txtUsername.Width, txtUsername.Height);
            textBoxPassword=new Rectangle(txtPassword.Location.X,txtPassword.Location.Y,txtPassword.Width, txtPassword.Height);
            LabelDHAA = new Rectangle(lblRegisterAccount.Location.X, lblRegisterAccount.Location.Y, lblRegisterAccount.Width, lblRegisterAccount.Height);
            LoginButton=new Rectangle(btnLogin.Location.X, btnLogin.Location.Y, btnLogin.Width,btnLogin.Height);
            PasswordLabel = new Rectangle(lblFirstRegister.Location.X, lblFirstRegister.Location.Y, lblFirstRegister.Width, lblFirstRegister.Height);
            UsernameLabel=new Rectangle (lblUsernameLogin.Location.X, lblUsernameLogin.Location.Y, lblUsernameLogin.Width,lblUsernameLogin.Height);
            CheckBoxRemember = new Rectangle(checkboxRemember.Location.X, checkboxRemember.Location.Y, checkboxRemember.Width, checkboxRemember.Height);
            LinkLabelForgot = new Rectangle(linklblForgot.Location.X, linklblForgot.Location.Y, linklblForgot.Width, linklblForgot.Height);
            Picture=new Rectangle(pictureBox1.Location.X,pictureBox1.Location.Y,pictureBox1.Width,pictureBox1.Height);
            labelLogin = new Rectangle(lblLogin.Location.X, lblLogin.Location.Y, lblLogin.Width, lblLogin.Height);

            originaRegRectangleFSize = btnRegisterAccount.Font.Size;
            originalLabelDHAASize = lblRegisterAccount.Font.Size;
            originaltextUsernameFSize = txtUsername.Font.Size;
            originaltextPasswordFSize = txtPassword.Font.Size;
            originalLabelUsernameFSize= lblUsernameLogin.Font.Size;
            originalLabelPasswordFSize = lblFirstRegister.Font.Size;
            originalCheckBoxFSize = checkboxRemember.Font.Size;
            originalLinkLabelForgotFSize = linklblForgot.Font.Size;
            originallabelLoginFSize = lblLogin.Font.Size;

        }
        private void resizeControl(Rectangle r, Control c, float originalFontSize)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalFormSize.Height);

            int newX=(int)(r.Location.X*xRatio);
            int newY=(int)(r.Location.Y*yRatio);

            int newWidth=(int)(r.Width*xRatio);
            int newHeight=(int)(r.Height*yRatio);

            c.Location=new Point(newX, newY);
            c.Size=new Size(newWidth, newHeight);

           /* float ratio = xRatio; 
            if(xRatio>=yRatio)
            {
                ratio = yRatio;
            }

            float newFontSize = originalFontSize * ratio;

            Font newFont = new Font(Control.DefaultFont.FontFamily, newFontSize);
            Font= newFont;*/
        }


       /* private void resizecontroltwo(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio + 30);
            int newY = (int)(r.Location.Y * yRatio - 50);
            c.Location = new Point(newX, newY);
        }*/
        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            resizeControl(buttonRegRect, btnRegisterAccount, originaRegRectangleFSize);
            resizeControl(textBoxUsername, txtUsername, originaltextUsernameFSize);
            resizeControl(textBoxPassword, txtPassword, originaltextPasswordFSize);
            resizeControl(LabelDHAA, lblRegisterAccount, originalLabelDHAASize);
            resizeControl(LoginButton, btnLogin, originalButtonLoginFSize);
            resizeControl(labelLogin, lblLogin, originallabelLoginFSize);

            resizeControl(PasswordLabel, lblFirstRegister, originalLabelPasswordFSize);
            resizeControl(UsernameLabel, lblUsernameLogin, originalLabelUsernameFSize);
            resizeControl(CheckBoxRemember, checkboxRemember, originalCheckBoxFSize);
            resizeControl(LinkLabelForgot, linklblForgot, originalLinkLabelForgotFSize);
            resizeControl(Picture, pictureBox1,originalLabelDHAASize);
        }

        private void lblRegisterAccount_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}