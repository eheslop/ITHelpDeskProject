namespace GUI_IT
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.lblFirstRegister = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkboxRemember = new System.Windows.Forms.CheckBox();
            this.linklblForgot = new System.Windows.Forms.LinkLabel();
            this.btnRegisterAccount = new System.Windows.Forms.Button();
            this.lblRegisterAccount = new System.Windows.Forms.Label();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.lblAlreadyExists = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.cboUserType = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.btnLoginForm = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlForgotPassword = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRememebr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnBacktoLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenEye = new System.Windows.Forms.Button();
            this.btnClosedEye = new System.Windows.Forms.Button();
            this.lblIncorrectLogin = new System.Windows.Forms.Label();
            this.lblInvalidRole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlForgotPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI_IT.Properties.Resources.redAgentsLogo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(775, 57);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 31);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(775, 26);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(-2, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(307, 29);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Red Agents IT Help Desk";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(258, 175);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(268, 32);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login To Your Account";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(300, 205);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Enter Username";
            this.txtUsername.Size = new System.Drawing.Size(186, 27);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(300, 236);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter Password";
            this.txtPassword.Size = new System.Drawing.Size(186, 27);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsernameLogin.Location = new System.Drawing.Point(197, 207);
            this.lblUsernameLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(99, 28);
            this.lblUsernameLogin.TabIndex = 8;
            this.lblUsernameLogin.Text = "Username";
            // 
            // lblFirstRegister
            // 
            this.lblFirstRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstRegister.AutoSize = true;
            this.lblFirstRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstRegister.Location = new System.Drawing.Point(203, 235);
            this.lblFirstRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstRegister.Name = "lblFirstRegister";
            this.lblFirstRegister.Size = new System.Drawing.Size(93, 28);
            this.lblFirstRegister.TabIndex = 9;
            this.lblFirstRegister.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(329, 267);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 36);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // checkboxRemember
            // 
            this.checkboxRemember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkboxRemember.AutoSize = true;
            this.checkboxRemember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkboxRemember.Location = new System.Drawing.Point(313, 307);
            this.checkboxRemember.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxRemember.Name = "checkboxRemember";
            this.checkboxRemember.Size = new System.Drawing.Size(144, 27);
            this.checkboxRemember.TabIndex = 11;
            this.checkboxRemember.Text = "Remember Me";
            this.checkboxRemember.UseVisualStyleBackColor = true;
            // 
            // linklblForgot
            // 
            this.linklblForgot.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.linklblForgot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linklblForgot.AutoSize = true;
            this.linklblForgot.Location = new System.Drawing.Point(526, 239);
            this.linklblForgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklblForgot.Name = "linklblForgot";
            this.linklblForgot.Size = new System.Drawing.Size(125, 20);
            this.linklblForgot.TabIndex = 12;
            this.linklblForgot.TabStop = true;
            this.linklblForgot.Text = "Forgot Password?";
            this.linklblForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblForgot_LinkClicked);
            // 
            // btnRegisterAccount
            // 
            this.btnRegisterAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterAccount.AutoSize = true;
            this.btnRegisterAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegisterAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisterAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterAccount.ForeColor = System.Drawing.Color.White;
            this.btnRegisterAccount.Location = new System.Drawing.Point(647, 60);
            this.btnRegisterAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterAccount.Name = "btnRegisterAccount";
            this.btnRegisterAccount.Size = new System.Drawing.Size(119, 30);
            this.btnRegisterAccount.TabIndex = 14;
            this.btnRegisterAccount.Text = "Register Here!";
            this.btnRegisterAccount.UseVisualStyleBackColor = false;
            this.btnRegisterAccount.Click += new System.EventHandler(this.btnRegisterAccount_Click);
            // 
            // lblRegisterAccount
            // 
            this.lblRegisterAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterAccount.AutoSize = true;
            this.lblRegisterAccount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterAccount.Location = new System.Drawing.Point(466, 67);
            this.lblRegisterAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterAccount.Name = "lblRegisterAccount";
            this.lblRegisterAccount.Size = new System.Drawing.Size(159, 19);
            this.lblRegisterAccount.TabIndex = 15;
            this.lblRegisterAccount.Text = "Don\'t Have An Account?";
            this.lblRegisterAccount.Click += new System.EventHandler(this.lblRegisterAccount_Click_2);
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSignUp.BackColor = System.Drawing.Color.Transparent;
            this.pnlSignUp.Controls.Add(this.lblAlreadyExists);
            this.pnlSignUp.Controls.Add(this.lblUserType);
            this.pnlSignUp.Controls.Add(this.cboUserType);
            this.pnlSignUp.Controls.Add(this.btnRegister);
            this.pnlSignUp.Controls.Add(this.lblLastName);
            this.pnlSignUp.Controls.Add(this.txtLastName);
            this.pnlSignUp.Controls.Add(this.lblSignIn);
            this.pnlSignUp.Controls.Add(this.btnLoginForm);
            this.pnlSignUp.Controls.Add(this.lblFirstName);
            this.pnlSignUp.Controls.Add(this.lblEmail);
            this.pnlSignUp.Controls.Add(this.txtFirstName);
            this.pnlSignUp.Controls.Add(this.txtEmail);
            this.pnlSignUp.Controls.Add(this.lblRegister);
            this.pnlSignUp.Controls.Add(this.pictureBox4);
            this.pnlSignUp.Location = new System.Drawing.Point(6, 60);
            this.pnlSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(760, 420);
            this.pnlSignUp.TabIndex = 16;
            // 
            // lblAlreadyExists
            // 
            this.lblAlreadyExists.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAlreadyExists.AutoSize = true;
            this.lblAlreadyExists.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAlreadyExists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAlreadyExists.Location = new System.Drawing.Point(103, 347);
            this.lblAlreadyExists.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlreadyExists.Name = "lblAlreadyExists";
            this.lblAlreadyExists.Size = new System.Drawing.Size(574, 46);
            this.lblAlreadyExists.TabIndex = 34;
            this.lblAlreadyExists.Text = "Account Already Exists: An account with that information already exists. \r\n      " +
    "          Please Try Again or contact a System Administrator.";
            this.lblAlreadyExists.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserType.Location = new System.Drawing.Point(155, 272);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(97, 28);
            this.lblUserType.TabIndex = 31;
            this.lblUserType.Text = "User Type";
            // 
            // cboUserType
            // 
            this.cboUserType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Items.AddRange(new object[] {
            "Admin",
            "Project Member",
            "IT Support Team",
            "Report Manager",
            "Admin",
            "Project Member",
            "IT Support Team",
            "Report Manager"});
            this.cboUserType.Location = new System.Drawing.Point(262, 272);
            this.cboUserType.Margin = new System.Windows.Forms.Padding(2);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(231, 28);
            this.cboUserType.TabIndex = 30;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(307, 309);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(133, 45);
            this.btnRegister.TabIndex = 29;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.lblRegisterAccount_Click_1);
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(155, 209);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 28);
            this.lblLastName.TabIndex = 28;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(262, 210);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.MaxLength = 45;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Enter Last Name";
            this.txtLastName.Size = new System.Drawing.Size(231, 27);
            this.txtLastName.TabIndex = 27;
            // 
            // lblSignIn
            // 
            this.lblSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignIn.Location = new System.Drawing.Point(448, 10);
            this.lblSignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(171, 19);
            this.lblSignIn.TabIndex = 26;
            this.lblSignIn.Text = "Already Have An Account?";
            this.lblSignIn.Click += new System.EventHandler(this.lblSignIn_Click_1);
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginForm.AutoSize = true;
            this.btnLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoginForm.ForeColor = System.Drawing.Color.White;
            this.btnLoginForm.Location = new System.Drawing.Point(636, 2);
            this.btnLoginForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(122, 32);
            this.btnLoginForm.TabIndex = 25;
            this.btnLoginForm.Text = "Login Here!";
            this.btnLoginForm.UseVisualStyleBackColor = false;
            this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click_1);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(153, 178);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 28);
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.Text = "First Name";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(155, 243);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 28);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(262, 178);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.MaxLength = 45;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Enter First Name";
            this.txtFirstName.Size = new System.Drawing.Size(231, 27);
            this.txtFirstName.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(262, 241);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Enter Email";
            this.txtEmail.Size = new System.Drawing.Size(231, 27);
            this.txtEmail.TabIndex = 18;
            // 
            // lblRegister
            // 
            this.lblRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRegister.Location = new System.Drawing.Point(219, 138);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(306, 32);
            this.lblRegister.TabIndex = 17;
            this.lblRegister.Text = "Register For Your Account";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::GUI_IT.Properties.Resources.redAgentsLogo;
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(322, 38);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 99);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pnlForgotPassword
            // 
            this.pnlForgotPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForgotPassword.AutoSize = true;
            this.pnlForgotPassword.Controls.Add(this.label2);
            this.pnlForgotPassword.Controls.Add(this.lblRememebr);
            this.pnlForgotPassword.Controls.Add(this.textBox1);
            this.pnlForgotPassword.Controls.Add(this.pictureBox5);
            this.pnlForgotPassword.Controls.Add(this.btnBacktoLogin);
            this.pnlForgotPassword.Controls.Add(this.button1);
            this.pnlForgotPassword.Controls.Add(this.label1);
            this.pnlForgotPassword.Location = new System.Drawing.Point(6, 60);
            this.pnlForgotPassword.Name = "pnlForgotPassword";
            this.pnlForgotPassword.Size = new System.Drawing.Size(760, 428);
            this.pnlForgotPassword.TabIndex = 12;
            this.pnlForgotPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlForgotPassword_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(234, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Send a Verification Email";
            // 
            // lblRememebr
            // 
            this.lblRememebr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRememebr.AutoSize = true;
            this.lblRememebr.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRememebr.Location = new System.Drawing.Point(502, 13);
            this.lblRememebr.Name = "lblRememebr";
            this.lblRememebr.Size = new System.Drawing.Size(143, 19);
            this.lblRememebr.TabIndex = 5;
            this.lblRememebr.Text = "Remember Password?";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(242, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Enter Email";
            this.textBox1.Size = new System.Drawing.Size(266, 27);
            this.textBox1.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackgroundImage = global::GUI_IT.Properties.Resources.redAgentsLogo;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(323, 69);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(111, 106);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // btnBacktoLogin
            // 
            this.btnBacktoLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBacktoLogin.AutoSize = true;
            this.btnBacktoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBacktoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBacktoLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBacktoLogin.ForeColor = System.Drawing.Color.White;
            this.btnBacktoLogin.Location = new System.Drawing.Point(660, 3);
            this.btnBacktoLogin.Name = "btnBacktoLogin";
            this.btnBacktoLogin.Size = new System.Drawing.Size(100, 30);
            this.btnBacktoLogin.TabIndex = 2;
            this.btnBacktoLogin.Text = "Login Here!";
            this.btnBacktoLogin.UseVisualStyleBackColor = false;
            this.btnBacktoLogin.Click += new System.EventHandler(this.btnBacktoLogin_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(294, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send Verification";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Email";
            // 
            // btnOpenEye
            // 
            this.btnOpenEye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenEye.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenEye.BackgroundImage = global::GUI_IT.Properties.Resources.openEye;
            this.btnOpenEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenEye.Location = new System.Drawing.Point(490, 264);
            this.btnOpenEye.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenEye.Name = "btnOpenEye";
            this.btnOpenEye.Size = new System.Drawing.Size(32, 23);
            this.btnOpenEye.TabIndex = 18;
            this.btnOpenEye.TabStop = false;
            this.btnOpenEye.UseVisualStyleBackColor = false;
            // 
            // btnClosedEye
            // 
            this.btnClosedEye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosedEye.BackColor = System.Drawing.Color.White;
            this.btnClosedEye.BackgroundImage = global::GUI_IT.Properties.Resources.closedEye;
            this.btnClosedEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClosedEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosedEye.Location = new System.Drawing.Point(490, 236);
            this.btnClosedEye.Margin = new System.Windows.Forms.Padding(2);
            this.btnClosedEye.Name = "btnClosedEye";
            this.btnClosedEye.Size = new System.Drawing.Size(32, 24);
            this.btnClosedEye.TabIndex = 19;
            this.btnClosedEye.TabStop = false;
            this.btnClosedEye.UseVisualStyleBackColor = false;
            // 
            // lblIncorrectLogin
            // 
            this.lblIncorrectLogin.AutoSize = true;
            this.lblIncorrectLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblIncorrectLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIncorrectLogin.Location = new System.Drawing.Point(172, 408);
            this.lblIncorrectLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncorrectLogin.Name = "lblIncorrectLogin";
            this.lblIncorrectLogin.Size = new System.Drawing.Size(440, 46);
            this.lblIncorrectLogin.TabIndex = 20;
            this.lblIncorrectLogin.Text = "Incorrect Login Information: The username or password \r\n            you entered i" +
    "s incorrect, please try again.";
            this.lblIncorrectLogin.Visible = false;
            // 
            // lblInvalidRole
            // 
            this.lblInvalidRole.AutoSize = true;
            this.lblInvalidRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInvalidRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidRole.Location = new System.Drawing.Point(186, 408);
            this.lblInvalidRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvalidRole.Name = "lblInvalidRole";
            this.lblInvalidRole.Size = new System.Drawing.Size(403, 23);
            this.lblInvalidRole.TabIndex = 33;
            this.lblInvalidRole.Text = "Invalid Role: Please contact System Administrator. ";
            this.lblInvalidRole.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 489);
            this.Controls.Add(this.pnlForgotPassword);
            this.Controls.Add(this.pnlSignUp);
            this.Controls.Add(this.lblRegisterAccount);
            this.Controls.Add(this.linklblForgot);
            this.Controls.Add(this.lblInvalidRole);
            this.Controls.Add(this.lblIncorrectLogin);
            this.Controls.Add(this.btnClosedEye);
            this.Controls.Add(this.btnOpenEye);
            this.Controls.Add(this.btnRegisterAccount);
            this.Controls.Add(this.checkboxRemember);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblFirstRegister);
            this.Controls.Add(this.lblUsernameLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLogin";
            this.Text = "IT Help Desk Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Resize += new System.EventHandler(this.FrmLogin_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlForgotPassword.ResumeLayout(false);
            this.pnlForgotPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Panel pnlForgotPassword;
        private Label lblRememebr;
        private TextBox textBox1;
        private PictureBox pictureBox5;
        private Button btnBacktoLogin;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button btnOpenEye;
        private Button btnClosedEye;
        private Label lblIncorrectLogin;
        private Label lblInvalidRole;
        private Label lblAlreadyExists;
    }
}