using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_IT
{
    public partial class frmstatusUpdate : Form
    {
        public frmstatusUpdate()
        {
            InitializeComponent();
            nxtuser();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string name = Sql.retName();
            string email = Sql.retEmail();
            string role = Sql.rerole();
            string user = Sql.retUser();
            string pass = Sql.repass();
            Email.sendEmail("Registration Accepted", user);
            Sql.Regis(user, name, pass, email, role);
            Sql.delete(user);
            nxtuser();

        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            string user = Sql.retUser();
            Email.sendEmail("Registration Denied", user);
            Sql.delete(user);
            nxtuser();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {


        }

        private void lblfirstName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nxtuser()
        {
            string name = Sql.retName();
            txtname.Text = name;
            string email = Sql.retEmail();
            textemail.Text = email;
            string role = Sql.rerole();
            textrole.Text = role;
            string user = Sql.retUser();
            txtuser.Text = user;
        }
    }
}
