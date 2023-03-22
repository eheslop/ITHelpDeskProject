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
            lblUser = new Label();
            lblWelcomeMessage = new Label();
            tabMonitor = new TabPage();
            btnReOpened = new Button();
            btnSolved = new Button();
            btnUnsolved = new Button();
            lblMonitor = new Label();
            DGVT = new DataGridView();
            tabAssign = new TabPage();
            lblAssign = new Label();
            lblLoggedIn = new Label();
            pictureBox7 = new PictureBox();
            lblDescribeHome = new Label();
            pictureBox8 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabHome.SuspendLayout();
            tabMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVT).BeginInit();
            tabAssign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Black;
            pictureLogo.Image = Properties.Resources.redAgentsLogo;
            pictureLogo.Location = new Point(7, 44);
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
            btnLogout.Click += btnLogout_Click;
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
            tabControl1.Location = new Point(-5, 146);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1287, 510);
            tabControl1.TabIndex = 50;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.LightGray;
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
            tabHome.Name = "tabHome";
            tabHome.Size = new Size(1279, 469);
            tabHome.TabIndex = 2;
            tabHome.Text = "Ticket Homepage";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(412, 7);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(73, 32);
            lblUser.TabIndex = 4;
            lblUser.Text = "User!";
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcomeMessage.Location = new Point(-1, 7);
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
            tabMonitor.Location = new Point(4, 37);
            tabMonitor.Name = "tabMonitor";
            tabMonitor.Padding = new Padding(3);
            tabMonitor.Size = new Size(1279, 469);
            tabMonitor.TabIndex = 0;
            tabMonitor.Text = "Monitor Tickets";
            // 
            // btnReOpened
            // 
            btnReOpened.BackColor = Color.FromArgb(64, 0, 0);
            btnReOpened.FlatStyle = FlatStyle.Popup;
            btnReOpened.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnReOpened.ForeColor = Color.White;
            btnReOpened.Location = new Point(553, 44);
            btnReOpened.Name = "btnReOpened";
            btnReOpened.Size = new Size(220, 40);
            btnReOpened.TabIndex = 57;
            btnReOpened.Text = "Re-Opened Tickets";
            btnReOpened.UseVisualStyleBackColor = false;
            // 
            // btnSolved
            // 
            btnSolved.BackColor = Color.FromArgb(64, 0, 0);
            btnSolved.FlatStyle = FlatStyle.Popup;
            btnSolved.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSolved.ForeColor = Color.White;
            btnSolved.Location = new Point(281, 44);
            btnSolved.Name = "btnSolved";
            btnSolved.Size = new Size(220, 40);
            btnSolved.TabIndex = 56;
            btnSolved.Text = "Solved Tickets";
            btnSolved.UseVisualStyleBackColor = false;
            // 
            // btnUnsolved
            // 
            btnUnsolved.BackColor = Color.FromArgb(64, 0, 0);
            btnUnsolved.FlatStyle = FlatStyle.Popup;
            btnUnsolved.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnsolved.ForeColor = Color.White;
            btnUnsolved.Location = new Point(13, 44);
            btnUnsolved.Name = "btnUnsolved";
            btnUnsolved.Size = new Size(220, 40);
            btnUnsolved.TabIndex = 55;
            btnUnsolved.Text = "Unsolved Tickets";
            btnUnsolved.UseVisualStyleBackColor = false;
            // 
            // lblMonitor
            // 
            lblMonitor.AutoSize = true;
            lblMonitor.BackColor = Color.Transparent;
            lblMonitor.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMonitor.Location = new Point(2, 3);
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
            DGVT.Location = new Point(13, 104);
            DGVT.Name = "DGVT";
            DGVT.ReadOnly = true;
            DGVT.RowHeadersWidth = 62;
            DGVT.RowTemplate.Height = 33;
            DGVT.Size = new Size(1144, 308);
            DGVT.TabIndex = 0;
            DGVT.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabAssign
            // 
            tabAssign.BackColor = Color.LightGray;
            tabAssign.Controls.Add(lblAssign);
            tabAssign.Location = new Point(4, 37);
            tabAssign.Name = "tabAssign";
            tabAssign.Padding = new Padding(3);
            tabAssign.Size = new Size(1279, 469);
            tabAssign.TabIndex = 1;
            tabAssign.Text = "Assign Tickets";
            // 
            // lblAssign
            // 
            lblAssign.AutoSize = true;
            lblAssign.BackColor = Color.Transparent;
            lblAssign.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAssign.Location = new Point(2, 2);
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
            lblLoggedIn.Location = new Point(920, 53);
            lblLoggedIn.Name = "lblLoggedIn";
            lblLoggedIn.Size = new Size(171, 28);
            lblLoggedIn.TabIndex = 5;
            lblLoggedIn.Text = "Logged in as: User";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Black;
            pictureBox7.BackgroundImage = Properties.Resources.Profile_Picture;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(1202, 49);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(47, 35);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // lblDescribeHome
            // 
            lblDescribeHome.AutoSize = true;
            lblDescribeHome.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescribeHome.Location = new Point(5, 44);
            lblDescribeHome.Name = "lblDescribeHome";
            lblDescribeHome.Size = new Size(1186, 27);
            lblDescribeHome.TabIndex = 5;
            lblDescribeHome.Text = "Listed below are the different functionalities offered to you via your ticket dashboard, as well as a brief description of each. \r\n";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Gray;
            pictureBox8.Location = new Point(13, 85);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(1180, 158);
            pictureBox8.TabIndex = 58;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Location = new Point(13, 271);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1180, 158);
            pictureBox3.TabIndex = 59;
            pictureBox3.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.White;
            pictureBox11.Location = new Point(21, 96);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(1160, 133);
            pictureBox11.TabIndex = 63;
            pictureBox11.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(22, 282);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1160, 133);
            pictureBox4.TabIndex = 64;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(36, 143);
            label2.Name = "label2";
            label2.Size = new Size(221, 38);
            label2.TabIndex = 65;
            label2.Text = "Monitor Tickets";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(42, 328);
            label3.Name = "label3";
            label3.Size = new Size(204, 38);
            label3.TabIndex = 66;
            label3.Text = "Assign Tickets";
            // 
            // frmReportManage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 641);
            Controls.Add(lblLoggedIn);
            Controls.Add(pictureBox7);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lblHeader);
            Controls.Add(pictureLogo);
            Controls.Add(btnLogout);
            Controls.Add(Rectangle1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReportManage";
            Text = "IT Help Desk Report Manager Ticket Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            tabMonitor.ResumeLayout(false);
            tabMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVT).EndInit();
            tabAssign.ResumeLayout(false);
            tabAssign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private PictureBox pictureBox7;
        private Label lblWelcomeMessage;
        private Label lblUser;
        private Label lblDescribeHome;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private PictureBox pictureBox4;
        private PictureBox pictureBox11;
        private Label label3;
        private Label label2;
    }
}