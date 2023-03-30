namespace GUI_IT
{
    partial class frmITSupport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmITSupport));
            pictureLogo = new PictureBox();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            Rectangle1 = new PictureBox();
            lblHeader = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            tabControl1 = new TabControl();
            tabHome = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox8 = new PictureBox();
            lblDescribeHome = new Label();
            lblUser = new Label();
            lblWelcomeMessage = new Label();
            tabSolve = new TabPage();
            txtSolveTicketID = new TextBox();
            btnSolveTicket = new Button();
            btnSolveClear = new Button();
            txtSolution = new TextBox();
            pictureBox6 = new PictureBox();
            DGVS = new DataGridView();
            lblSolve = new Label();
            lblTicketID = new Label();
            pictureBox9 = new PictureBox();
            tabShare = new TabPage();
            DGVShare = new DataGridView();
            btnShare = new Button();
            btnClear = new Button();
            txtUsername = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtTicketID = new TextBox();
            label6 = new Label();
            lblShare = new Label();
            pictureBox5 = new PictureBox();
            ProfilePictureBox = new PictureBox();
            lblLoggedIn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            tabSolve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            tabShare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVShare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Black;
            pictureLogo.Image = Properties.Resources.redAgentsLogo;
            pictureLogo.Location = new Point(8, 42);
            pictureLogo.Margin = new Padding(2);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(52, 44);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 32;
            pictureLogo.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.AutoSize = true;
            btnLogout.BackColor = Color.FromArgb(64, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1141, 0);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(119, 41);
            btnLogout.TabIndex = 27;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox1.Location = new Point(-5, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1268, 41);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Rectangle1
            // 
            Rectangle1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle1.BackColor = Color.Black;
            Rectangle1.Location = new Point(-5, 25);
            Rectangle1.Margin = new Padding(2);
            Rectangle1.Name = "Rectangle1";
            Rectangle1.Size = new Size(1268, 65);
            Rectangle1.TabIndex = 24;
            Rectangle1.TabStop = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(64, 0, 0);
            lblHeader.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 6);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(307, 29);
            lblHeader.TabIndex = 34;
            lblHeader.Text = "Red Agents IT Help Desk";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(462, 92);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 47);
            label1.TabIndex = 48;
            label1.Text = "Ticket Dashboard";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox2.Location = new Point(-12, 89);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1312, 69);
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabHome);
            tabControl1.Controls.Add(tabSolve);
            tabControl1.Controls.Add(tabShare);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(-5, 144);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1288, 509);
            tabControl1.TabIndex = 49;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.LightGray;
            tabHome.Controls.Add(label5);
            tabHome.Controls.Add(label4);
            tabHome.Controls.Add(label3);
            tabHome.Controls.Add(label2);
            tabHome.Controls.Add(pictureBox4);
            tabHome.Controls.Add(pictureBox11);
            tabHome.Controls.Add(pictureBox3);
            tabHome.Controls.Add(pictureBox8);
            tabHome.Controls.Add(lblDescribeHome);
            tabHome.Controls.Add(lblUser);
            tabHome.Controls.Add(lblWelcomeMessage);
            tabHome.Location = new Point(4, 37);
            tabHome.Margin = new Padding(2);
            tabHome.Name = "tabHome";
            tabHome.Size = new Size(1280, 468);
            tabHome.TabIndex = 2;
            tabHome.Text = "Ticket Homepage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(242, 294);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(916, 108);
            label5.TabIndex = 73;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(224, 118);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(952, 81);
            label4.TabIndex = 72;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(39, 322);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(192, 38);
            label3.TabIndex = 71;
            label3.Text = "Share Tickets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(32, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 38);
            label2.TabIndex = 70;
            label2.Text = "Solve Tickets";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(22, 280);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1206, 135);
            pictureBox4.TabIndex = 69;
            pictureBox4.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.White;
            pictureBox11.Location = new Point(21, 94);
            pictureBox11.Margin = new Padding(2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(1208, 135);
            pictureBox11.TabIndex = 68;
            pictureBox11.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Location = new Point(12, 269);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1235, 158);
            pictureBox3.TabIndex = 67;
            pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Gray;
            pictureBox8.Location = new Point(12, 82);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(1235, 158);
            pictureBox8.TabIndex = 66;
            pictureBox8.TabStop = false;
            // 
            // lblDescribeHome
            // 
            lblDescribeHome.AutoSize = true;
            lblDescribeHome.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescribeHome.Location = new Point(5, 42);
            lblDescribeHome.Margin = new Padding(2, 0, 2, 0);
            lblDescribeHome.Name = "lblDescribeHome";
            lblDescribeHome.Size = new Size(1186, 27);
            lblDescribeHome.TabIndex = 65;
            lblDescribeHome.Text = "Listed below are the different functionalities offered to you via your ticket dashboard, as well as a brief description of each. \r\n";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(411, 8);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(73, 32);
            lblUser.TabIndex = 5;
            lblUser.Text = "User!";
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcomeMessage.Location = new Point(-2, 6);
            lblWelcomeMessage.Margin = new Padding(2, 0, 2, 0);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(430, 32);
            lblWelcomeMessage.TabIndex = 1;
            lblWelcomeMessage.Text = "Welcome to your Ticket Homepage, ";
            // 
            // tabSolve
            // 
            tabSolve.BackColor = Color.LightGray;
            tabSolve.Controls.Add(txtSolveTicketID);
            tabSolve.Controls.Add(btnSolveTicket);
            tabSolve.Controls.Add(btnSolveClear);
            tabSolve.Controls.Add(txtSolution);
            tabSolve.Controls.Add(pictureBox6);
            tabSolve.Controls.Add(DGVS);
            tabSolve.Controls.Add(lblSolve);
            tabSolve.Controls.Add(lblTicketID);
            tabSolve.Controls.Add(pictureBox9);
            tabSolve.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabSolve.Location = new Point(4, 37);
            tabSolve.Margin = new Padding(2);
            tabSolve.Name = "tabSolve";
            tabSolve.Padding = new Padding(2);
            tabSolve.Size = new Size(1280, 468);
            tabSolve.TabIndex = 0;
            tabSolve.Text = "Solve Tickets";
            // 
            // txtSolveTicketID
            // 
            txtSolveTicketID.Anchor = AnchorStyles.None;
            txtSolveTicketID.Location = new Point(1064, 80);
            txtSolveTicketID.Margin = new Padding(4);
            txtSolveTicketID.Name = "txtSolveTicketID";
            txtSolveTicketID.Size = new Size(170, 31);
            txtSolveTicketID.TabIndex = 69;
            // 
            // btnSolveTicket
            // 
            btnSolveTicket.BackColor = Color.FromArgb(64, 0, 0);
            btnSolveTicket.FlatStyle = FlatStyle.Popup;
            btnSolveTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSolveTicket.ForeColor = Color.White;
            btnSolveTicket.Location = new Point(1068, 406);
            btnSolveTicket.Margin = new Padding(2);
            btnSolveTicket.Name = "btnSolveTicket";
            btnSolveTicket.Size = new Size(158, 45);
            btnSolveTicket.TabIndex = 64;
            btnSolveTicket.Text = "Solve Ticket";
            btnSolveTicket.UseVisualStyleBackColor = false;
            // 
            // btnSolveClear
            // 
            btnSolveClear.BackColor = Color.FromArgb(64, 0, 0);
            btnSolveClear.FlatStyle = FlatStyle.Popup;
            btnSolveClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSolveClear.ForeColor = Color.White;
            btnSolveClear.Location = new Point(1068, 350);
            btnSolveClear.Margin = new Padding(2);
            btnSolveClear.Name = "btnSolveClear";
            btnSolveClear.Size = new Size(158, 45);
            btnSolveClear.TabIndex = 63;
            btnSolveClear.Text = "Clear";
            btnSolveClear.UseVisualStyleBackColor = false;
            btnSolveClear.Click += btnSolveClear_Click;
            // 
            // txtSolution
            // 
            txtSolution.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtSolution.Location = new Point(21, 274);
            txtSolution.Margin = new Padding(2);
            txtSolution.MaxLength = 500;
            txtSolution.Multiline = true;
            txtSolution.Name = "txtSolution";
            txtSolution.PlaceholderText = "Explain the solution to this ticket in 500 characters or less.";
            txtSolution.Size = new Size(1018, 172);
            txtSolution.TabIndex = 59;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.BackColor = Color.Gray;
            pictureBox6.Location = new Point(10, 268);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1040, 186);
            pictureBox6.TabIndex = 58;
            pictureBox6.TabStop = false;
            // 
            // DGVS
            // 
            DGVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVS.Location = new Point(9, 42);
            DGVS.Margin = new Padding(2);
            DGVS.Name = "DGVS";
            DGVS.RowHeadersWidth = 62;
            DGVS.RowTemplate.Height = 33;
            DGVS.Size = new Size(1029, 208);
            DGVS.TabIndex = 56;
            // 
            // lblSolve
            // 
            lblSolve.AutoSize = true;
            lblSolve.BackColor = Color.Transparent;
            lblSolve.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSolve.Location = new Point(2, 6);
            lblSolve.Margin = new Padding(2, 0, 2, 0);
            lblSolve.Name = "lblSolve";
            lblSolve.Size = new Size(159, 32);
            lblSolve.TabIndex = 55;
            lblSolve.Text = "Solve Tickets";
            // 
            // lblTicketID
            // 
            lblTicketID.AutoSize = true;
            lblTicketID.BackColor = Color.DarkGray;
            lblTicketID.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTicketID.Location = new Point(1062, 48);
            lblTicketID.Margin = new Padding(2, 0, 2, 0);
            lblTicketID.Name = "lblTicketID";
            lblTicketID.Size = new Size(175, 28);
            lblTicketID.TabIndex = 68;
            lblTicketID.Text = "Enter a Ticket ID:";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.DarkGray;
            pictureBox9.Location = new Point(1049, 44);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(200, 82);
            pictureBox9.TabIndex = 70;
            pictureBox9.TabStop = false;
            // 
            // tabShare
            // 
            tabShare.BackColor = Color.LightGray;
            tabShare.Controls.Add(DGVShare);
            tabShare.Controls.Add(btnShare);
            tabShare.Controls.Add(btnClear);
            tabShare.Controls.Add(txtUsername);
            tabShare.Controls.Add(label8);
            tabShare.Controls.Add(txtEmail);
            tabShare.Controls.Add(label7);
            tabShare.Controls.Add(txtTicketID);
            tabShare.Controls.Add(label6);
            tabShare.Controls.Add(lblShare);
            tabShare.Controls.Add(pictureBox5);
            tabShare.Location = new Point(4, 37);
            tabShare.Margin = new Padding(2);
            tabShare.Name = "tabShare";
            tabShare.Padding = new Padding(2);
            tabShare.Size = new Size(1280, 468);
            tabShare.TabIndex = 1;
            tabShare.Text = "Share Tickets";
            tabShare.Click += tabShare_Click;
            // 
            // DGVShare
            // 
            DGVShare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVShare.Location = new Point(731, 45);
            DGVShare.Margin = new Padding(2);
            DGVShare.Name = "DGVShare";
            DGVShare.RowHeadersWidth = 62;
            DGVShare.RowTemplate.Height = 33;
            DGVShare.Size = new Size(498, 392);
            DGVShare.TabIndex = 79;
            // 
            // btnShare
            // 
            btnShare.BackColor = Color.FromArgb(64, 0, 0);
            btnShare.FlatStyle = FlatStyle.Popup;
            btnShare.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnShare.ForeColor = Color.White;
            btnShare.Location = new Point(218, 391);
            btnShare.Margin = new Padding(2);
            btnShare.Name = "btnShare";
            btnShare.Size = new Size(162, 51);
            btnShare.TabIndex = 78;
            btnShare.Text = "Share Ticket";
            btnShare.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 0, 0);
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(15, 391);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 51);
            btnClear.TabIndex = 77;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(19, 202);
            txtUsername.Margin = new Padding(4);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(628, 34);
            txtUsername.TabIndex = 75;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkGray;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 169);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(646, 30);
            label8.TabIndex = 74;
            label8.Text = "Enter the username of the IT member you wish to share with:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(19, 309);
            txtEmail.Margin = new Padding(4);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(630, 34);
            txtEmail.TabIndex = 73;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkGray;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 274);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(397, 30);
            label7.TabIndex = 72;
            label7.Text = "Enter the above user's email address:";
            // 
            // txtTicketID
            // 
            txtTicketID.Anchor = AnchorStyles.None;
            txtTicketID.Location = new Point(18, 102);
            txtTicketID.Margin = new Padding(4);
            txtTicketID.MaxLength = 50;
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(629, 34);
            txtTicketID.TabIndex = 71;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkGray;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(15, 69);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(462, 30);
            label6.TabIndex = 70;
            label6.Text = "Enter the ID of the ticket you wish to share:";
            // 
            // lblShare
            // 
            lblShare.AutoSize = true;
            lblShare.BackColor = Color.Transparent;
            lblShare.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblShare.Location = new Point(2, 6);
            lblShare.Margin = new Padding(2, 0, 2, 0);
            lblShare.Name = "lblShare";
            lblShare.Size = new Size(162, 32);
            lblShare.TabIndex = 55;
            lblShare.Text = "Share Tickets";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DarkGray;
            pictureBox5.Location = new Point(11, 45);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(689, 328);
            pictureBox5.TabIndex = 76;
            pictureBox5.TabStop = false;
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.BackColor = Color.Black;
            ProfilePictureBox.BackgroundImage = Properties.Resources.Profile_Picture;
            ProfilePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            ProfilePictureBox.Location = new Point(1202, 48);
            ProfilePictureBox.Margin = new Padding(2);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(48, 35);
            ProfilePictureBox.TabIndex = 5;
            ProfilePictureBox.TabStop = false;
            ProfilePictureBox.Click += ProfilePictureBox_Click;
            // 
            // lblLoggedIn
            // 
            lblLoggedIn.AutoSize = true;
            lblLoggedIn.BackColor = Color.Black;
            lblLoggedIn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoggedIn.ForeColor = Color.White;
            lblLoggedIn.Location = new Point(971, 51);
            lblLoggedIn.Margin = new Padding(2, 0, 2, 0);
            lblLoggedIn.Name = "lblLoggedIn";
            lblLoggedIn.Size = new Size(171, 28);
            lblLoggedIn.TabIndex = 6;
            lblLoggedIn.Text = "Logged in as: User";
            // 
            // frmITSupport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 641);
            Controls.Add(lblLoggedIn);
            Controls.Add(tabControl1);
            Controls.Add(ProfilePictureBox);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lblHeader);
            Controls.Add(pictureLogo);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Controls.Add(Rectangle1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmITSupport";
            Text = "IT Help Desk IT Support Team Ticket Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            tabSolve.ResumeLayout(false);
            tabSolve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            tabShare.ResumeLayout(false);
            tabShare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVShare).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox Rectangle1;
        private Label lblHeader;
        private Label label1;
        private PictureBox pictureBox2;
        private TabControl tabControl1;
        private TabPage tabSolve;
        private TabPage tabShare;
        private Label lblSolve;
        private Label lblShare;
        private DataGridView DGVS;
        private TextBox txtSolution;
        private PictureBox pictureBox6;
        private Button btnSolveTicket;
        private Button btnSolveClear;
        private TextBox txtSolveTicketID;
        private Label lblTicketID;
        private TabPage tabHome;
        private PictureBox ProfilePictureBox;
        private Label lblLoggedIn;
        private Label lblWelcomeMessage;
        private Label lblUser;
        private PictureBox pictureBox4;
        private PictureBox pictureBox11;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private Label lblDescribeHome;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtTicketID;
        private Label label6;
        private TextBox txtUsername;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private PictureBox pictureBox5;
        private Button btnShare;
        private Button btnClear;
        private DataGridView DGVShare;
        private PictureBox pictureBox9;
    }
}