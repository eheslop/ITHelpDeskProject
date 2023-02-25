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
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtAdminHome = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rectangle2 = new System.Windows.Forms.PictureBox();
            this.Rectangle1 = new System.Windows.Forms.PictureBox();
            this.pnlMyAccount = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtWelcomeAccount = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle1)).BeginInit();
            this.pnlMyAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Black;
            this.pictureLogo.Image = global::GUI_IT.Properties.Resources.redAgentsLogo;
            this.pictureLogo.Location = new System.Drawing.Point(9, 38);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(50, 42);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 23;
            this.pictureLogo.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(625, 143);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 27);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(262, 145);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(370, 27);
            this.txtSearch.TabIndex = 21;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(534, 46);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(69, 27);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtAdminHome
            // 
            this.txtAdminHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAdminHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAdminHome.ForeColor = System.Drawing.Color.White;
            this.txtAdminHome.Location = new System.Drawing.Point(324, 106);
            this.txtAdminHome.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdminHome.Name = "txtAdminHome";
            this.txtAdminHome.ReadOnly = true;
            this.txtAdminHome.Size = new System.Drawing.Size(278, 34);
            this.txtAdminHome.TabIndex = 19;
            this.txtAdminHome.Text = "IT Help Desk Admin";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.Black;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(817, 46);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(167, 27);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "Report Generation";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistration.BackColor = System.Drawing.Color.Black;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistration.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.Location = new System.Drawing.Point(707, 46);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(119, 30);
            this.btnRegistration.TabIndex = 17;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccount.BackColor = System.Drawing.Color.Black;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(601, 45);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(114, 32);
            this.btnAccount.TabIndex = 16;
            this.btnAccount.Text = "My Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(900, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 33);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 33);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Rectangle2
            // 
            this.Rectangle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rectangle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rectangle2.Location = new System.Drawing.Point(-2, 85);
            this.Rectangle2.Margin = new System.Windows.Forms.Padding(2);
            this.Rectangle2.Name = "Rectangle2";
            this.Rectangle2.Size = new System.Drawing.Size(1002, 126);
            this.Rectangle2.TabIndex = 13;
            this.Rectangle2.TabStop = false;
            // 
            // Rectangle1
            // 
            this.Rectangle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rectangle1.BackColor = System.Drawing.Color.Black;
            this.Rectangle1.Location = new System.Drawing.Point(-2, 0);
            this.Rectangle1.Margin = new System.Windows.Forms.Padding(2);
            this.Rectangle1.Name = "Rectangle1";
            this.Rectangle1.Size = new System.Drawing.Size(993, 211);
            this.Rectangle1.TabIndex = 12;
            this.Rectangle1.TabStop = false;
            this.Rectangle1.Click += new System.EventHandler(this.Rectangle1_Click);
            // 
            // pnlMyAccount
            // 
            this.pnlMyAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMyAccount.Controls.Add(this.pictureBox2);
            this.pnlMyAccount.Controls.Add(this.txtWelcomeAccount);
            this.pnlMyAccount.Controls.Add(this.pictureBox3);
            this.pnlMyAccount.Controls.Add(this.pictureBox4);
            this.pnlMyAccount.Location = new System.Drawing.Point(2, 85);
            this.pnlMyAccount.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMyAccount.Name = "pnlMyAccount";
            this.pnlMyAccount.Size = new System.Drawing.Size(989, 436);
            this.pnlMyAccount.TabIndex = 24;
            this.pnlMyAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMyAccount_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::GUI_IT.Properties.Resources.Profile_Picture;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 206);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // txtWelcomeAccount
            // 
            this.txtWelcomeAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWelcomeAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtWelcomeAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWelcomeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWelcomeAccount.ForeColor = System.Drawing.Color.White;
            this.txtWelcomeAccount.Location = new System.Drawing.Point(429, 28);
            this.txtWelcomeAccount.Name = "txtWelcomeAccount";
            this.txtWelcomeAccount.ReadOnly = true;
            this.txtWelcomeAccount.Size = new System.Drawing.Size(447, 38);
            this.txtWelcomeAccount.TabIndex = 20;
            this.txtWelcomeAccount.Text = "Welcome to Your Account!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(-16, -2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(334, 435);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(989, 133);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 523);
            this.Controls.Add(this.pnlMyAccount);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtAdminHome);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Rectangle2);
            this.Controls.Add(this.Rectangle1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdmin";
            this.Text = "IT Help Desk - Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle1)).EndInit();
            this.pnlMyAccount.ResumeLayout(false);
            this.pnlMyAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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