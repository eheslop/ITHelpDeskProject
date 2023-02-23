﻿namespace GUI_IT
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblHeader = new Label();
            lblLogin = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsernameLogin = new Label();
            lblFirstRegister = new Label();
            btnLogin = new Button();
            checkboxRemember = new CheckBox();
            linklblForgot = new LinkLabel();
            btnRegisterAccount = new Button();
            lblRegisterAccount = new Label();
            pnlSignUp = new Panel();
            lblUserType = new Label();
            cboUserType = new ComboBox();
            btnRegister = new Button();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblSignIn = new Label();
            btnLoginForm = new Button();
            lblFirstName = new Label();
            lblEmail = new Label();
            txtFirstName = new TextBox();
            txtEmail = new TextBox();
            lblRegister = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.redAgentsLogo;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(460, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox2.Location = new Point(-4, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1125, 79);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Location = new Point(-4, 61);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1125, 51);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(64, 0, 0);
            lblHeader.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(445, 40);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Red Agents IT Help Desk";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLogin.Location = new Point(386, 315);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(314, 38);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login To Your Account";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(360, 366);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.Size = new Size(359, 31);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(360, 420);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(359, 31);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsernameLogin
            // 
            lblUsernameLogin.AutoSize = true;
            lblUsernameLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameLogin.Location = new Point(233, 366);
            lblUsernameLogin.Name = "lblUsernameLogin";
            lblUsernameLogin.Size = new Size(121, 32);
            lblUsernameLogin.TabIndex = 8;
            lblUsernameLogin.Text = "Username";
            // 
            // lblFirstRegister
            // 
            lblFirstRegister.AutoSize = true;
            lblFirstRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstRegister.Location = new Point(243, 420);
            lblFirstRegister.Name = "lblFirstRegister";
            lblFirstRegister.Size = new Size(111, 32);
            lblFirstRegister.TabIndex = 9;
            lblFirstRegister.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(64, 0, 0);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(437, 471);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(208, 70);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkboxRemember
            // 
            checkboxRemember.AutoSize = true;
            checkboxRemember.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkboxRemember.Location = new Point(460, 547);
            checkboxRemember.Name = "checkboxRemember";
            checkboxRemember.Size = new Size(165, 32);
            checkboxRemember.TabIndex = 11;
            checkboxRemember.Text = "Remember Me";
            checkboxRemember.UseVisualStyleBackColor = true;
            // 
            // linklblForgot
            // 
            linklblForgot.ActiveLinkColor = Color.DarkMagenta;
            linklblForgot.AutoSize = true;
            linklblForgot.Location = new Point(725, 423);
            linklblForgot.Name = "linklblForgot";
            linklblForgot.Size = new Size(154, 25);
            linklblForgot.TabIndex = 12;
            linklblForgot.TabStop = true;
            linklblForgot.Text = "Forgot Password?";
            // 
            // btnRegisterAccount
            // 
            btnRegisterAccount.BackColor = Color.FromArgb(64, 0, 0);
            btnRegisterAccount.FlatStyle = FlatStyle.Popup;
            btnRegisterAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisterAccount.ForeColor = Color.White;
            btnRegisterAccount.Location = new Point(953, 118);
            btnRegisterAccount.Name = "btnRegisterAccount";
            btnRegisterAccount.Size = new Size(149, 39);
            btnRegisterAccount.TabIndex = 14;
            btnRegisterAccount.Text = "Register Here!";
            btnRegisterAccount.UseVisualStyleBackColor = false;
            btnRegisterAccount.Click += btnRegisterAccount_Click;
            // 
            // lblRegisterAccount
            // 
            lblRegisterAccount.AutoSize = true;
            lblRegisterAccount.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegisterAccount.Location = new Point(775, 128);
            lblRegisterAccount.Name = "lblRegisterAccount";
            lblRegisterAccount.Size = new Size(177, 21);
            lblRegisterAccount.TabIndex = 15;
            lblRegisterAccount.Text = "Don't Have An Account?";
            // 
            // pnlSignUp
            // 
            pnlSignUp.BackColor = Color.Transparent;
            pnlSignUp.Controls.Add(lblUserType);
            pnlSignUp.Controls.Add(cboUserType);
            pnlSignUp.Controls.Add(btnRegister);
            pnlSignUp.Controls.Add(lblLastName);
            pnlSignUp.Controls.Add(txtLastName);
            pnlSignUp.Controls.Add(lblSignIn);
            pnlSignUp.Controls.Add(btnLoginForm);
            pnlSignUp.Controls.Add(lblFirstName);
            pnlSignUp.Controls.Add(lblEmail);
            pnlSignUp.Controls.Add(txtFirstName);
            pnlSignUp.Controls.Add(txtEmail);
            pnlSignUp.Controls.Add(lblRegister);
            pnlSignUp.Controls.Add(pictureBox4);
            pnlSignUp.Location = new Point(-4, 111);
            pnlSignUp.Name = "pnlSignUp";
            pnlSignUp.Size = new Size(1125, 555);
            pnlSignUp.TabIndex = 16;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserType.Location = new Point(247, 361);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(119, 32);
            lblUserType.TabIndex = 31;
            lblUserType.Text = "User Type";
            // 
            // cboUserType
            // 
            cboUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUserType.FormattingEnabled = true;
            cboUserType.Items.AddRange(new object[] { "Admin", "Project Member", "IT Support Team", "Report Manager" });
            cboUserType.Location = new Point(369, 360);
            cboUserType.Name = "cboUserType";
            cboUserType.Size = new Size(359, 33);
            cboUserType.TabIndex = 30;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(64, 0, 0);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(441, 417);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(208, 70);
            btnRegister.TabIndex = 29;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(240, 312);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(126, 32);
            lblLastName.TabIndex = 28;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(369, 312);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Enter Last Name";
            txtLastName.Size = new Size(359, 31);
            txtLastName.TabIndex = 27;
            // 
            // lblSignIn
            // 
            lblSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSignIn.Location = new Point(764, 19);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(192, 21);
            lblSignIn.TabIndex = 26;
            lblSignIn.Text = "Already Have An Account?";
            // 
            // btnLoginForm
            // 
            btnLoginForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLoginForm.BackColor = Color.FromArgb(64, 0, 0);
            btnLoginForm.FlatStyle = FlatStyle.Popup;
            btnLoginForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoginForm.ForeColor = Color.White;
            btnLoginForm.Location = new Point(957, 6);
            btnLoginForm.Name = "btnLoginForm";
            btnLoginForm.Size = new Size(149, 39);
            btnLoginForm.TabIndex = 25;
            btnLoginForm.Text = "Login Here!";
            btnLoginForm.UseVisualStyleBackColor = false;
            btnLoginForm.Click += btnLoginForm_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(237, 263);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(129, 32);
            lblFirstName.TabIndex = 21;
            lblFirstName.Text = "First Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(292, 217);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "Email";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(369, 264);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Enter First Name";
            txtFirstName.Size = new Size(359, 31);
            txtFirstName.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(369, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email";
            txtEmail.Size = new Size(359, 31);
            txtEmail.TabIndex = 18;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRegister.Location = new Point(369, 166);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(359, 38);
            lblRegister.TabIndex = 17;
            lblRegister.Text = "Register For Your Account";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.redAgentsLogo;
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(464, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(168, 155);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1114, 678);
            Controls.Add(pnlSignUp);
            Controls.Add(lblRegisterAccount);
            Controls.Add(btnRegisterAccount);
            Controls.Add(linklblForgot);
            Controls.Add(checkboxRemember);
            Controls.Add(btnLogin);
            Controls.Add(lblFirstRegister);
            Controls.Add(lblUsernameLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblLogin);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            Text = "IT Help Desk Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlSignUp.ResumeLayout(false);
            pnlSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblHeader;
        private Label lblLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsernameLogin;
        private Label lblFirstRegister;
        private Button btnLogin;
        private CheckBox checkboxRemember;
        private LinkLabel linklblForgot;
        private Button btnRegisterAccount;
        private Label lblRegisterAccount;
        private Panel pnlSignUp;
        private Label lblSignIn;
        private Button btnLoginForm;
        private Label lblFirstName;
        private Label lblEmail;
        private TextBox txtFirstName;
        private TextBox txtEmail;
        private Label lblRegister;
        private PictureBox pictureBox4;
        private TextBox txtLastName;
        private Label lblLastName;
        private Button btnRegister;
        private ComboBox cboUserType;
        private Label lblUserType;
    }
}