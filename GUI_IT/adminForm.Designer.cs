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
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pnlReportGenerate = new Panel();
            tabReportGeneration = new TabControl();
            tabHome = new TabPage();
            ProfilePictureBox = new PictureBox();
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
            label19 = new Label();
            label14 = new Label();
            txtSolvedProblem = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtSolvedDescription = new TextBox();
            pictureBox15 = new PictureBox();
            txtSolvedProjectEmail = new TextBox();
            txtSolvedTicketID = new TextBox();
            txtSolvedUrgency = new TextBox();
            txtSolvedITEmail = new TextBox();
            txtSolvedCategory = new TextBox();
            btnSubmitSolved = new Button();
            btnClearSolved = new Button();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            label2 = new Label();
            tabUnsolved = new TabPage();
            label13 = new Label();
            txtTicketSummary = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtUnsolvedExplain = new TextBox();
            pictureBox14 = new PictureBox();
            lblTicketID = new Label();
            txtProjectEmail = new TextBox();
            txtTicketID = new TextBox();
            txtTicketUrgency = new TextBox();
            txtITEmail = new TextBox();
            txtProblemCategory = new TextBox();
            btnSubmitUnsolved = new Button();
            btnClearUnsolved = new Button();
            label3 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox11 = new PictureBox();
            lblReportGen = new Label();
            pictureBox3 = new PictureBox();
            btnApproveDeny = new Button();
            btnClear = new Button();
            pictureBox4 = new PictureBox();
            lblLoggedIn = new Label();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlReportGenerate.SuspendLayout();
            tabReportGeneration.SuspendLayout();
            tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVV).BeginInit();
            tabSolved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            tabUnsolved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            btnGenerate.Location = new Point(228, 48);
            btnGenerate.Margin = new Padding(2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(184, 45);
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
            btnRegistration.Location = new Point(86, 45);
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
            btnLogout.Location = new Point(1145, 0);
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
            pictureBox1.Size = new Size(1255, 41);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Rectangle1
            // 
            Rectangle1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle1.BackColor = Color.Black;
            Rectangle1.Location = new Point(-5, 25);
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
            DGVR.Size = new Size(990, 447);
            DGVR.TabIndex = 19;
            DGVR.CellContentClick += dataGridView1_CellContentClick;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(416, 101);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(430, 47);
            label1.TabIndex = 50;
            label1.Text = "New User Registration";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox2.Location = new Point(-3, 96);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1268, 64);
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // pnlReportGenerate
            // 
            pnlReportGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlReportGenerate.Controls.Add(tabReportGeneration);
            pnlReportGenerate.Controls.Add(lblReportGen);
            pnlReportGenerate.Controls.Add(pictureBox3);
            pnlReportGenerate.Location = new Point(-4, 94);
            pnlReportGenerate.Margin = new Padding(2);
            pnlReportGenerate.Name = "pnlReportGenerate";
            pnlReportGenerate.Size = new Size(1274, 547);
            pnlReportGenerate.TabIndex = 15;
            pnlReportGenerate.Paint += pnlReportGenerate_Paint;
            // 
            // tabReportGeneration
            // 
            tabReportGeneration.Controls.Add(tabHome);
            tabReportGeneration.Controls.Add(tabView);
            tabReportGeneration.Controls.Add(tabSolved);
            tabReportGeneration.Controls.Add(tabUnsolved);
            tabReportGeneration.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tabReportGeneration.Location = new Point(0, 68);
            tabReportGeneration.Name = "tabReportGeneration";
            tabReportGeneration.SelectedIndex = 0;
            tabReportGeneration.Size = new Size(1289, 489);
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
            tabHome.Name = "tabHome";
            tabHome.Size = new Size(1281, 448);
            tabHome.TabIndex = 3;
            tabHome.Text = "Report Homepage";
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.BackColor = Color.Black;
            ProfilePictureBox.BackgroundImage = (Image)resources.GetObject("ProfilePictureBox.BackgroundImage");
            ProfilePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            ProfilePictureBox.Location = new Point(1202, 49);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(47, 35);
            ProfilePictureBox.TabIndex = 83;
            ProfilePictureBox.TabStop = false;
            ProfilePictureBox.Click += ProfilePictureBox_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(355, 287);
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
            label4.Name = "label4";
            label4.Size = new Size(322, 38);
            label4.TabIndex = 78;
            label4.Text = "Unsolved Ticket Report";
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.White;
            pictureBox13.Location = new Point(23, 280);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(1160, 133);
            pictureBox13.TabIndex = 77;
            pictureBox13.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Gray;
            pictureBox10.Location = new Point(14, 265);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(1180, 163);
            pictureBox10.TabIndex = 73;
            pictureBox10.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(34, 142);
            label6.Name = "label6";
            label6.Size = new Size(288, 38);
            label6.TabIndex = 80;
            label6.Text = "Solved Ticket Report";
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.White;
            pictureBox12.Location = new Point(25, 97);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(1160, 135);
            pictureBox12.TabIndex = 76;
            pictureBox12.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Gray;
            pictureBox9.Location = new Point(15, 81);
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
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(73, 32);
            lblUser.TabIndex = 53;
            lblUser.Text = "User!";
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcomeMessage.Location = new Point(1, 7);
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
            tabView.Name = "tabView";
            tabView.Size = new Size(1281, 448);
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
            btnSolvedView.Name = "btnSolvedView";
            btnSolvedView.Size = new Size(132, 114);
            btnSolvedView.TabIndex = 75;
            btnSolvedView.Text = "View Solved Tickets";
            btnSolvedView.UseVisualStyleBackColor = false;
            // 
            // btnUnsolvedView
            // 
            btnUnsolvedView.BackColor = Color.FromArgb(64, 0, 0);
            btnUnsolvedView.FlatStyle = FlatStyle.Popup;
            btnUnsolvedView.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnsolvedView.ForeColor = Color.White;
            btnUnsolvedView.Location = new Point(1110, 92);
            btnUnsolvedView.Name = "btnUnsolvedView";
            btnUnsolvedView.Size = new Size(132, 114);
            btnUnsolvedView.TabIndex = 74;
            btnUnsolvedView.Text = "View Unsolved Tickets";
            btnUnsolvedView.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.DarkGray;
            pictureBox7.Location = new Point(1097, 45);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(159, 379);
            pictureBox7.TabIndex = 73;
            pictureBox7.TabStop = false;
            // 
            // DGVV
            // 
            DGVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVV.Location = new Point(16, 45);
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
            label8.Name = "label8";
            label8.Size = new Size(154, 32);
            label8.TabIndex = 57;
            label8.Text = "View Tickets";
            // 
            // tabSolved
            // 
            tabSolved.BackColor = Color.LightGray;
            tabSolved.Controls.Add(label19);
            tabSolved.Controls.Add(label14);
            tabSolved.Controls.Add(txtSolvedProblem);
            tabSolved.Controls.Add(label15);
            tabSolved.Controls.Add(label16);
            tabSolved.Controls.Add(label17);
            tabSolved.Controls.Add(label18);
            tabSolved.Controls.Add(txtSolvedDescription);
            tabSolved.Controls.Add(pictureBox15);
            tabSolved.Controls.Add(txtSolvedProjectEmail);
            tabSolved.Controls.Add(txtSolvedTicketID);
            tabSolved.Controls.Add(txtSolvedUrgency);
            tabSolved.Controls.Add(txtSolvedITEmail);
            tabSolved.Controls.Add(txtSolvedCategory);
            tabSolved.Controls.Add(btnSubmitSolved);
            tabSolved.Controls.Add(btnClearSolved);
            tabSolved.Controls.Add(pictureBox16);
            tabSolved.Controls.Add(pictureBox17);
            tabSolved.Controls.Add(label2);
            tabSolved.Location = new Point(4, 37);
            tabSolved.Name = "tabSolved";
            tabSolved.Padding = new Padding(3);
            tabSolved.Size = new Size(1281, 448);
            tabSolved.TabIndex = 1;
            tabSolved.Text = "Solved Tickets";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.DarkGray;
            label19.Location = new Point(23, 52);
            label19.Name = "label19";
            label19.Size = new Size(102, 28);
            label19.TabIndex = 121;
            label19.Text = "Ticket ID:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.DarkGray;
            label14.Location = new Point(21, 203);
            label14.Name = "label14";
            label14.Size = new Size(362, 28);
            label14.TabIndex = 120;
            label14.Text = "What was the select ticket category?";
            // 
            // txtSolvedProblem
            // 
            txtSolvedProblem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtSolvedProblem.Location = new Point(32, 292);
            txtSolvedProblem.MaxLength = 500;
            txtSolvedProblem.Multiline = true;
            txtSolvedProblem.Name = "txtSolvedProblem";
            txtSolvedProblem.PlaceholderText = "Provide a brief summary of the ticket description.";
            txtSolvedProblem.Size = new Size(650, 73);
            txtSolvedProblem.TabIndex = 119;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.DarkGray;
            label15.Location = new Point(22, 127);
            label15.Name = "label15";
            label15.Size = new Size(159, 28);
            label15.TabIndex = 118;
            label15.Text = "Ticket Urgency:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.DarkGray;
            label16.Location = new Point(216, 127);
            label16.Name = "label16";
            label16.Size = new Size(310, 28);
            label16.TabIndex = 117;
            label16.Text = "Email of user who raised ticket:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.DarkGray;
            label17.Location = new Point(214, 53);
            label17.Name = "label17";
            label17.Size = new Size(465, 28);
            label17.TabIndex = 116;
            label17.Text = "Email of IT member who was assigned to ticket:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.DarkGray;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(710, 55);
            label18.Name = "label18";
            label18.Size = new Size(528, 56);
            label18.TabIndex = 114;
            label18.Text = "Provide the solution to the raised ticket below, as well\r\nas any other potentially important ticket details.";
            // 
            // txtSolvedDescription
            // 
            txtSolvedDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtSolvedDescription.Location = new Point(721, 127);
            txtSolvedDescription.MaxLength = 750;
            txtSolvedDescription.Multiline = true;
            txtSolvedDescription.Name = "txtSolvedDescription";
            txtSolvedDescription.PlaceholderText = "Include any other necessary ticket details here.";
            txtSolvedDescription.Size = new Size(506, 281);
            txtSolvedDescription.TabIndex = 113;
            // 
            // pictureBox15
            // 
            pictureBox15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox15.BackColor = Color.Gray;
            pictureBox15.Location = new Point(709, 117);
            pictureBox15.Margin = new Padding(2);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(527, 302);
            pictureBox15.TabIndex = 112;
            pictureBox15.TabStop = false;
            // 
            // txtSolvedProjectEmail
            // 
            txtSolvedProjectEmail.Location = new Point(218, 159);
            txtSolvedProjectEmail.Name = "txtSolvedProjectEmail";
            txtSolvedProjectEmail.Size = new Size(462, 34);
            txtSolvedProjectEmail.TabIndex = 111;
            // 
            // txtSolvedTicketID
            // 
            txtSolvedTicketID.Location = new Point(24, 83);
            txtSolvedTicketID.Name = "txtSolvedTicketID";
            txtSolvedTicketID.Size = new Size(162, 34);
            txtSolvedTicketID.TabIndex = 110;
            // 
            // txtSolvedUrgency
            // 
            txtSolvedUrgency.Location = new Point(24, 158);
            txtSolvedUrgency.Name = "txtSolvedUrgency";
            txtSolvedUrgency.Size = new Size(164, 34);
            txtSolvedUrgency.TabIndex = 109;
            // 
            // txtSolvedITEmail
            // 
            txtSolvedITEmail.Location = new Point(218, 84);
            txtSolvedITEmail.Name = "txtSolvedITEmail";
            txtSolvedITEmail.Size = new Size(462, 34);
            txtSolvedITEmail.TabIndex = 108;
            // 
            // txtSolvedCategory
            // 
            txtSolvedCategory.Location = new Point(22, 234);
            txtSolvedCategory.Name = "txtSolvedCategory";
            txtSolvedCategory.Size = new Size(658, 34);
            txtSolvedCategory.TabIndex = 107;
            // 
            // btnSubmitSolved
            // 
            btnSubmitSolved.BackColor = Color.FromArgb(64, 0, 0);
            btnSubmitSolved.FlatStyle = FlatStyle.Popup;
            btnSubmitSolved.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitSolved.ForeColor = Color.White;
            btnSubmitSolved.Location = new Point(204, 386);
            btnSubmitSolved.Name = "btnSubmitSolved";
            btnSubmitSolved.Size = new Size(159, 38);
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
            btnClearSolved.Location = new Point(26, 386);
            btnClearSolved.Name = "btnClearSolved";
            btnClearSolved.Size = new Size(159, 38);
            btnClearSolved.TabIndex = 105;
            btnClearSolved.Text = "Clear";
            btnClearSolved.UseVisualStyleBackColor = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox16.BackColor = Color.Gray;
            pictureBox16.Location = new Point(21, 284);
            pictureBox16.Margin = new Padding(2);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(672, 90);
            pictureBox16.TabIndex = 115;
            pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = Color.DarkGray;
            pictureBox17.Location = new Point(12, 48);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(1239, 383);
            pictureBox17.TabIndex = 104;
            pictureBox17.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(418, 32);
            label2.TabIndex = 56;
            label2.Text = "Creating a Report for Solved Tickets";
            // 
            // tabUnsolved
            // 
            tabUnsolved.BackColor = Color.LightGray;
            tabUnsolved.Controls.Add(label13);
            tabUnsolved.Controls.Add(txtTicketSummary);
            tabUnsolved.Controls.Add(label12);
            tabUnsolved.Controls.Add(label11);
            tabUnsolved.Controls.Add(label10);
            tabUnsolved.Controls.Add(label9);
            tabUnsolved.Controls.Add(txtUnsolvedExplain);
            tabUnsolved.Controls.Add(pictureBox14);
            tabUnsolved.Controls.Add(lblTicketID);
            tabUnsolved.Controls.Add(txtProjectEmail);
            tabUnsolved.Controls.Add(txtTicketID);
            tabUnsolved.Controls.Add(txtTicketUrgency);
            tabUnsolved.Controls.Add(txtITEmail);
            tabUnsolved.Controls.Add(txtProblemCategory);
            tabUnsolved.Controls.Add(btnSubmitUnsolved);
            tabUnsolved.Controls.Add(btnClearUnsolved);
            tabUnsolved.Controls.Add(label3);
            tabUnsolved.Controls.Add(pictureBox8);
            tabUnsolved.Controls.Add(pictureBox11);
            tabUnsolved.Location = new Point(4, 37);
            tabUnsolved.Name = "tabUnsolved";
            tabUnsolved.Size = new Size(1281, 448);
            tabUnsolved.TabIndex = 2;
            tabUnsolved.Text = "Unsolved Tickets";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DarkGray;
            label13.Location = new Point(20, 200);
            label13.Name = "label13";
            label13.Size = new Size(362, 28);
            label13.TabIndex = 102;
            label13.Text = "What was the select ticket category?";
            // 
            // txtTicketSummary
            // 
            txtTicketSummary.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTicketSummary.Location = new Point(29, 292);
            txtTicketSummary.MaxLength = 500;
            txtTicketSummary.Multiline = true;
            txtTicketSummary.Name = "txtTicketSummary";
            txtTicketSummary.PlaceholderText = "Provide a brief summary of the ticket description.";
            txtTicketSummary.Size = new Size(650, 73);
            txtTicketSummary.TabIndex = 101;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DarkGray;
            label12.Location = new Point(21, 126);
            label12.Name = "label12";
            label12.Size = new Size(159, 28);
            label12.TabIndex = 100;
            label12.Text = "Ticket Urgency:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkGray;
            label11.Location = new Point(215, 126);
            label11.Name = "label11";
            label11.Size = new Size(310, 28);
            label11.TabIndex = 99;
            label11.Text = "Email of user who raised ticket:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGray;
            label10.Location = new Point(213, 52);
            label10.Name = "label10";
            label10.Size = new Size(465, 28);
            label10.TabIndex = 98;
            label10.Text = "Email of IT member who was assigned to ticket:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkGray;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(708, 52);
            label9.Name = "label9";
            label9.Size = new Size(542, 50);
            label9.TabIndex = 95;
            label9.Text = "Note any potential solution ideas here. Also make note of \r\nwho you think should solve this ticket should it be re-opened. ";
            // 
            // txtUnsolvedExplain
            // 
            txtUnsolvedExplain.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtUnsolvedExplain.Location = new Point(720, 119);
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
            pictureBox14.BackColor = Color.Gray;
            pictureBox14.Location = new Point(708, 108);
            pictureBox14.Margin = new Padding(2);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(527, 310);
            pictureBox14.TabIndex = 93;
            pictureBox14.TabStop = false;
            // 
            // lblTicketID
            // 
            lblTicketID.AutoSize = true;
            lblTicketID.BackColor = Color.DarkGray;
            lblTicketID.Location = new Point(17, 52);
            lblTicketID.Name = "lblTicketID";
            lblTicketID.Size = new Size(102, 28);
            lblTicketID.TabIndex = 92;
            lblTicketID.Text = "Ticket ID:";
            // 
            // txtProjectEmail
            // 
            txtProjectEmail.Location = new Point(217, 158);
            txtProjectEmail.Name = "txtProjectEmail";
            txtProjectEmail.Size = new Size(462, 34);
            txtProjectEmail.TabIndex = 91;
            // 
            // txtTicketID
            // 
            txtTicketID.Location = new Point(20, 83);
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(162, 34);
            txtTicketID.TabIndex = 88;
            // 
            // txtTicketUrgency
            // 
            txtTicketUrgency.Location = new Point(20, 159);
            txtTicketUrgency.Name = "txtTicketUrgency";
            txtTicketUrgency.Size = new Size(164, 34);
            txtTicketUrgency.TabIndex = 87;
            // 
            // txtITEmail
            // 
            txtITEmail.Location = new Point(217, 83);
            txtITEmail.Name = "txtITEmail";
            txtITEmail.Size = new Size(462, 34);
            txtITEmail.TabIndex = 86;
            // 
            // txtProblemCategory
            // 
            txtProblemCategory.Location = new Point(21, 232);
            txtProblemCategory.Name = "txtProblemCategory";
            txtProblemCategory.Size = new Size(658, 34);
            txtProblemCategory.TabIndex = 85;
            // 
            // btnSubmitUnsolved
            // 
            btnSubmitUnsolved.BackColor = Color.FromArgb(64, 0, 0);
            btnSubmitUnsolved.FlatStyle = FlatStyle.Popup;
            btnSubmitUnsolved.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitUnsolved.ForeColor = Color.White;
            btnSubmitUnsolved.Location = new Point(203, 382);
            btnSubmitUnsolved.Name = "btnSubmitUnsolved";
            btnSubmitUnsolved.Size = new Size(159, 38);
            btnSubmitUnsolved.TabIndex = 83;
            btnSubmitUnsolved.Text = "Submit Report";
            btnSubmitUnsolved.UseVisualStyleBackColor = false;
            // 
            // btnClearUnsolved
            // 
            btnClearUnsolved.BackColor = Color.FromArgb(64, 0, 0);
            btnClearUnsolved.FlatStyle = FlatStyle.Popup;
            btnClearUnsolved.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearUnsolved.ForeColor = Color.White;
            btnClearUnsolved.Location = new Point(25, 382);
            btnClearUnsolved.Name = "btnClearUnsolved";
            btnClearUnsolved.Size = new Size(159, 38);
            btnClearUnsolved.TabIndex = 82;
            btnClearUnsolved.Text = "Clear";
            btnClearUnsolved.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(0, 6);
            label3.Name = "label3";
            label3.Size = new Size(447, 32);
            label3.TabIndex = 57;
            label3.Text = "Creating a Report for Unsolved Tickets";
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox8.BackColor = Color.Gray;
            pictureBox8.Location = new Point(20, 283);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(672, 90);
            pictureBox8.TabIndex = 97;
            pictureBox8.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.DarkGray;
            pictureBox11.Location = new Point(11, 47);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(1239, 383);
            pictureBox11.TabIndex = 81;
            pictureBox11.TabStop = false;
            // 
            // lblReportGen
            // 
            lblReportGen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReportGen.AutoSize = true;
            lblReportGen.BackColor = Color.FromArgb(64, 0, 0);
            lblReportGen.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblReportGen.ForeColor = Color.White;
            lblReportGen.Location = new Point(463, 4);
            lblReportGen.Margin = new Padding(2, 0, 2, 0);
            lblReportGen.Name = "lblReportGen";
            lblReportGen.Size = new Size(357, 47);
            lblReportGen.TabIndex = 17;
            lblReportGen.Text = "Report Generation";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox3.Location = new Point(-5, -14);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1271, 77);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // btnApproveDeny
            // 
            btnApproveDeny.BackColor = Color.FromArgb(64, 0, 0);
            btnApproveDeny.FlatStyle = FlatStyle.Popup;
            btnApproveDeny.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnApproveDeny.ForeColor = Color.White;
            btnApproveDeny.Location = new Point(1050, 316);
            btnApproveDeny.Name = "btnApproveDeny";
            btnApproveDeny.Size = new Size(165, 65);
            btnApproveDeny.TabIndex = 51;
            btnApproveDeny.Text = "Update Status";
            btnApproveDeny.UseVisualStyleBackColor = false;
            btnApproveDeny.Click += btnApproveDeny_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 0, 0);
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(1050, 207);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(165, 65);
            btnClear.TabIndex = 52;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
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
            lblLoggedIn.Location = new Point(910, 53);
            lblLoggedIn.Name = "lblLoggedIn";
            lblLoggedIn.Size = new Size(171, 28);
            lblLoggedIn.TabIndex = 0;
            lblLoggedIn.Text = "Logged in as: User";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.DarkGray;
            pictureBox6.Location = new Point(1035, 181);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(195, 225);
            pictureBox6.TabIndex = 73;
            pictureBox6.TabStop = false;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 641);
            Controls.Add(ProfilePictureBox);
            Controls.Add(lblLoggedIn);
            Controls.Add(pictureBox4);
            Controls.Add(pnlReportGenerate);
            Controls.Add(label1);
            Controls.Add(btnApproveDeny);
            Controls.Add(btnClear);
            Controls.Add(pictureBox2);
            Controls.Add(DGVR);
            Controls.Add(lblHeader);
            Controls.Add(btnGenerate);
            Controls.Add(btnRegistration);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Controls.Add(Rectangle1);
            Controls.Add(pictureBox6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmAdmin";
            Text = "IT Help Desk Admin Registration";
            Load += frmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlReportGenerate.ResumeLayout(false);
            pnlReportGenerate.PerformLayout();
            tabReportGeneration.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            tabUnsolved.ResumeLayout(false);
            tabUnsolved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label label1;
        private PictureBox pictureBox2;
        private Panel pnlReportGenerate;
        private Label lblReportGen;
        private PictureBox pictureBox3;
        private Button btnApproveDeny;
        private Button btnClear;
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
        private PictureBox pictureBox11;
        private Label lblTicketID;
        private TextBox txtProjectEmail;
        private TextBox txtTicketID;
        private TextBox txtTicketUrgency;
        private TextBox txtITEmail;
        private TextBox txtProblemCategory;
        private Label label9;
        private TextBox txtUnsolvedExplain;
        private PictureBox pictureBox14;
        private PictureBox pictureBox8;
        private Label label11;
        private Label label10;
        private Label label12;
        private Label label13;
        private TextBox txtTicketSummary;
        private Label label19;
        private Label label14;
        private TextBox txtSolvedProblem;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtSolvedDescription;
        private PictureBox pictureBox15;
        private TextBox txtSolvedProjectEmail;
        private TextBox txtSolvedTicketID;
        private TextBox txtSolvedUrgency;
        private TextBox txtSolvedITEmail;
        private TextBox txtSolvedCategory;
        private Button btnSubmitSolved;
        private Button btnClearSolved;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private Label label18;
        private PictureBox ProfilePictureBox;
    }
}