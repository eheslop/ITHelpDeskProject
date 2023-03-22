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
            tabSolved = new TabPage();
            label2 = new Label();
            tabUnsolved = new TabPage();
            label3 = new Label();
            lblReportGen = new Label();
            pictureBox3 = new PictureBox();
            btnApproveDeny = new Button();
            btnClear = new Button();
            pictureBox4 = new PictureBox();
            lblLoggedIn = new Label();
            pictureBox5 = new PictureBox();
            label7 = new Label();
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
            tabSolved.SuspendLayout();
            tabUnsolved.SuspendLayout();
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
            pnlReportGenerate.Location = new Point(-4, 96);
            pnlReportGenerate.Margin = new Padding(2);
            pnlReportGenerate.Name = "pnlReportGenerate";
            pnlReportGenerate.Size = new Size(1274, 546);
            pnlReportGenerate.TabIndex = 15;
            pnlReportGenerate.Paint += pnlReportGenerate_Paint;
            // 
            // tabReportGeneration
            // 
            tabReportGeneration.Controls.Add(tabHome);
            tabReportGeneration.Controls.Add(tabSolved);
            tabReportGeneration.Controls.Add(tabUnsolved);
            tabReportGeneration.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tabReportGeneration.Location = new Point(0, 68);
            tabReportGeneration.Name = "tabReportGeneration";
            tabReportGeneration.SelectedIndex = 0;
            tabReportGeneration.Size = new Size(1289, 492);
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
            tabHome.Size = new Size(1281, 451);
            tabHome.TabIndex = 3;
            tabHome.Text = "Report Homepage";
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
            // tabSolved
            // 
            tabSolved.BackColor = Color.LightGray;
            tabSolved.Controls.Add(label2);
            tabSolved.Location = new Point(4, 37);
            tabSolved.Name = "tabSolved";
            tabSolved.Padding = new Padding(3);
            tabSolved.Size = new Size(1281, 451);
            tabSolved.TabIndex = 1;
            tabSolved.Text = "Solved Tickets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(0, 4);
            label2.Name = "label2";
            label2.Size = new Size(418, 32);
            label2.TabIndex = 56;
            label2.Text = "Creating a Report for Solved Tickets";
            // 
            // tabUnsolved
            // 
            tabUnsolved.BackColor = Color.LightGray;
            tabUnsolved.Controls.Add(label3);
            tabUnsolved.Location = new Point(4, 37);
            tabUnsolved.Name = "tabUnsolved";
            tabUnsolved.Size = new Size(1281, 451);
            tabUnsolved.TabIndex = 2;
            tabUnsolved.Text = "Unsolved Tickets";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(0, 5);
            label3.Name = "label3";
            label3.Size = new Size(447, 32);
            label3.TabIndex = 57;
            label3.Text = "Creating a Report for Unsolved Tickets";
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
            btnApproveDeny.Location = new Point(1050, 246);
            btnApproveDeny.Name = "btnApproveDeny";
            btnApproveDeny.Size = new Size(165, 54);
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
            btnClear.Location = new Point(1050, 181);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(165, 49);
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
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Black;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(1203, 52);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 35);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
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
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 641);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            tabSolved.ResumeLayout(false);
            tabSolved.PerformLayout();
            tabUnsolved.ResumeLayout(false);
            tabUnsolved.PerformLayout();
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
        private PictureBox pictureBox4;
        private Label lblLoggedIn;
        private PictureBox pictureBox5;
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
    }
}