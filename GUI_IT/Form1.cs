using System.Windows.Forms;

namespace GUI_IT
{
    public partial class FrmLogin : Form
    {
        private SessionRegister regSession;
        public FrmLogin()
        {
            InitializeComponent();
            pnlSignUp.Visible = false;
            regSession = new SessionRegister();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "password")
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
            else
            {
                MessageBox.Show("Incorrect Login Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            regSession.Email= txtEmail.Text;
            regSession.FirstName= txtFirstName.Text;
            regSession.LastName= txtLastName.Text;
            regSession.UserType= cboUserType.Text;
            lblTestEmail.Text= regSession.Email;
            lblTestFirstName.Text= regSession.FirstName;
            lblTestLastName.Text= regSession.LastName;
            lblTestUserType.Text= regSession.UserType;
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = false;
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = true;
            txtEmail.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
        }
    }
}