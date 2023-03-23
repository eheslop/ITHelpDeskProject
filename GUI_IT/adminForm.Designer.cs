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
            pictureBox13 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            lblUser = new Label();
            lblWelcomeMessage = new Label();
            lblDescribeHome = new Label();
            tabExisting = new TabPage();
            tabSolved = new TabPage();
            tabUnsolved = new TabPage();
            lblReportGen = new Label();
            pictureBox3 = new PictureBox();
            btnApproveDeny = new Button();
            btnClear = new Button();
            pictureBox4 = new PictureBox();
            lblLoggedIn = new Label();
            pictureBox5 = new PictureBox();
            btnrefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlReportGenerate.SuspendLayout();
            tabReportGeneration.SuspendLayout();
            tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            btnGenerate.Location = new Point(172, 38);
            btnGenerate.Margin = new Padding(2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(157, 36);
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
            btnRegistration.Location = new Point(69, 36);
            btnRegistration.Margin = new Padding(2);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(116, 39);
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
            btnLogout.Location = new Point(916, 0);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(95, 33);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1004, 33);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Rectangle1
            // 
            Rectangle1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle1.BackColor = Color.Black;
            Rectangle1.Location = new Point(-4, 20);
            Rectangle1.Margin = new Padding(2);
            Rectangle1.Name = "Rectangle1";
            Rectangle1.Size = new Size(1018, 64);
            Rectangle1.TabIndex = 12;
            Rectangle1.TabStop = false;
            // 
            // DGVR
            // 
            DGVR.AllowUserToAddRows = false;
            DGVR.AllowUserToDeleteRows = false;
            DGVR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVR.Location = new Point(21, 145);
            DGVR.Name = "DGVR";
            DGVR.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            DGVR.RowTemplate.Height = 29;
            DGVR.Size = new Size(792, 358);
            DGVR.TabIndex = 19;
            DGVR.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(64, 0, 0);
            lblHeader.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 5);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(255, 25);
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
            label1.Location = new Point(333, 81);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(355, 40);
            label1.TabIndex = 50;
            label1.Text = "New User Registration";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox2.Location = new Point(-2, 77);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1014, 51);
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // pnlReportGenerate
            // 
            pnlReportGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlReportGenerate.Controls.Add(tabReportGeneration);
            pnlReportGenerate.Controls.Add(lblReportGen);
            pnlReportGenerate.Controls.Add(pictureBox3);
            pnlReportGenerate.Location = new Point(-3, 473);
            pnlReportGenerate.Margin = new Padding(2);
            pnlReportGenerate.Name = "pnlReportGenerate";
            pnlReportGenerate.Size = new Size(1019, 39);
            pnlReportGenerate.TabIndex = 15;
            pnlReportGenerate.Paint += pnlReportGenerate_Paint;
            // 
            // tabReportGeneration
            // 
            tabReportGeneration.Controls.Add(tabHome);
            tabReportGeneration.Controls.Add(tabExisting);
            tabReportGeneration.Controls.Add(tabSolved);
            tabReportGeneration.Controls.Add(tabUnsolved);
            tabReportGeneration.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tabReportGeneration.Location = new Point(0, 416);
            tabReportGeneration.Margin = new Padding(2);
            tabReportGeneration.Name = "tabReportGeneration";
            tabReportGeneration.SelectedIndex = 0;
            tabReportGeneration.Size = new Size(1031, 32);
            tabReportGeneration.TabIndex = 18;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.LightGray;
            tabHome.Controls.Add(pictureBox13);
            tabHome.Controls.Add(pictureBox12);
            tabHome.Controls.Add(pictureBox11);
            tabHome.Controls.Add(pictureBox10);
            tabHome.Controls.Add(pictureBox9);
            tabHome.Controls.Add(pictureBox8);
            tabHome.Controls.Add(lblUser);
            tabHome.Controls.Add(lblWelcomeMessage);
            tabHome.Controls.Add(lblDescribeHome);
            tabHome.Location = new Point(4, 32);
            tabHome.Margin = new Padding(2);
            tabHome.Name = "tabHome";
            tabHome.Size = new Size(1023, 0);
            tabHome.TabIndex = 3;
            tabHome.Text = "Report Homepage";
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.White;
            pictureBox13.Location = new Point(18, 268);
            pictureBox13.Margin = new Padding(2);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(928, 60);
            pictureBox13.TabIndex = 77;
            pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.White;
            pictureBox12.Location = new Point(20, 172);
            pictureBox12.Margin = new Padding(2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(928, 60);
            pictureBox12.TabIndex = 76;
            pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.White;
            pictureBox11.Location = new Point(19, 74);
            pictureBox11.Margin = new Padding(2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(928, 60);
            pictureBox11.TabIndex = 74;
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Gray;
            pictureBox10.Location = new Point(11, 256);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(944, 84);
            pictureBox10.TabIndex = 73;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Gray;
            pictureBox9.Location = new Point(12, 159);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(944, 84);
            pictureBox9.TabIndex = 72;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Gray;
            pictureBox8.Location = new Point(12, 62);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(944, 84);
            pictureBox8.TabIndex = 71;
            pictureBox8.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(341, 6);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(61, 28);
            lblUser.TabIndex = 53;
            lblUser.Text = "User!";
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcomeMessage.Location = new Point(1, 6);
            lblWelcomeMessage.Margin = new Padding(2, 0, 2, 0);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(364, 28);
            lblWelcomeMessage.TabIndex = 70;
            lblWelcomeMessage.Text = "Welcome to your Report Homepage, ";
            // 
            // lblDescribeHome
            // 
            lblDescribeHome.AutoSize = true;
            lblDescribeHome.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescribeHome.Location = new Point(7, 32);
            lblDescribeHome.Margin = new Padding(2, 0, 2, 0);
            lblDescribeHome.Name = "lblDescribeHome";
            lblDescribeHome.Size = new Size(1005, 25);
            lblDescribeHome.TabIndex = 65;
            lblDescribeHome.Text = "Listed below are the different potential reports that can be generated, as well as a brief description of each.\r\n";
            // 
            // tabExisting
            // 
            tabExisting.BackColor = Color.LightGray;
            tabExisting.Location = new Point(4, 32);
            tabExisting.Margin = new Padding(2);
            tabExisting.Name = "tabExisting";
            tabExisting.Padding = new Padding(2);
            tabExisting.Size = new Size(1023, 0);
            tabExisting.TabIndex = 0;
            tabExisting.Text = "Existing Tickets";
            tabExisting.Click += tabExisting_Click;
            // 
            // tabSolved
            // 
            tabSolved.BackColor = Color.LightGray;
            tabSolved.Location = new Point(4, 32);
            tabSolved.Margin = new Padding(2);
            tabSolved.Name = "tabSolved";
            tabSolved.Padding = new Padding(2);
            tabSolved.Size = new Size(1023, 0);
            tabSolved.TabIndex = 1;
            tabSolved.Text = "Solved Tickets";
            // 
            // tabUnsolved
            // 
            tabUnsolved.BackColor = Color.LightGray;
            tabUnsolved.Location = new Point(4, 32);
            tabUnsolved.Margin = new Padding(2);
            tabUnsolved.Name = "tabUnsolved";
            tabUnsolved.Size = new Size(1023, 0);
            tabUnsolved.TabIndex = 2;
            tabUnsolved.Text = "Unsolved Tickets";
            // 
            // lblReportGen
            // 
            lblReportGen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReportGen.AutoSize = true;
            lblReportGen.BackColor = Color.FromArgb(64, 0, 0);
            lblReportGen.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblReportGen.ForeColor = Color.White;
            lblReportGen.Location = new Point(370, 3);
            lblReportGen.Margin = new Padding(2, 0, 2, 0);
            lblReportGen.Name = "lblReportGen";
            lblReportGen.Size = new Size(295, 40);
            lblReportGen.TabIndex = 17;
            lblReportGen.Text = "Report Generation";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox3.Location = new Point(-4, -11);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1017, 62);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // btnApproveDeny
            // 
            btnApproveDeny.BackColor = Color.FromArgb(64, 0, 0);
            btnApproveDeny.FlatStyle = FlatStyle.Popup;
            btnApproveDeny.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnApproveDeny.ForeColor = Color.White;
            btnApproveDeny.Location = new Point(840, 197);
            btnApproveDeny.Margin = new Padding(2);
            btnApproveDeny.Name = "btnApproveDeny";
            btnApproveDeny.Size = new Size(132, 43);
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
            btnClear.Location = new Point(840, 145);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 39);
            btnClear.TabIndex = 52;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Black;
            pictureBox4.Image = Properties.Resources.redAgentsLogo;
            pictureBox4.Location = new Point(7, 35);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 35);
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
            lblLoggedIn.Location = new Point(737, 42);
            lblLoggedIn.Margin = new Padding(2, 0, 2, 0);
            lblLoggedIn.Name = "lblLoggedIn";
            lblLoggedIn.Size = new Size(150, 23);
            lblLoggedIn.TabIndex = 0;
            lblLoggedIn.Text = "Logged in as: User";
            lblLoggedIn.Click += lblLoggedIn_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Black;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(962, 42);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 28);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(842, 264);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(130, 37);
            btnrefresh.TabIndex = 53;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += button1_Click_1;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 513);
            Controls.Add(btnrefresh);
            Controls.Add(pictureBox5);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private TabControl tabReportGeneration;
        private TabPage tabExisting;
        private TabPage tabSolved;
        private TabPage tabUnsolved;
        private PictureBox pictureBox4;
        private TabPage tabHome;
        private Label lblLoggedIn;
        private PictureBox pictureBox5;
        private Label lblDescribeHome;
        private Label lblWelcomeMessage;
        private Label lblUser;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Button btnrefresh;
    }
}