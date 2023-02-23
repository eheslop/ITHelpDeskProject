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
            pictureLogo = new PictureBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnHome = new Button();
            txtAdminHome = new TextBox();
            btnGenerate = new Button();
            btnRegistration = new Button();
            btnAccount = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            Rectangle2 = new PictureBox();
            Rectangle1 = new PictureBox();
            pnlMyAccount = new Panel();
            pictureBox2 = new PictureBox();
            txtWelcomeAccount = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            pnlMyAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Black;
            pictureLogo.Image = Properties.Resources.redAgentsLogo;
            pictureLogo.Location = new Point(11, 47);
            pictureLogo.Margin = new Padding(2);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(62, 52);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 23;
            pictureLogo.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(781, 179);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 34);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(327, 181);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(461, 31);
            txtSearch.TabIndex = 21;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Black;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(594, 58);
            btnHome.Margin = new Padding(4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 34);
            btnHome.TabIndex = 20;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // txtAdminHome
            // 
            txtAdminHome.BackColor = Color.FromArgb(64, 0, 0);
            txtAdminHome.BorderStyle = BorderStyle.None;
            txtAdminHome.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAdminHome.ForeColor = Color.White;
            txtAdminHome.Location = new Point(405, 132);
            txtAdminHome.Margin = new Padding(2);
            txtAdminHome.Name = "txtAdminHome";
            txtAdminHome.ReadOnly = true;
            txtAdminHome.Size = new Size(347, 41);
            txtAdminHome.TabIndex = 19;
            txtAdminHome.Text = "IT Help Desk Admin";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Black;
            btnGenerate.FlatStyle = FlatStyle.Popup;
            btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(948, 58);
            btnGenerate.Margin = new Padding(2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(209, 34);
            btnGenerate.TabIndex = 18;
            btnGenerate.Text = "Report Generation";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.Black;
            btnRegistration.FlatStyle = FlatStyle.Popup;
            btnRegistration.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegistration.ForeColor = Color.White;
            btnRegistration.Location = new Point(810, 58);
            btnRegistration.Margin = new Padding(2);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(149, 38);
            btnRegistration.TabIndex = 17;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.Black;
            btnAccount.FlatStyle = FlatStyle.Popup;
            btnAccount.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.White;
            btnAccount.Location = new Point(677, 56);
            btnAccount.Margin = new Padding(2);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(142, 40);
            btnAccount.TabIndex = 16;
            btnAccount.Text = "My Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(64, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1051, 0);
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
            pictureBox1.Size = new Size(1179, 41);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Rectangle2
            // 
            Rectangle2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle2.BackColor = Color.FromArgb(64, 0, 0);
            Rectangle2.Location = new Point(-2, 106);
            Rectangle2.Margin = new Padding(2);
            Rectangle2.Name = "Rectangle2";
            Rectangle2.Size = new Size(1179, 157);
            Rectangle2.TabIndex = 13;
            Rectangle2.TabStop = false;
            // 
            // Rectangle1
            // 
            Rectangle1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle1.BackColor = Color.Black;
            Rectangle1.Location = new Point(-5, 25);
            Rectangle1.Margin = new Padding(2);
            Rectangle1.Name = "Rectangle1";
            Rectangle1.Size = new Size(1179, 98);
            Rectangle1.TabIndex = 12;
            Rectangle1.TabStop = false;
            // 
            // pnlMyAccount
            // 
            pnlMyAccount.Controls.Add(pictureBox2);
            pnlMyAccount.Controls.Add(txtWelcomeAccount);
            pnlMyAccount.Controls.Add(pictureBox3);
            pnlMyAccount.Controls.Add(pictureBox4);
            pnlMyAccount.Location = new Point(2, 106);
            pnlMyAccount.Name = "pnlMyAccount";
            pnlMyAccount.Size = new Size(1175, 545);
            pnlMyAccount.TabIndex = 24;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = Properties.Resources.Profile_Picture;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(29, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(325, 258);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // txtWelcomeAccount
            // 
            txtWelcomeAccount.BackColor = Color.FromArgb(64, 0, 0);
            txtWelcomeAccount.BorderStyle = BorderStyle.None;
            txtWelcomeAccount.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtWelcomeAccount.ForeColor = Color.White;
            txtWelcomeAccount.Location = new Point(506, 35);
            txtWelcomeAccount.Margin = new Padding(4);
            txtWelcomeAccount.Name = "txtWelcomeAccount";
            txtWelcomeAccount.ReadOnly = true;
            txtWelcomeAccount.Size = new Size(559, 46);
            txtWelcomeAccount.TabIndex = 20;
            txtWelcomeAccount.Text = "Welcome to Your Account!";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(373, 571);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1175, 166);
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 641);
            Controls.Add(pnlMyAccount);
            Controls.Add(pictureLogo);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnHome);
            Controls.Add(txtAdminHome);
            Controls.Add(btnGenerate);
            Controls.Add(btnRegistration);
            Controls.Add(btnAccount);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Controls.Add(Rectangle2);
            Controls.Add(Rectangle1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdmin";
            Text = "IT Help Desk - Admin";
            Load += frmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            pnlMyAccount.ResumeLayout(false);
            pnlMyAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnHome;
        private TextBox txtAdminHome;
        private Button btnGenerate;
        private Button btnRegistration;
        private Button btnAccount;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox Rectangle2;
        private PictureBox Rectangle1;
        private Panel pnlMyAccount;
        private PictureBox pictureBox2;
        private TextBox txtWelcomeAccount;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}