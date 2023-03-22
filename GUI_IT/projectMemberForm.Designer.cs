namespace GUI_IT
{
    partial class frmProjectMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectMember));
            pictureLogo = new PictureBox();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            Rectangle1 = new PictureBox();
            btnTickets = new Button();
            btnProblemList = new Button();
            btnOnlineHelp = new Button();
            pnlTickets = new Panel();
            tabProjectMem = new TabControl();
            tabHome = new TabPage();
            lblUser = new Label();
            lblDescribeHome = new Label();
            lblWelcomeMessage = new Label();
            tabMyTickets = new TabPage();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            tabRaiseTicket = new TabPage();
            btnRaise = new Button();
            cbxType = new ComboBox();
            cbxUrgency = new ComboBox();
            lblUrgency = new Label();
            lblType = new Label();
            txtProblemDescribe = new TextBox();
            pictureBox2 = new PictureBox();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            tabReopenTicket = new TabPage();
            txtID = new TextBox();
            lblTicketID = new Label();
            cbxReopenReason = new ComboBox();
            lblReopenReason = new Label();
            btnReopenTicket = new Button();
            btnReopenClear = new Button();
            txtReopenTicket = new TextBox();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            lblTicket = new Label();
            pictureBox3 = new PictureBox();
            pnlProblemList = new Panel();
            lblProblem = new Label();
            pictureBox4 = new PictureBox();
            lblOnlineHelp = new Label();
            pictureBox5 = new PictureBox();
            lblHeader = new Label();
            lblLoggedIn = new Label();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            pnlTickets.SuspendLayout();
            tabProjectMem.SuspendLayout();
            tabHome.SuspendLayout();
            tabMyTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabRaiseTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabReopenTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlProblemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Black;
            pictureLogo.Image = Properties.Resources.redAgentsLogo;
            pictureLogo.Location = new Point(6, 41);
            pictureLogo.Margin = new Padding(2);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(54, 44);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 35;
            pictureLogo.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(64, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1145, -2);
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
            pictureBox1.Location = new Point(-8, -2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1272, 41);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Rectangle1
            // 
            Rectangle1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle1.BackColor = Color.Black;
            Rectangle1.Location = new Point(-8, 22);
            Rectangle1.Margin = new Padding(2);
            Rectangle1.Name = "Rectangle1";
            Rectangle1.Size = new Size(1272, 75);
            Rectangle1.TabIndex = 24;
            Rectangle1.TabStop = false;
            // 
            // btnTickets
            // 
            btnTickets.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTickets.BackColor = Color.Black;
            btnTickets.FlatStyle = FlatStyle.Popup;
            btnTickets.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTickets.ForeColor = Color.White;
            btnTickets.Location = new Point(353, 42);
            btnTickets.Margin = new Padding(2);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(189, 49);
            btnTickets.TabIndex = 36;
            btnTickets.Text = "Ticket Dashboard";
            btnTickets.UseVisualStyleBackColor = false;
            btnTickets.Click += btnTickets_Click;
            // 
            // btnProblemList
            // 
            btnProblemList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProblemList.BackColor = Color.Black;
            btnProblemList.FlatStyle = FlatStyle.Popup;
            btnProblemList.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnProblemList.ForeColor = Color.White;
            btnProblemList.Location = new Point(209, 43);
            btnProblemList.Margin = new Padding(2);
            btnProblemList.Name = "btnProblemList";
            btnProblemList.Size = new Size(148, 47);
            btnProblemList.TabIndex = 37;
            btnProblemList.Text = "Problem List";
            btnProblemList.UseVisualStyleBackColor = false;
            btnProblemList.Click += btnProblemList_Click;
            // 
            // btnOnlineHelp
            // 
            btnOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOnlineHelp.BackColor = Color.Black;
            btnOnlineHelp.FlatStyle = FlatStyle.Popup;
            btnOnlineHelp.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOnlineHelp.ForeColor = Color.White;
            btnOnlineHelp.Location = new Point(76, 44);
            btnOnlineHelp.Margin = new Padding(4);
            btnOnlineHelp.Name = "btnOnlineHelp";
            btnOnlineHelp.Size = new Size(141, 47);
            btnOnlineHelp.TabIndex = 38;
            btnOnlineHelp.Text = "Online Help";
            btnOnlineHelp.UseVisualStyleBackColor = false;
            btnOnlineHelp.Click += btnOnlineHelp_Click;
            // 
            // pnlTickets
            // 
            pnlTickets.Controls.Add(tabProjectMem);
            pnlTickets.Controls.Add(lblTicket);
            pnlTickets.Controls.Add(pictureBox3);
            pnlTickets.Location = new Point(0, 89);
            pnlTickets.Margin = new Padding(2);
            pnlTickets.Name = "pnlTickets";
            pnlTickets.Size = new Size(1285, 558);
            pnlTickets.TabIndex = 45;
            pnlTickets.Paint += pnlOnlineHelp_Paint;
            // 
            // tabProjectMem
            // 
            tabProjectMem.Controls.Add(tabHome);
            tabProjectMem.Controls.Add(tabMyTickets);
            tabProjectMem.Controls.Add(tabRaiseTicket);
            tabProjectMem.Controls.Add(tabReopenTicket);
            tabProjectMem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tabProjectMem.Location = new Point(-8, 67);
            tabProjectMem.Name = "tabProjectMem";
            tabProjectMem.SelectedIndex = 0;
            tabProjectMem.Size = new Size(1289, 496);
            tabProjectMem.TabIndex = 50;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.LightGray;
            tabHome.Controls.Add(label11);
            tabHome.Controls.Add(label10);
            tabHome.Controls.Add(label9);
            tabHome.Controls.Add(label8);
            tabHome.Controls.Add(pictureBox13);
            tabHome.Controls.Add(pictureBox12);
            tabHome.Controls.Add(label6);
            tabHome.Controls.Add(label7);
            tabHome.Controls.Add(pictureBox11);
            tabHome.Controls.Add(pictureBox10);
            tabHome.Controls.Add(pictureBox9);
            tabHome.Controls.Add(pictureBox8);
            tabHome.Controls.Add(lblUser);
            tabHome.Controls.Add(lblDescribeHome);
            tabHome.Controls.Add(lblWelcomeMessage);
            tabHome.Location = new Point(4, 37);
            tabHome.Name = "tabHome";
            tabHome.Size = new Size(1281, 455);
            tabHome.TabIndex = 3;
            tabHome.Text = "Ticket Homepage";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(419, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(73, 32);
            lblUser.TabIndex = 3;
            lblUser.Text = "User!";
            lblUser.Click += lblUser_Click;
            // 
            // lblDescribeHome
            // 
            lblDescribeHome.AutoSize = true;
            lblDescribeHome.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescribeHome.Location = new Point(10, 45);
            lblDescribeHome.Name = "lblDescribeHome";
            lblDescribeHome.Size = new Size(1186, 27);
            lblDescribeHome.TabIndex = 2;
            lblDescribeHome.Text = "Listed below are the different functionalities offered to you via your ticket dashboard, as well as a brief description of each. \r\n";
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcomeMessage.Location = new Point(6, 8);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(430, 32);
            lblWelcomeMessage.TabIndex = 0;
            lblWelcomeMessage.Text = "Welcome to your Ticket Homepage, ";
            // 
            // tabMyTickets
            // 
            tabMyTickets.BackColor = Color.LightGray;
            tabMyTickets.Controls.Add(dataGridView1);
            tabMyTickets.Controls.Add(label5);
            tabMyTickets.Location = new Point(4, 37);
            tabMyTickets.Name = "tabMyTickets";
            tabMyTickets.Size = new Size(1281, 455);
            tabMyTickets.TabIndex = 2;
            tabMyTickets.Text = "My Tickets";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1170, 377);
            dataGridView1.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(10, 6);
            label5.Name = "label5";
            label5.Size = new Size(133, 32);
            label5.TabIndex = 53;
            label5.Text = "My Tickets";
            // 
            // tabRaiseTicket
            // 
            tabRaiseTicket.BackColor = Color.LightGray;
            tabRaiseTicket.Controls.Add(btnRaise);
            tabRaiseTicket.Controls.Add(cbxType);
            tabRaiseTicket.Controls.Add(cbxUrgency);
            tabRaiseTicket.Controls.Add(lblUrgency);
            tabRaiseTicket.Controls.Add(lblType);
            tabRaiseTicket.Controls.Add(txtProblemDescribe);
            tabRaiseTicket.Controls.Add(pictureBox2);
            tabRaiseTicket.Controls.Add(btnClear);
            tabRaiseTicket.Controls.Add(label1);
            tabRaiseTicket.Controls.Add(label2);
            tabRaiseTicket.Location = new Point(4, 37);
            tabRaiseTicket.Name = "tabRaiseTicket";
            tabRaiseTicket.Padding = new Padding(3);
            tabRaiseTicket.Size = new Size(1281, 455);
            tabRaiseTicket.TabIndex = 0;
            tabRaiseTicket.Text = "Raise Tickets";
            // 
            // btnRaise
            // 
            btnRaise.BackColor = Color.FromArgb(64, 0, 0);
            btnRaise.FlatStyle = FlatStyle.Popup;
            btnRaise.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaise.ForeColor = Color.White;
            btnRaise.Location = new Point(1067, 388);
            btnRaise.Name = "btnRaise";
            btnRaise.Size = new Size(161, 40);
            btnRaise.TabIndex = 61;
            btnRaise.Text = "Raise Ticket";
            btnRaise.UseVisualStyleBackColor = false;
            btnRaise.Click += btnRaise_Click;
            // 
            // cbxType
            // 
            cbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "Type 1", "Type 2", "Type 3", "Type 4", "Other" });
            cbxType.Location = new Point(12, 112);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(384, 36);
            cbxType.TabIndex = 60;
            // 
            // cbxUrgency
            // 
            cbxUrgency.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUrgency.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbxUrgency.FormattingEnabled = true;
            cbxUrgency.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cbxUrgency.Location = new Point(459, 111);
            cbxUrgency.Name = "cbxUrgency";
            cbxUrgency.Size = new Size(354, 36);
            cbxUrgency.TabIndex = 59;
            // 
            // lblUrgency
            // 
            lblUrgency.AutoSize = true;
            lblUrgency.Location = new Point(458, 78);
            lblUrgency.Name = "lblUrgency";
            lblUrgency.Size = new Size(355, 28);
            lblUrgency.TabIndex = 58;
            lblUrgency.Text = "Select the urgency level of problem:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(11, 77);
            lblType.Name = "lblType";
            lblType.Size = new Size(384, 28);
            lblType.TabIndex = 57;
            lblType.Text = "Select the most accurate problem type:";
            // 
            // txtProblemDescribe
            // 
            txtProblemDescribe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtProblemDescribe.Location = new Point(28, 181);
            txtProblemDescribe.MaxLength = 500;
            txtProblemDescribe.Multiline = true;
            txtProblemDescribe.Name = "txtProblemDescribe";
            txtProblemDescribe.PlaceholderText = "Enter a description of your problem here in 500 characters or less.";
            txtProblemDescribe.Size = new Size(998, 241);
            txtProblemDescribe.TabIndex = 56;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.Location = new Point(13, 169);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1028, 262);
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 0, 0);
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(1067, 335);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(161, 40);
            btnClear.TabIndex = 54;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 40);
            label1.Name = "label1";
            label1.Size = new Size(790, 27);
            label1.TabIndex = 52;
            label1.Text = "Please use the allocated space below to indicate information about your problem.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(7, 4);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 51;
            label2.Text = "New Ticket Entry";
            // 
            // tabReopenTicket
            // 
            tabReopenTicket.BackColor = Color.LightGray;
            tabReopenTicket.Controls.Add(txtID);
            tabReopenTicket.Controls.Add(lblTicketID);
            tabReopenTicket.Controls.Add(cbxReopenReason);
            tabReopenTicket.Controls.Add(lblReopenReason);
            tabReopenTicket.Controls.Add(btnReopenTicket);
            tabReopenTicket.Controls.Add(btnReopenClear);
            tabReopenTicket.Controls.Add(txtReopenTicket);
            tabReopenTicket.Controls.Add(pictureBox6);
            tabReopenTicket.Controls.Add(label4);
            tabReopenTicket.Controls.Add(label3);
            tabReopenTicket.Location = new Point(4, 37);
            tabReopenTicket.Name = "tabReopenTicket";
            tabReopenTicket.Padding = new Padding(3);
            tabReopenTicket.Size = new Size(1281, 455);
            tabReopenTicket.TabIndex = 1;
            tabReopenTicket.Text = "Re-open Tickets";
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.None;
            txtID.Location = new Point(718, 126);
            txtID.Margin = new Padding(4);
            txtID.Name = "txtID";
            txtID.Size = new Size(417, 34);
            txtID.TabIndex = 67;
            // 
            // lblTicketID
            // 
            lblTicketID.AutoSize = true;
            lblTicketID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTicketID.Location = new Point(718, 98);
            lblTicketID.Name = "lblTicketID";
            lblTicketID.Size = new Size(407, 25);
            lblTicketID.TabIndex = 66;
            lblTicketID.Text = "Enter the ID of the ticket you want to re-open:";
            // 
            // cbxReopenReason
            // 
            cbxReopenReason.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxReopenReason.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbxReopenReason.FormattingEnabled = true;
            cbxReopenReason.Items.AddRange(new object[] { "Reason 1", "Reason 2", "Reason 3", "Reason 4", "Reason 5", "None of the above" });
            cbxReopenReason.Location = new Point(10, 126);
            cbxReopenReason.Name = "cbxReopenReason";
            cbxReopenReason.Size = new Size(652, 36);
            cbxReopenReason.TabIndex = 64;
            // 
            // lblReopenReason
            // 
            lblReopenReason.AutoSize = true;
            lblReopenReason.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblReopenReason.Location = new Point(8, 98);
            lblReopenReason.Name = "lblReopenReason";
            lblReopenReason.Size = new Size(654, 25);
            lblReopenReason.TabIndex = 63;
            lblReopenReason.Text = "Select the most accurate description of why you are re-opening your ticket:";
            // 
            // btnReopenTicket
            // 
            btnReopenTicket.BackColor = Color.FromArgb(64, 0, 0);
            btnReopenTicket.FlatStyle = FlatStyle.Popup;
            btnReopenTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReopenTicket.ForeColor = Color.White;
            btnReopenTicket.Location = new Point(1097, 394);
            btnReopenTicket.Name = "btnReopenTicket";
            btnReopenTicket.Size = new Size(157, 40);
            btnReopenTicket.TabIndex = 62;
            btnReopenTicket.Text = "Re-open Ticket";
            btnReopenTicket.UseVisualStyleBackColor = false;
            // 
            // btnReopenClear
            // 
            btnReopenClear.BackColor = Color.FromArgb(64, 0, 0);
            btnReopenClear.FlatStyle = FlatStyle.Popup;
            btnReopenClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReopenClear.ForeColor = Color.White;
            btnReopenClear.Location = new Point(1097, 345);
            btnReopenClear.Name = "btnReopenClear";
            btnReopenClear.Size = new Size(156, 36);
            btnReopenClear.TabIndex = 58;
            btnReopenClear.Text = "Clear";
            btnReopenClear.UseVisualStyleBackColor = false;
            btnReopenClear.Click += btnReopenClear_Click;
            // 
            // txtReopenTicket
            // 
            txtReopenTicket.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtReopenTicket.Location = new Point(26, 198);
            txtReopenTicket.MaxLength = 500;
            txtReopenTicket.Multiline = true;
            txtReopenTicket.Name = "txtReopenTicket";
            txtReopenTicket.PlaceholderText = "Please explain why you are re-raising your ticket in 500 characters or less.";
            txtReopenTicket.Size = new Size(1037, 227);
            txtReopenTicket.TabIndex = 57;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.BackColor = Color.Gray;
            pictureBox6.Location = new Point(13, 184);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1063, 254);
            pictureBox6.TabIndex = 56;
            pictureBox6.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(2, 36);
            label4.Name = "label4";
            label4.Size = new Size(1232, 48);
            label4.TabIndex = 53;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(3, 4);
            label3.Name = "label3";
            label3.Size = new Size(206, 32);
            label3.TabIndex = 52;
            label3.Text = "Re-Raise a Ticket";
            // 
            // lblTicket
            // 
            lblTicket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTicket.AutoSize = true;
            lblTicket.BackColor = Color.FromArgb(64, 0, 0);
            lblTicket.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTicket.ForeColor = Color.White;
            lblTicket.Location = new Point(476, 8);
            lblTicket.Margin = new Padding(2, 0, 2, 0);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(340, 47);
            lblTicket.TabIndex = 45;
            lblTicket.Text = "Ticket Dashboard";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox3.Location = new Point(0, -1);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1283, 66);
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // pnlProblemList
            // 
            pnlProblemList.Controls.Add(lblProblem);
            pnlProblemList.Controls.Add(pictureBox4);
            pnlProblemList.Location = new Point(-4, 89);
            pnlProblemList.Margin = new Padding(2);
            pnlProblemList.Name = "pnlProblemList";
            pnlProblemList.Size = new Size(1268, 552);
            pnlProblemList.TabIndex = 45;
            // 
            // lblProblem
            // 
            lblProblem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProblem.AutoSize = true;
            lblProblem.BackColor = Color.FromArgb(64, 0, 0);
            lblProblem.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblProblem.ForeColor = Color.White;
            lblProblem.Location = new Point(376, 6);
            lblProblem.Margin = new Padding(2, 0, 2, 0);
            lblProblem.Name = "lblProblem";
            lblProblem.Size = new Size(529, 47);
            lblProblem.TabIndex = 45;
            lblProblem.Text = "Frequently Asked Questions";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox4.Location = new Point(2, -2);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1266, 69);
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // lblOnlineHelp
            // 
            lblOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblOnlineHelp.AutoSize = true;
            lblOnlineHelp.BackColor = Color.FromArgb(64, 0, 0);
            lblOnlineHelp.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOnlineHelp.ForeColor = Color.White;
            lblOnlineHelp.Location = new Point(530, 97);
            lblOnlineHelp.Margin = new Padding(2, 0, 2, 0);
            lblOnlineHelp.Name = "lblOnlineHelp";
            lblOnlineHelp.Size = new Size(235, 47);
            lblOnlineHelp.TabIndex = 47;
            lblOnlineHelp.Text = "Online Help";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox5.Location = new Point(-1, 92);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1264, 59);
            pictureBox5.TabIndex = 46;
            pictureBox5.TabStop = false;
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
            lblHeader.TabIndex = 48;
            lblHeader.Text = "Red Agents IT Help Desk";
            // 
            // lblLoggedIn
            // 
            lblLoggedIn.AutoSize = true;
            lblLoggedIn.BackColor = Color.Black;
            lblLoggedIn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoggedIn.ForeColor = Color.White;
            lblLoggedIn.Location = new Point(913, 50);
            lblLoggedIn.Name = "lblLoggedIn";
            lblLoggedIn.Size = new Size(171, 28);
            lblLoggedIn.TabIndex = 4;
            lblLoggedIn.Text = "Logged in as: User";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Black;
            pictureBox7.BackgroundImage = Properties.Resources.Profile_Picture;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(1202, 46);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(47, 35);
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Gray;
            pictureBox8.Location = new Point(18, 86);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(1180, 105);
            pictureBox8.TabIndex = 57;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Gray;
            pictureBox9.Location = new Point(18, 207);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(1180, 105);
            pictureBox9.TabIndex = 58;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Gray;
            pictureBox10.Location = new Point(17, 328);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(1180, 105);
            pictureBox10.TabIndex = 59;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.White;
            pictureBox11.Location = new Point(27, 101);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(1160, 75);
            pictureBox11.TabIndex = 62;
            pictureBox11.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(197, 114);
            label7.Name = "label7";
            label7.Size = new Size(985, 48);
            label7.TabIndex = 63;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(41, 116);
            label6.Name = "label6";
            label6.Size = new Size(156, 38);
            label6.TabIndex = 64;
            label6.Text = "My Tickets";
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.White;
            pictureBox12.Location = new Point(28, 223);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(1160, 75);
            pictureBox12.TabIndex = 65;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.White;
            pictureBox13.Location = new Point(26, 343);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(1160, 75);
            pictureBox13.TabIndex = 66;
            pictureBox13.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(37, 240);
            label8.Name = "label8";
            label8.Size = new Size(188, 38);
            label8.TabIndex = 67;
            label8.Text = "Raise Tickets";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft YaHei UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(229, 231);
            label9.Name = "label9";
            label9.Size = new Size(933, 60);
            label9.TabIndex = 68;
            label9.Text = resources.GetString("label9.Text");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(33, 359);
            label10.Name = "label10";
            label10.Size = new Size(226, 38);
            label10.TabIndex = 69;
            label10.Text = "Re-open Tickets";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(265, 344);
            label11.Name = "label11";
            label11.Size = new Size(911, 72);
            label11.TabIndex = 70;
            label11.Text = resources.GetString("label11.Text");
            // 
            // frmProjectMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 641);
            Controls.Add(pictureBox7);
            Controls.Add(lblLoggedIn);
            Controls.Add(pnlTickets);
            Controls.Add(lblHeader);
            Controls.Add(pictureLogo);
            Controls.Add(pnlProblemList);
            Controls.Add(lblOnlineHelp);
            Controls.Add(pictureBox5);
            Controls.Add(btnOnlineHelp);
            Controls.Add(btnProblemList);
            Controls.Add(btnTickets);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Controls.Add(Rectangle1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmProjectMember";
            Text = "IT Help Desk Project Member Ticket Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            pnlTickets.ResumeLayout(false);
            pnlTickets.PerformLayout();
            tabProjectMem.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            tabMyTickets.ResumeLayout(false);
            tabMyTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabRaiseTicket.ResumeLayout(false);
            tabRaiseTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabReopenTicket.ResumeLayout(false);
            tabReopenTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlProblemList.ResumeLayout(false);
            pnlProblemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnSearch;
        private TextBox txtAdminHome;
        private Button btnGenerate;
        private Button btnRegistration;
        private Button btnAccount;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox Rectangle1;
        private Button btnTickets;
        private Button btnProblemList;
        private Button btnOnlineHelp;
        private Panel pnlTickets;
        private Panel pnlProblemList;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label lblTicket;
        private Label lblProblem;
        private TabControl tabProjectMem;
        private TabPage tabRaiseTicket;
        private Label label1;
        private Label label2;
        private TabPage tabReopenTicket;
        private Label lblOnlineHelp;
        private PictureBox pictureBox5;
        private TextBox txtProblemDescribe;
        private PictureBox pictureBox2;
        private Button btnClear;
        private ComboBox cbxType;
        private ComboBox cbxUrgency;
        private Label lblUrgency;
        private Label lblType;
        private Label lblHeader;
        private Button btnRaise;
        private Label label4;
        private Label label3;
        private TextBox txtReopenTicket;
        private PictureBox pictureBox6;
        private Button btnReopenTicket;
        private Button btnReopenClear;
        private ComboBox cbxReopenReason;
        private Label lblReopenReason;
        private Label lblTicketID;
        private TextBox txtID;
        private TabPage tabMyTickets;
        private Label label5;
        private DataGridView dataGridView1;
        private TabPage tabHome;
        private Label lblWelcomeMessage;
        private Label lblDescribeHome;
        private Label lblUser;
        private Label lblLoggedIn;
        private PictureBox pictureBox7;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label11;
    }
}