namespace GUI_IT
{
    partial class frmReportManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportManage));
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
            tabMonitor = new TabPage();
            btnReOpened = new Button();
            btnSolved = new Button();
            btnUnsolved = new Button();
            lblMonitor = new Label();
            DGVT = new DataGridView();
            pictureBox5 = new PictureBox();
            tabAssign = new TabPage();
            btnViewReopenedTable = new Button();
            btnViewUnsolvedTable = new Button();
            DGVAssign = new DataGridView();
            btnAssign = new Button();
            btnClear = new Button();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtTicketID = new TextBox();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            lblAssign = new Label();
            lblLoggedIn = new Label();
            ProfilePictureBox = new PictureBox();
            cbxname = new ComboBox();
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
            tabMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabAssign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAssign).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Black;
            pictureLogo.Image = Properties.Resources.redAgentsLogo;
            pictureLogo.Location = new Point(8, 44);
            pictureLogo.Margin = new Padding(2);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(50, 44);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 40;
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
            btnLogout.TabIndex = 36;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox1.Location = new Point(-5, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1268, 44);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // Rectangle1
            // 
            Rectangle1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle1.BackColor = Color.Black;
            Rectangle1.Location = new Point(-8, 41);
            Rectangle1.Margin = new Padding(2);
            Rectangle1.Name = "Rectangle1";
            Rectangle1.Size = new Size(1290, 58);
            Rectangle1.TabIndex = 33;
            Rectangle1.TabStop = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(64, 0, 0);
            lblHeader.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(1, 6);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(307, 29);
            lblHeader.TabIndex = 42;
            lblHeader.Text = "Red Agents IT Help Desk";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(466, 94);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 47);
            label1.TabIndex = 49;
            label1.Text = "Ticket Dashboard";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox2.Location = new Point(-21, 92);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1329, 66);
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabHome);
            tabControl1.Controls.Add(tabMonitor);
            tabControl1.Controls.Add(tabAssign);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(-5, 142);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1288, 506);
            tabControl1.TabIndex = 50;
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
            tabHome.Size = new Size(1280, 465);
            tabHome.TabIndex = 2;
            tabHome.Text = "Ticket Homepage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(248, 299);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(923, 93);
            label5.TabIndex = 74;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(266, 102);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(895, 120);
            label4.TabIndex = 73;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(39, 324);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(204, 38);
            label3.TabIndex = 66;
            label3.Text = "Assign Tickets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(35, 140);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(221, 38);
            label2.TabIndex = 65;
            label2.Text = "Monitor Tickets";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(22, 282);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1160, 132);
            pictureBox4.TabIndex = 64;
            pictureBox4.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.White;
            pictureBox11.Location = new Point(21, 96);
            pictureBox11.Margin = new Padding(2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(1160, 132);
            pictureBox11.TabIndex = 63;
            pictureBox11.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Location = new Point(12, 271);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1180, 158);
            pictureBox3.TabIndex = 59;
            pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Gray;
            pictureBox8.Location = new Point(12, 85);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(1180, 158);
            pictureBox8.TabIndex = 58;
            pictureBox8.TabStop = false;
            // 
            // lblDescribeHome
            // 
            lblDescribeHome.AutoSize = true;
            lblDescribeHome.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescribeHome.Location = new Point(5, 44);
            lblDescribeHome.Margin = new Padding(2, 0, 2, 0);
            lblDescribeHome.Name = "lblDescribeHome";
            lblDescribeHome.Size = new Size(1186, 27);
            lblDescribeHome.TabIndex = 5;
            lblDescribeHome.Text = "Listed below are the different functionalities offered to you via your ticket dashboard, as well as a brief description of each. \r\n";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(412, 8);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(73, 32);
            lblUser.TabIndex = 4;
            lblUser.Text = "User!";
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcomeMessage.Location = new Point(-1, 8);
            lblWelcomeMessage.Margin = new Padding(2, 0, 2, 0);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(430, 32);
            lblWelcomeMessage.TabIndex = 1;
            lblWelcomeMessage.Text = "Welcome to your Ticket Homepage, ";
            // 
            // tabMonitor
            // 
            tabMonitor.BackColor = Color.LightGray;
            tabMonitor.Controls.Add(btnReOpened);
            tabMonitor.Controls.Add(btnSolved);
            tabMonitor.Controls.Add(btnUnsolved);
            tabMonitor.Controls.Add(lblMonitor);
            tabMonitor.Controls.Add(DGVT);
            tabMonitor.Controls.Add(pictureBox5);
            tabMonitor.Location = new Point(4, 37);
            tabMonitor.Margin = new Padding(2);
            tabMonitor.Name = "tabMonitor";
            tabMonitor.Padding = new Padding(2);
            tabMonitor.Size = new Size(1280, 465);
            tabMonitor.TabIndex = 0;
            tabMonitor.Text = "Monitor Tickets";
            // 
            // btnReOpened
            // 
            btnReOpened.BackColor = Color.FromArgb(64, 0, 0);
            btnReOpened.FlatStyle = FlatStyle.Popup;
            btnReOpened.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnReOpened.ForeColor = Color.White;
            btnReOpened.Location = new Point(1074, 349);
            btnReOpened.Margin = new Padding(2);
            btnReOpened.Name = "btnReOpened";
            btnReOpened.Size = new Size(178, 68);
            btnReOpened.TabIndex = 57;
            btnReOpened.Text = "View Re-Opened Tickets";
            btnReOpened.UseVisualStyleBackColor = false;
            // 
            // btnSolved
            // 
            btnSolved.BackColor = Color.FromArgb(64, 0, 0);
            btnSolved.FlatStyle = FlatStyle.Popup;
            btnSolved.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSolved.ForeColor = Color.White;
            btnSolved.Location = new Point(1074, 218);
            btnSolved.Margin = new Padding(2);
            btnSolved.Name = "btnSolved";
            btnSolved.Size = new Size(178, 68);
            btnSolved.TabIndex = 56;
            btnSolved.Text = "View Solved Tickets";
            btnSolved.UseVisualStyleBackColor = false;
            // 
            // btnUnsolved
            // 
            btnUnsolved.BackColor = Color.FromArgb(64, 0, 0);
            btnUnsolved.FlatStyle = FlatStyle.Popup;
            btnUnsolved.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnsolved.ForeColor = Color.White;
            btnUnsolved.Location = new Point(1072, 78);
            btnUnsolved.Margin = new Padding(2);
            btnUnsolved.Name = "btnUnsolved";
            btnUnsolved.Size = new Size(178, 68);
            btnUnsolved.TabIndex = 55;
            btnUnsolved.Text = "View Unsolved Tickets";
            btnUnsolved.UseVisualStyleBackColor = false;
            // 
            // lblMonitor
            // 
            lblMonitor.AutoSize = true;
            lblMonitor.BackColor = Color.Transparent;
            lblMonitor.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMonitor.Location = new Point(2, 8);
            lblMonitor.Margin = new Padding(2, 0, 2, 0);
            lblMonitor.Name = "lblMonitor";
            lblMonitor.Size = new Size(189, 32);
            lblMonitor.TabIndex = 54;
            lblMonitor.Text = "Monitor Tickets";
            // 
            // DGVT
            // 
            DGVT.AllowUserToAddRows = false;
            DGVT.AllowUserToDeleteRows = false;
            DGVT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVT.Location = new Point(12, 50);
            DGVT.Margin = new Padding(2);
            DGVT.Name = "DGVT";
            DGVT.ReadOnly = true;
            DGVT.RowHeadersWidth = 62;
            DGVT.RowTemplate.Height = 33;
            DGVT.Size = new Size(1032, 396);
            DGVT.TabIndex = 0;
            DGVT.CellContentClick += DGVT_CellContentClick;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DarkGray;
            pictureBox5.Location = new Point(1061, 50);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(200, 396);
            pictureBox5.TabIndex = 58;
            pictureBox5.TabStop = false;
            // 
            // tabAssign
            // 
            tabAssign.BackColor = Color.LightGray;
            tabAssign.Controls.Add(cbxname);
            tabAssign.Controls.Add(btnViewReopenedTable);
            tabAssign.Controls.Add(btnViewUnsolvedTable);
            tabAssign.Controls.Add(DGVAssign);
            tabAssign.Controls.Add(btnAssign);
            tabAssign.Controls.Add(btnClear);
            tabAssign.Controls.Add(label8);
            tabAssign.Controls.Add(txtEmail);
            tabAssign.Controls.Add(label7);
            tabAssign.Controls.Add(txtTicketID);
            tabAssign.Controls.Add(label6);
            tabAssign.Controls.Add(pictureBox6);
            tabAssign.Controls.Add(lblAssign);
            tabAssign.Location = new Point(4, 37);
            tabAssign.Margin = new Padding(2);
            tabAssign.Name = "tabAssign";
            tabAssign.Padding = new Padding(2);
            tabAssign.Size = new Size(1280, 465);
            tabAssign.TabIndex = 1;
            tabAssign.Text = "Assign Tickets";
            // 
            // btnViewReopenedTable
            // 
            btnViewReopenedTable.BackColor = Color.FromArgb(64, 0, 0);
            btnViewReopenedTable.FlatStyle = FlatStyle.Popup;
            btnViewReopenedTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewReopenedTable.ForeColor = Color.White;
            btnViewReopenedTable.Location = new Point(1086, 8);
            btnViewReopenedTable.Margin = new Padding(2);
            btnViewReopenedTable.Name = "btnViewReopenedTable";
            btnViewReopenedTable.Size = new Size(151, 42);
            btnViewReopenedTable.TabIndex = 90;
            btnViewReopenedTable.Text = "Re-opened";
            btnViewReopenedTable.UseVisualStyleBackColor = false;
            // 
            // btnViewUnsolvedTable
            // 
            btnViewUnsolvedTable.BackColor = Color.FromArgb(64, 0, 0);
            btnViewUnsolvedTable.FlatStyle = FlatStyle.Popup;
            btnViewUnsolvedTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewUnsolvedTable.ForeColor = Color.White;
            btnViewUnsolvedTable.Location = new Point(922, 8);
            btnViewUnsolvedTable.Margin = new Padding(2);
            btnViewUnsolvedTable.Name = "btnViewUnsolvedTable";
            btnViewUnsolvedTable.Size = new Size(139, 42);
            btnViewUnsolvedTable.TabIndex = 89;
            btnViewUnsolvedTable.Text = "Unsolved";
            btnViewUnsolvedTable.UseVisualStyleBackColor = false;
            // 
            // DGVAssign
            // 
            DGVAssign.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAssign.Location = new Point(696, 68);
            DGVAssign.Margin = new Padding(2);
            DGVAssign.Name = "DGVAssign";
            DGVAssign.RowHeadersWidth = 62;
            DGVAssign.RowTemplate.Height = 33;
            DGVAssign.Size = new Size(541, 372);
            DGVAssign.TabIndex = 88;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.FromArgb(64, 0, 0);
            btnAssign.FlatStyle = FlatStyle.Popup;
            btnAssign.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(236, 394);
            btnAssign.Margin = new Padding(2);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(162, 51);
            btnAssign.TabIndex = 87;
            btnAssign.Text = "Assign Ticket";
            btnAssign.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 0, 0);
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(20, 394);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 51);
            btnClear.TabIndex = 86;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkGray;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(15, 171);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(612, 30);
            label8.TabIndex = 83;
            label8.Text = "Enter username of the IT member you wish to assign it to:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(18, 302);
            txtEmail.Margin = new Padding(5);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(609, 34);
            txtEmail.TabIndex = 82;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkGray;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(21, 268);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(397, 30);
            label7.TabIndex = 81;
            label7.Text = "Enter the above user's email address:";
            // 
            // txtTicketID
            // 
            txtTicketID.Anchor = AnchorStyles.None;
            txtTicketID.Location = new Point(18, 107);
            txtTicketID.Margin = new Padding(5);
            txtTicketID.MaxLength = 50;
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(609, 34);
            txtTicketID.TabIndex = 80;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkGray;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 74);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(465, 30);
            label6.TabIndex = 79;
            label6.Text = "Enter Ticket ID of ticket you want to assign:";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.DarkGray;
            pictureBox6.Location = new Point(10, 51);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(654, 328);
            pictureBox6.TabIndex = 85;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // lblAssign
            // 
            lblAssign.AutoSize = true;
            lblAssign.BackColor = Color.Transparent;
            lblAssign.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAssign.Location = new Point(6, 6);
            lblAssign.Margin = new Padding(2, 0, 2, 0);
            lblAssign.Name = "lblAssign";
            lblAssign.Size = new Size(174, 32);
            lblAssign.TabIndex = 55;
            lblAssign.Text = "Assign Tickets";
            // 
            // lblLoggedIn
            // 
            lblLoggedIn.AutoSize = true;
            lblLoggedIn.BackColor = Color.Black;
            lblLoggedIn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoggedIn.ForeColor = Color.White;
            lblLoggedIn.Location = new Point(974, 52);
            lblLoggedIn.Margin = new Padding(2, 0, 2, 0);
            lblLoggedIn.Name = "lblLoggedIn";
            lblLoggedIn.Size = new Size(171, 28);
            lblLoggedIn.TabIndex = 5;
            lblLoggedIn.Text = "Logged in as: User";
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.BackColor = Color.Black;
            ProfilePictureBox.BackgroundImage = Properties.Resources.Profile_Picture;
            ProfilePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            ProfilePictureBox.Location = new Point(1202, 49);
            ProfilePictureBox.Margin = new Padding(2);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(48, 35);
            ProfilePictureBox.TabIndex = 6;
            ProfilePictureBox.TabStop = false;
            // 
            // cbxname
            // 
            cbxname.FormattingEnabled = true;
            cbxname.Location = new Point(19, 203);
            cbxname.Name = "cbxname";
            cbxname.Size = new Size(608, 36);
            cbxname.TabIndex = 91;
            // 
            // frmReportManage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 641);
            Controls.Add(lblLoggedIn);
            Controls.Add(ProfilePictureBox);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lblHeader);
            Controls.Add(pictureLogo);
            Controls.Add(btnLogout);
            Controls.Add(Rectangle1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmReportManage";
            Text = "IT Help Desk Report Manager Ticket Dashboard";
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
            tabMonitor.ResumeLayout(false);
            tabMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabAssign.ResumeLayout(false);
            tabAssign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAssign).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private TabPage tabMonitor;
        private TabPage tabAssign;
        private DataGridView DGVT;
        private Label lblMonitor;
        private Button btnReOpened;
        private Button btnSolved;
        private Button btnUnsolved;
        private Label lblAssign;
        private TabPage tabHome;
        private Label lblLoggedIn;
        private PictureBox ProfilePictureBox;
        private Label lblWelcomeMessage;
        private Label lblUser;
        private Label lblDescribeHome;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private PictureBox pictureBox4;
        private PictureBox pictureBox11;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox5;
        private Button btnAssign;
        private Button btnClear;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtTicketID;
        private Label label6;
        private PictureBox pictureBox6;
        private Button btnViewReopenedTable;
        private Button btnViewUnsolvedTable;
        private DataGridView DGVAssign;
        private ComboBox cbxn;
        private ComboBox cbxname;
    }
}