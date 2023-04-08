namespace GUI_IT
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            btnGenerate = new Button();
            btnRegistration = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            Rectangle1 = new PictureBox();
            DGVR = new DataGridView();
            lblHeader = new Label();
            lblAdminHeader = new Label();
            pictureBox2 = new PictureBox();
            pnlReportGenerate = new Panel();
            tabReportGeneration = new TabControl();
            tabHome = new TabPage();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox13 = new PictureBox();
            pictureBox10 = new PictureBox();
            label6 = new Label();
            pictureBox12 = new PictureBox();
            pictureBox9 = new PictureBox();
            lblUser = new Label();
            lblWelcomeMessage = new Label();
            lblDescribeHome = new Label();
            tabView = new TabPage();
            btnSolvedView = new Button();
            btnUnsolvedView = new Button();
            pictureBox7 = new PictureBox();
            DGVV = new DataGridView();
            label8 = new Label();
            tabSolved = new TabPage();
            cbxp = new ComboBox();
            cbxn = new ComboBox();
            cbxcat1 = new ComboBox();
            cbxurg1 = new ComboBox();
            btnReportClear = new Button();
            label19 = new Label();
            txtTicketIDSolve = new TextBox();
            label17 = new Label();
            label16 = new Label();
            button1 = new Button();
            txtTicketDescribeSolved = new TextBox();
            label14 = new Label();
            label15 = new Label();
            txtTicketDetailSolved = new TextBox();
            pictureBox5 = new PictureBox();
            pictureBox15 = new PictureBox();
            label18 = new Label();
            btnSubmitSolved = new Button();
            btnClearSolved = new Button();
            label2 = new Label();
            pictureBox16 = new PictureBox();
            tabUnsolved = new TabPage();
            cbxuu = new ComboBox();
            cbxu = new ComboBox();
            cbxurg = new ComboBox();
            cbxcat = new ComboBox();
            label13 = new Label();
            txtTicketSummary = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtUnsolvedExplain = new TextBox();
            pictureBox14 = new PictureBox();
            lblTicketID = new Label();
            txtTicketID = new TextBox();
            btnSubmitUnsolved = new Button();
            btnClearUnsolved = new Button();
            label3 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox11 = new PictureBox();
            ProfilePictureBox = new PictureBox();
            btnApproveDeny = new Button();
            pictureBox4 = new PictureBox();
            lblLoggedIn = new Label();
            pictureBox6 = new PictureBox();
            btnrefre = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlReportGenerate.SuspendLayout();
            tabReportGeneration.SuspendLayout();
            tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVV).BeginInit();
            tabSolved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            tabUnsolved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.AutoSize = true;
            btnGenerate.BackColor = Color.Black;
            btnGenerate.FlatStyle = FlatStyle.Popup;
            btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(229, 48);
            btnGenerate.Margin = new Padding(2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(196, 45);
            btnGenerate.TabIndex = 18;
            btnGenerate.Text = "Generate Reports";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegistration.AutoSize = true;
            btnRegistration.BackColor = Color.Black;
            btnRegistration.FlatStyle = FlatStyle.Popup;
            btnRegistration.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegistration.ForeColor = Color.White;
            btnRegistration.Location = new Point(91, 45);
            btnRegistration.Margin = new Padding(2);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(145, 49);
            btnRegistration.TabIndex = 17;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.AutoSize = true;
            btnLogout.BackColor = Color.FromArgb(64, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1142, 0);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(119, 41);
            btnLogout.TabIndex = 15;
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
            pictureBox1.Size = new Size(1261, 41);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Rectangle1
            // 
            Rectangle1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle1.BackColor = Color.Black;
            Rectangle1.Location = new Point(-9, 25);
            Rectangle1.Margin = new Padding(2);
            Rectangle1.Name = "Rectangle1";
            Rectangle1.Size = new Size(1272, 80);
            Rectangle1.TabIndex = 12;
            Rectangle1.TabStop = false;
            // 
            // DGVR
            // 
            DGVR.AllowUserToAddRows = false;
            DGVR.AllowUserToDeleteRows = false;
            DGVR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVR.Location = new Point(26, 181);
            DGVR.Margin = new Padding(4);
            DGVR.Name = "DGVR";
            DGVR.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            DGVR.RowTemplate.Height = 29;
            DGVR.Size = new Size(990, 448);
            DGVR.TabIndex = 19;
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
            lblHeader.TabIndex = 48;
            lblHeader.Text = "Red Agents IT Help Desk";
            // 
            // lblAdminHeader
            // 
            lblAdminHeader.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdminHeader.AutoSize = true;
            lblAdminHeader.BackColor = Color.FromArgb(64, 0, 0);
            lblAdminHeader.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminHeader.ForeColor = Color.White;
            lblAdminHeader.Location = new Point(429, 101);
            lblAdminHeader.Margin = new Padding(2, 0, 2, 0);
            lblAdminHeader.Name = "lblAdminHeader";
            lblAdminHeader.Size = new Size(430, 47);
            lblAdminHeader.TabIndex = 50;
            lblAdminHeader.Text = "New User Registration";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox2.Location = new Point(-42, 96);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1382, 64);
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // pnlReportGenerate
            // 
            pnlReportGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlReportGenerate.BackColor = Color.White;
            pnlReportGenerate.Controls.Add(tabReportGeneration);
            pnlReportGenerate.Location = new Point(-5, 164);
            pnlReportGenerate.Margin = new Padding(2);
            pnlReportGenerate.Name = "pnlReportGenerate";
            pnlReportGenerate.Size = new Size(1268, 496);
            pnlReportGenerate.TabIndex = 15;
            // 
            // tabReportGeneration
            // 
            tabReportGeneration.Controls.Add(tabHome);
            tabReportGeneration.Controls.Add(tabView);
            tabReportGeneration.Controls.Add(tabSolved);
            tabReportGeneration.Controls.Add(tabUnsolved);
            tabReportGeneration.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tabReportGeneration.Location = new Point(-1, 0);
            tabReportGeneration.Margin = new Padding(2);
            tabReportGeneration.Name = "tabReportGeneration";
            tabReportGeneration.SelectedIndex = 0;
            tabReportGeneration.Size = new Size(1284, 756);
            tabReportGeneration.TabIndex = 18;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.LightGray;
            tabHome.Controls.Add(label7);
            tabHome.Controls.Add(label5);
            tabHome.Controls.Add(label4);
            tabHome.Controls.Add(pictureBox13);
            tabHome.Controls.Add(pictureBox10);
            tabHome.Controls.Add(label6);
            tabHome.Controls.Add(pictureBox12);
            tabHome.Controls.Add(pictureBox9);
            tabHome.Controls.Add(lblUser);
            tabHome.Controls.Add(lblWelcomeMessage);
            tabHome.Controls.Add(lblDescribeHome);
            tabHome.Location = new Point(4, 37);
            tabHome.Margin = new Padding(2);
            tabHome.Name = "tabHome";
            tabHome.Size = new Size(1276, 715);
            tabHome.TabIndex = 3;
            tabHome.Text = "Report Homepage";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(355, 288);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(809, 120);
            label7.TabIndex = 82;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(326, 110);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(850, 108);
            label5.TabIndex = 81;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(31, 322);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(322, 38);
            label4.TabIndex = 78;
            label4.Text = "Unsolved Ticket Report";
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.White;
            pictureBox13.Location = new Point(22, 280);
            pictureBox13.Margin = new Padding(2);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(1160, 132);
            pictureBox13.TabIndex = 77;
            pictureBox13.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox10.Location = new Point(14, 265);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(1180, 162);
            pictureBox10.TabIndex = 73;
            pictureBox10.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(34, 142);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(288, 38);
            label6.TabIndex = 80;
            label6.Text = "Solved Ticket Report";
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.White;
            pictureBox12.Location = new Point(25, 98);
            pictureBox12.Margin = new Padding(2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(1160, 135);
            pictureBox12.TabIndex = 76;
            pictureBox12.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox9.Location = new Point(15, 81);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(1180, 165);
            pictureBox9.TabIndex = 72;
            pictureBox9.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(426, 8);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(73, 32);
            lblUser.TabIndex = 53;
            lblUser.Text = "User!";
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcomeMessage.Location = new Point(1, 8);
            lblWelcomeMessage.Margin = new Padding(2, 0, 2, 0);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(440, 32);
            lblWelcomeMessage.TabIndex = 70;
            lblWelcomeMessage.Text = "Welcome to your Report Homepage, ";
            // 
            // lblDescribeHome
            // 
            lblDescribeHome.AutoSize = true;
            lblDescribeHome.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescribeHome.Location = new Point(9, 40);
            lblDescribeHome.Margin = new Padding(2, 0, 2, 0);
            lblDescribeHome.Name = "lblDescribeHome";
            lblDescribeHome.Size = new Size(1141, 30);
            lblDescribeHome.TabIndex = 65;
            lblDescribeHome.Text = "Listed below are the different potential reports that you can generate, as well as a brief description of each.\r\n";
            // 
            // tabView
            // 
            tabView.BackColor = Color.LightGray;
            tabView.Controls.Add(btnSolvedView);
            tabView.Controls.Add(btnUnsolvedView);
            tabView.Controls.Add(pictureBox7);
            tabView.Controls.Add(DGVV);
            tabView.Controls.Add(label8);
            tabView.Location = new Point(4, 37);
            tabView.Margin = new Padding(2);
            tabView.Name = "tabView";
            tabView.Size = new Size(1276, 715);
            tabView.TabIndex = 4;
            tabView.Text = "View Tickets";
            // 
            // btnSolvedView
            // 
            btnSolvedView.BackColor = Color.FromArgb(64, 0, 0);
            btnSolvedView.FlatStyle = FlatStyle.Popup;
            btnSolvedView.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSolvedView.ForeColor = Color.White;
            btnSolvedView.Location = new Point(1110, 264);
            btnSolvedView.Margin = new Padding(2);
            btnSolvedView.Name = "btnSolvedView";
            btnSolvedView.Size = new Size(132, 114);
            btnSolvedView.TabIndex = 75;
            btnSolvedView.Text = "View Solved Tickets";
            btnSolvedView.UseVisualStyleBackColor = false;
            btnSolvedView.Click += btnSolvedView_Click;
            // 
            // btnUnsolvedView
            // 
            btnUnsolvedView.BackColor = Color.FromArgb(64, 0, 0);
            btnUnsolvedView.FlatStyle = FlatStyle.Popup;
            btnUnsolvedView.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnsolvedView.ForeColor = Color.White;
            btnUnsolvedView.Location = new Point(1110, 92);
            btnUnsolvedView.Margin = new Padding(2);
            btnUnsolvedView.Name = "btnUnsolvedView";
            btnUnsolvedView.Size = new Size(132, 114);
            btnUnsolvedView.TabIndex = 74;
            btnUnsolvedView.Text = "View Unsolved Tickets";
            btnUnsolvedView.UseVisualStyleBackColor = false;
            btnUnsolvedView.Click += btnUnsolvedView_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.DarkGray;
            pictureBox7.Location = new Point(1098, 45);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(159, 379);
            pictureBox7.TabIndex = 73;
            pictureBox7.TabStop = false;
            // 
            // DGVV
            // 
            DGVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVV.Location = new Point(16, 45);
            DGVV.Margin = new Padding(2);
            DGVV.Name = "DGVV";
            DGVV.RowHeadersWidth = 62;
            DGVV.RowTemplate.Height = 33;
            DGVV.Size = new Size(1065, 379);
            DGVV.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(4, 6);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(154, 32);
            label8.TabIndex = 57;
            label8.Text = "View Tickets";
            // 
            // tabSolved
            // 
            tabSolved.BackColor = Color.LightGray;
            tabSolved.Controls.Add(cbxp);
            tabSolved.Controls.Add(cbxn);
            tabSolved.Controls.Add(cbxcat1);
            tabSolved.Controls.Add(cbxurg1);
            tabSolved.Controls.Add(btnReportClear);
            tabSolved.Controls.Add(label19);
            tabSolved.Controls.Add(txtTicketIDSolve);
            tabSolved.Controls.Add(label17);
            tabSolved.Controls.Add(label16);
            tabSolved.Controls.Add(button1);
            tabSolved.Controls.Add(txtTicketDescribeSolved);
            tabSolved.Controls.Add(label14);
            tabSolved.Controls.Add(label15);
            tabSolved.Controls.Add(txtTicketDetailSolved);
            tabSolved.Controls.Add(pictureBox5);
            tabSolved.Controls.Add(pictureBox15);
            tabSolved.Controls.Add(label18);
            tabSolved.Controls.Add(btnSubmitSolved);
            tabSolved.Controls.Add(btnClearSolved);
            tabSolved.Controls.Add(label2);
            tabSolved.Controls.Add(pictureBox16);
            tabSolved.Location = new Point(4, 37);
            tabSolved.Margin = new Padding(2);
            tabSolved.Name = "tabSolved";
            tabSolved.Padding = new Padding(2);
            tabSolved.Size = new Size(1276, 715);
            tabSolved.TabIndex = 1;
            tabSolved.Text = "Solved Tickets";
            // 
            // cbxp
            // 
            cbxp.FormattingEnabled = true;
            cbxp.Location = new Point(215, 151);
            cbxp.Name = "cbxp";
            cbxp.Size = new Size(409, 36);
            cbxp.TabIndex = 138;
            // 
            // cbxn
            // 
            cbxn.FormattingEnabled = true;
            cbxn.Location = new Point(215, 74);
            cbxn.Name = "cbxn";
            cbxn.Size = new Size(465, 36);
            cbxn.TabIndex = 137;
            // 
            // cbxcat1
            // 
            cbxcat1.FormattingEnabled = true;
            cbxcat1.Items.AddRange(new object[] { "Type 1", "Type 2", "Type 3", "Type 4", "Other" });
            cbxcat1.Location = new Point(22, 229);
            cbxcat1.Name = "cbxcat1";
            cbxcat1.Size = new Size(362, 36);
            cbxcat1.TabIndex = 136;
            // 
            // cbxurg1
            // 
            cbxurg1.FormattingEnabled = true;
            cbxurg1.Items.AddRange(new object[] { "High", "Medium", "Low" });
            cbxurg1.Location = new Point(31, 153);
            cbxurg1.Name = "cbxurg1";
            cbxurg1.Size = new Size(156, 36);
            cbxurg1.TabIndex = 135;
            cbxurg1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnReportClear
            // 
            btnReportClear.BackColor = Color.FromArgb(64, 0, 0);
            btnReportClear.FlatStyle = FlatStyle.Popup;
            btnReportClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportClear.ForeColor = Color.White;
            btnReportClear.Location = new Point(34, 390);
            btnReportClear.Margin = new Padding(2);
            btnReportClear.Name = "btnReportClear";
            btnReportClear.Size = new Size(159, 41);
            btnReportClear.TabIndex = 134;
            btnReportClear.Text = "Clear";
            btnReportClear.UseVisualStyleBackColor = false;
            btnReportClear.Click += btnReportClear_Click_1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.DarkGray;
            label19.Location = new Point(22, 198);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(362, 28);
            label19.TabIndex = 133;
            label19.Text = "What was the select ticket category?";
            // 
            // txtTicketIDSolve
            // 
            txtTicketIDSolve.Location = new Point(30, 76);
            txtTicketIDSolve.Margin = new Padding(2);
            txtTicketIDSolve.Name = "txtTicketIDSolve";
            txtTicketIDSolve.Size = new Size(162, 34);
            txtTicketIDSolve.TabIndex = 132;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.DarkGray;
            label17.Location = new Point(30, 46);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(102, 28);
            label17.TabIndex = 131;
            label17.Text = "Ticket ID:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.DarkGray;
            label16.Location = new Point(28, 123);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(159, 28);
            label16.TabIndex = 129;
            label16.Text = "Ticket Urgency:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(207, 390);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(158, 41);
            button1.TabIndex = 126;
            button1.Text = "Submit Report";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // txtTicketDescribeSolved
            // 
            txtTicketDescribeSolved.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTicketDescribeSolved.Location = new Point(33, 282);
            txtTicketDescribeSolved.Margin = new Padding(2);
            txtTicketDescribeSolved.MaxLength = 500;
            txtTicketDescribeSolved.Multiline = true;
            txtTicketDescribeSolved.Name = "txtTicketDescribeSolved";
            txtTicketDescribeSolved.PlaceholderText = "Provide a brief summary of the ticket description.";
            txtTicketDescribeSolved.Size = new Size(652, 93);
            txtTicketDescribeSolved.TabIndex = 125;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.DarkGray;
            label14.Location = new Point(215, 122);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(314, 28);
            label14.TabIndex = 124;
            label14.Text = "Name of user who raised ticket:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.DarkGray;
            label15.Location = new Point(212, 46);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(469, 28);
            label15.TabIndex = 123;
            label15.Text = "Name of IT member who was assigned to ticket:";
            // 
            // txtTicketDetailSolved
            // 
            txtTicketDetailSolved.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTicketDetailSolved.Location = new Point(724, 118);
            txtTicketDetailSolved.Margin = new Padding(2);
            txtTicketDetailSolved.MaxLength = 750;
            txtTicketDetailSolved.Multiline = true;
            txtTicketDetailSolved.Name = "txtTicketDetailSolved";
            txtTicketDetailSolved.PlaceholderText = "Include any other necessary ticket details here.";
            txtTicketDetailSolved.Size = new Size(506, 288);
            txtTicketDetailSolved.TabIndex = 120;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox5.Location = new Point(710, 107);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(531, 310);
            pictureBox5.TabIndex = 119;
            pictureBox5.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox15.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox15.Location = new Point(22, 274);
            pictureBox15.Margin = new Padding(2);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(672, 109);
            pictureBox15.TabIndex = 122;
            pictureBox15.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.DarkGray;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(704, 46);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(528, 56);
            label18.TabIndex = 114;
            label18.Text = "Provide the solution to the raised ticket below, as well\r\nas any other potentially important ticket details.";
            // 
            // btnSubmitSolved
            // 
            btnSubmitSolved.BackColor = Color.FromArgb(64, 0, 0);
            btnSubmitSolved.FlatStyle = FlatStyle.Popup;
            btnSubmitSolved.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitSolved.ForeColor = Color.White;
            btnSubmitSolved.Location = new Point(255, 482);
            btnSubmitSolved.Margin = new Padding(2);
            btnSubmitSolved.Name = "btnSubmitSolved";
            btnSubmitSolved.Size = new Size(199, 48);
            btnSubmitSolved.TabIndex = 106;
            btnSubmitSolved.Text = "Submit Report";
            btnSubmitSolved.UseVisualStyleBackColor = false;
            // 
            // btnClearSolved
            // 
            btnClearSolved.BackColor = Color.FromArgb(64, 0, 0);
            btnClearSolved.FlatStyle = FlatStyle.Popup;
            btnClearSolved.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearSolved.ForeColor = Color.White;
            btnClearSolved.Location = new Point(32, 482);
            btnClearSolved.Margin = new Padding(2);
            btnClearSolved.Name = "btnClearSolved";
            btnClearSolved.Size = new Size(199, 48);
            btnClearSolved.TabIndex = 105;
            btnClearSolved.Text = "Clear";
            btnClearSolved.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(6, 2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(418, 32);
            label2.TabIndex = 56;
            label2.Text = "Creating a Report for Solved Tickets";
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = Color.DarkGray;
            pictureBox16.Location = new Point(12, 41);
            pictureBox16.Margin = new Padding(2);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(1239, 395);
            pictureBox16.TabIndex = 115;
            pictureBox16.TabStop = false;
            // 
            // tabUnsolved
            // 
            tabUnsolved.BackColor = Color.LightGray;
            tabUnsolved.Controls.Add(cbxuu);
            tabUnsolved.Controls.Add(cbxu);
            tabUnsolved.Controls.Add(cbxurg);
            tabUnsolved.Controls.Add(cbxcat);
            tabUnsolved.Controls.Add(label13);
            tabUnsolved.Controls.Add(txtTicketSummary);
            tabUnsolved.Controls.Add(label12);
            tabUnsolved.Controls.Add(label11);
            tabUnsolved.Controls.Add(label10);
            tabUnsolved.Controls.Add(label9);
            tabUnsolved.Controls.Add(txtUnsolvedExplain);
            tabUnsolved.Controls.Add(pictureBox14);
            tabUnsolved.Controls.Add(lblTicketID);
            tabUnsolved.Controls.Add(txtTicketID);
            tabUnsolved.Controls.Add(btnSubmitUnsolved);
            tabUnsolved.Controls.Add(btnClearUnsolved);
            tabUnsolved.Controls.Add(label3);
            tabUnsolved.Controls.Add(pictureBox8);
            tabUnsolved.Controls.Add(pictureBox11);
            tabUnsolved.Location = new Point(4, 37);
            tabUnsolved.Margin = new Padding(2);
            tabUnsolved.Name = "tabUnsolved";
            tabUnsolved.Size = new Size(1276, 715);
            tabUnsolved.TabIndex = 2;
            tabUnsolved.Text = "Unsolved Tickets";
            // 
            // cbxuu
            // 
            cbxuu.FormattingEnabled = true;
            cbxuu.Location = new Point(209, 154);
            cbxuu.Name = "cbxuu";
            cbxuu.Size = new Size(381, 36);
            cbxuu.TabIndex = 106;
            // 
            // cbxu
            // 
            cbxu.FormattingEnabled = true;
            cbxu.Location = new Point(203, 81);
            cbxu.Name = "cbxu";
            cbxu.Size = new Size(469, 36);
            cbxu.TabIndex = 105;
            // 
            // cbxurg
            // 
            cbxurg.FormattingEnabled = true;
            cbxurg.Items.AddRange(new object[] { "High", "Medium", "Low" });
            cbxurg.Location = new Point(21, 153);
            cbxurg.Name = "cbxurg";
            cbxurg.Size = new Size(136, 36);
            cbxurg.TabIndex = 104;
            // 
            // cbxcat
            // 
            cbxcat.FormattingEnabled = true;
            cbxcat.Items.AddRange(new object[] { "Type 1", "Type 2", "Type 3", "Type 4", "Other" });
            cbxcat.Location = new Point(20, 228);
            cbxcat.Name = "cbxcat";
            cbxcat.Size = new Size(325, 36);
            cbxcat.TabIndex = 103;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DarkGray;
            label13.Location = new Point(21, 197);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(315, 28);
            label13.TabIndex = 102;
            label13.Text = "What was the ticket's category?";
            // 
            // txtTicketSummary
            // 
            txtTicketSummary.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTicketSummary.Location = new Point(28, 287);
            txtTicketSummary.Margin = new Padding(2);
            txtTicketSummary.MaxLength = 500;
            txtTicketSummary.Multiline = true;
            txtTicketSummary.Name = "txtTicketSummary";
            txtTicketSummary.PlaceholderText = "Provide a brief summary of the ticket description.";
            txtTicketSummary.Size = new Size(657, 96);
            txtTicketSummary.TabIndex = 101;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DarkGray;
            label12.Location = new Point(19, 124);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(159, 28);
            label12.TabIndex = 100;
            label12.Text = "Ticket Urgency:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkGray;
            label11.Location = new Point(208, 124);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(314, 28);
            label11.TabIndex = 99;
            label11.Text = "Name of user who raised ticket:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGray;
            label10.Location = new Point(197, 51);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(469, 28);
            label10.TabIndex = 98;
            label10.Text = "Name of IT member who was assigned to ticket:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkGray;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(708, 52);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(542, 50);
            label9.TabIndex = 95;
            label9.Text = "Note any potential solution ideas here. Also make note of \r\nwho you think should solve this ticket should it be re-opened. ";
            // 
            // txtUnsolvedExplain
            // 
            txtUnsolvedExplain.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtUnsolvedExplain.Location = new Point(720, 119);
            txtUnsolvedExplain.Margin = new Padding(2);
            txtUnsolvedExplain.MaxLength = 750;
            txtUnsolvedExplain.Multiline = true;
            txtUnsolvedExplain.Name = "txtUnsolvedExplain";
            txtUnsolvedExplain.PlaceholderText = "Include any other necessary ticket details here.";
            txtUnsolvedExplain.Size = new Size(506, 288);
            txtUnsolvedExplain.TabIndex = 94;
            // 
            // pictureBox14
            // 
            pictureBox14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox14.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox14.Location = new Point(708, 108);
            pictureBox14.Margin = new Padding(2);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(528, 310);
            pictureBox14.TabIndex = 93;
            pictureBox14.TabStop = false;
            // 
            // lblTicketID
            // 
            lblTicketID.AutoSize = true;
            lblTicketID.BackColor = Color.DarkGray;
            lblTicketID.Location = new Point(18, 53);
            lblTicketID.Margin = new Padding(2, 0, 2, 0);
            lblTicketID.Name = "lblTicketID";
            lblTicketID.Size = new Size(102, 28);
            lblTicketID.TabIndex = 92;
            lblTicketID.Text = "Ticket ID:";
            // 
            // txtTicketID
            // 
            txtTicketID.Location = new Point(20, 83);
            txtTicketID.Margin = new Padding(2);
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(162, 34);
            txtTicketID.TabIndex = 88;
            // 
            // btnSubmitUnsolved
            // 
            btnSubmitUnsolved.BackColor = Color.FromArgb(64, 0, 0);
            btnSubmitUnsolved.FlatStyle = FlatStyle.Popup;
            btnSubmitUnsolved.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitUnsolved.ForeColor = Color.White;
            btnSubmitUnsolved.Location = new Point(204, 392);
            btnSubmitUnsolved.Margin = new Padding(2);
            btnSubmitUnsolved.Name = "btnSubmitUnsolved";
            btnSubmitUnsolved.Size = new Size(174, 38);
            btnSubmitUnsolved.TabIndex = 83;
            btnSubmitUnsolved.Text = "Submit Report";
            btnSubmitUnsolved.UseVisualStyleBackColor = false;
            btnSubmitUnsolved.Click += btnSubmitUnsolved_Click;
            // 
            // btnClearUnsolved
            // 
            btnClearUnsolved.BackColor = Color.FromArgb(64, 0, 0);
            btnClearUnsolved.FlatStyle = FlatStyle.Popup;
            btnClearUnsolved.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearUnsolved.ForeColor = Color.White;
            btnClearUnsolved.Location = new Point(31, 392);
            btnClearUnsolved.Margin = new Padding(2);
            btnClearUnsolved.Name = "btnClearUnsolved";
            btnClearUnsolved.Size = new Size(159, 38);
            btnClearUnsolved.TabIndex = 82;
            btnClearUnsolved.Text = "Clear";
            btnClearUnsolved.UseVisualStyleBackColor = false;
            btnClearUnsolved.Click += btnClearUnsolved_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(0, 6);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(447, 32);
            label3.TabIndex = 57;
            label3.Text = "Creating a Report for Unsolved Tickets";
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox8.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox8.Location = new Point(20, 281);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(674, 108);
            pictureBox8.TabIndex = 97;
            pictureBox8.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.DarkGray;
            pictureBox11.Location = new Point(14, 42);
            pictureBox11.Margin = new Padding(2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(1239, 394);
            pictureBox11.TabIndex = 107;
            pictureBox11.TabStop = false;
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.BackColor = Color.Black;
            ProfilePictureBox.BackgroundImage = (Image)resources.GetObject("ProfilePictureBox.BackgroundImage");
            ProfilePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            ProfilePictureBox.Location = new Point(1196, 50);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(47, 35);
            ProfilePictureBox.TabIndex = 83;
            ProfilePictureBox.TabStop = false;
            ProfilePictureBox.Click += ProfilePictureBox_Click;
            // 
            // btnApproveDeny
            // 
            btnApproveDeny.BackColor = Color.FromArgb(64, 0, 0);
            btnApproveDeny.FlatStyle = FlatStyle.Popup;
            btnApproveDeny.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnApproveDeny.ForeColor = Color.White;
            btnApproveDeny.Location = new Point(1050, 221);
            btnApproveDeny.Margin = new Padding(2);
            btnApproveDeny.Name = "btnApproveDeny";
            btnApproveDeny.Size = new Size(165, 65);
            btnApproveDeny.TabIndex = 51;
            btnApproveDeny.Text = "Update Status";
            btnApproveDeny.UseVisualStyleBackColor = false;
            btnApproveDeny.Click += btnApproveDeny_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Black;
            pictureBox4.Image = Properties.Resources.redAgentsLogo;
            pictureBox4.Location = new Point(9, 44);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            // 
            // lblLoggedIn
            // 
            lblLoggedIn.AutoSize = true;
            lblLoggedIn.BackColor = Color.Black;
            lblLoggedIn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoggedIn.ForeColor = Color.White;
            lblLoggedIn.Location = new Point(977, 52);
            lblLoggedIn.Margin = new Padding(2, 0, 2, 0);
            lblLoggedIn.Name = "lblLoggedIn";
            lblLoggedIn.Size = new Size(171, 28);
            lblLoggedIn.TabIndex = 0;
            lblLoggedIn.Text = "Logged in as: User";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.DarkGray;
            pictureBox6.Location = new Point(1035, 181);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(195, 274);
            pictureBox6.TabIndex = 73;
            pictureBox6.TabStop = false;
            // 
            // btnrefre
            // 
            btnrefre.BackColor = Color.FromArgb(64, 0, 0);
            btnrefre.FlatStyle = FlatStyle.Popup;
            btnrefre.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnrefre.ForeColor = Color.White;
            btnrefre.Location = new Point(1050, 339);
            btnrefre.Margin = new Padding(4);
            btnrefre.Name = "btnrefre";
            btnrefre.Size = new Size(165, 65);
            btnrefre.TabIndex = 74;
            btnrefre.Text = "Refresh";
            btnrefre.UseVisualStyleBackColor = false;
            btnrefre.Click += btnrefre_Click_1;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 641);
            Controls.Add(lblLoggedIn);
            Controls.Add(pnlReportGenerate);
            Controls.Add(lblAdminHeader);
            Controls.Add(btnApproveDeny);
            Controls.Add(pictureBox2);
            Controls.Add(lblHeader);
            Controls.Add(btnGenerate);
            Controls.Add(btnRegistration);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Controls.Add(ProfilePictureBox);
            Controls.Add(pictureBox4);
            Controls.Add(Rectangle1);
            Controls.Add(btnrefre);
            Controls.Add(pictureBox6);
            Controls.Add(DGVR);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmAdmin";
            Text = "IT Help Desk Admin Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlReportGenerate.ResumeLayout(false);
            tabReportGeneration.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            tabView.ResumeLayout(false);
            tabView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVV).EndInit();
            tabSolved.ResumeLayout(false);
            tabSolved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            tabUnsolved.ResumeLayout(false);
            tabUnsolved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGenerate;
        private Button btnRegistration;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox Rectangle1;
        private DataGridView DGVR;
        private Button btnRefresh;
        private Label lblHeader;
        private Label lblAdminHeader;
        private PictureBox pictureBox2;
        private Panel pnlReportGenerate;
        private Button btnApproveDeny;
        private PictureBox pictureBox4;
        private Label lblLoggedIn;
        private TabControl tabReportGeneration;
        private TabPage tabHome;
        private Label label4;
        private PictureBox pictureBox13;
        private PictureBox pictureBox10;
        private Label label6;
        private PictureBox pictureBox12;
        private PictureBox pictureBox9;
        private Label lblUser;
        private Label lblWelcomeMessage;
        private Label lblDescribeHome;
        private TabPage tabSolved;
        private Label label2;
        private TabPage tabUnsolved;
        private Label label3;
        private Label label5;
        private Label label7;
        private PictureBox pictureBox6;
        private TabPage tabView;
        private Label label8;
        private DataGridView DGVV;
        private PictureBox pictureBox7;
        private Button btnSolvedView;
        private Button btnUnsolvedView;
        private Button btnSubmitUnsolved;
        private Button btnClearUnsolved;
        private Label lblTicketID;
        private TextBox txtTicketID;
        private Label label9;
        private TextBox txtUnsolvedExplain;
        private PictureBox pictureBox14;
        private PictureBox pictureBox8;
        private Label label11;
        private Label label10;
        private Label label12;
        private Label label13;
        private TextBox txtTicketSummary;
        private Button btnSubmitSolved;
        private Button btnClearSolved;
        private Label label18;

        private Button btnrefre;

        private PictureBox ProfilePictureBox;
        private TextBox txtTicketDescribeSolved;
        private Label label14;
        private Label label15;
        private TextBox txtTicketDetailSolved;
        private PictureBox pictureBox5;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private Button button1;
        private Label label16;
        private Label label17;
        private TextBox textBox7;
        private Label label19;
        private TextBox txtTicketIDSolve;
        private Button btnReportClear;
        private ComboBox cbxurg;
        private ComboBox cbxcat;
        private ComboBox cbxcat1;
        private ComboBox cbxurg1;
        private ComboBox cbxn;
        private ComboBox cbxp;
        private ComboBox cbxuu;
        private ComboBox cbxu;
        private PictureBox pictureBox11;
    }
}