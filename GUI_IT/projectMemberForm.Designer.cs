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
            btnHomeMember = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            Rectangle2 = new PictureBox();
            Rectangle1 = new PictureBox();
            btnAccountMember = new Button();
            btnTickets = new Button();
            btnProblemList = new Button();
            btnOnlineHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Black;
            pictureLogo.Image = Properties.Resources.redAgentsLogo;
            pictureLogo.Location = new Point(9, 45);
            pictureLogo.Margin = new Padding(2);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(62, 52);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 35;
            pictureLogo.TabStop = false;
            // 
            // btnHomeMember
            // 
            btnHomeMember.BackColor = Color.Black;
            btnHomeMember.FlatStyle = FlatStyle.Popup;
            btnHomeMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHomeMember.ForeColor = Color.White;
            btnHomeMember.Location = new Point(590, 57);
            btnHomeMember.Margin = new Padding(4);
            btnHomeMember.Name = "btnHomeMember";
            btnHomeMember.Size = new Size(86, 34);
            btnHomeMember.TabIndex = 32;
            btnHomeMember.Text = "Home";
            btnHomeMember.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(64, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1053, -2);
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
            pictureBox1.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox1.Location = new Point(-7, -2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1179, 41);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Rectangle2
            // 
            Rectangle2.BackColor = Color.FromArgb(64, 0, 0);
            Rectangle2.Location = new Point(-4, 104);
            Rectangle2.Margin = new Padding(2);
            Rectangle2.Name = "Rectangle2";
            Rectangle2.Size = new Size(1179, 188);
            Rectangle2.TabIndex = 25;
            Rectangle2.TabStop = false;
            // 
            // Rectangle1
            // 
            Rectangle1.BackColor = Color.Black;
            Rectangle1.Location = new Point(-7, 23);
            Rectangle1.Margin = new Padding(2);
            Rectangle1.Name = "Rectangle1";
            Rectangle1.Size = new Size(1179, 98);
            Rectangle1.TabIndex = 24;
            Rectangle1.TabStop = false;
            // 
            // btnAccountMember
            // 
            btnAccountMember.BackColor = Color.Black;
            btnAccountMember.FlatStyle = FlatStyle.Popup;
            btnAccountMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAccountMember.ForeColor = Color.White;
            btnAccountMember.Location = new Point(672, 53);
            btnAccountMember.Margin = new Padding(2);
            btnAccountMember.Name = "btnAccountMember";
            btnAccountMember.Size = new Size(130, 40);
            btnAccountMember.TabIndex = 28;
            btnAccountMember.Text = "My Account";
            btnAccountMember.UseVisualStyleBackColor = false;
            // 
            // btnTickets
            // 
            btnTickets.BackColor = Color.Black;
            btnTickets.FlatStyle = FlatStyle.Popup;
            btnTickets.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTickets.ForeColor = Color.White;
            btnTickets.Location = new Point(1056, 53);
            btnTickets.Margin = new Padding(2);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(119, 40);
            btnTickets.TabIndex = 36;
            btnTickets.Text = "Tickets";
            btnTickets.UseVisualStyleBackColor = false;
            // 
            // btnProblemList
            // 
            btnProblemList.BackColor = Color.Black;
            btnProblemList.FlatStyle = FlatStyle.Popup;
            btnProblemList.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnProblemList.ForeColor = Color.White;
            btnProblemList.Location = new Point(928, 54);
            btnProblemList.Margin = new Padding(2);
            btnProblemList.Name = "btnProblemList";
            btnProblemList.Size = new Size(142, 40);
            btnProblemList.TabIndex = 37;
            btnProblemList.Text = "Problem List";
            btnProblemList.UseVisualStyleBackColor = false;
            // 
            // btnOnlineHelp
            // 
            btnOnlineHelp.BackColor = Color.Black;
            btnOnlineHelp.FlatStyle = FlatStyle.Popup;
            btnOnlineHelp.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOnlineHelp.ForeColor = Color.White;
            btnOnlineHelp.Location = new Point(796, 57);
            btnOnlineHelp.Margin = new Padding(4);
            btnOnlineHelp.Name = "btnOnlineHelp";
            btnOnlineHelp.Size = new Size(142, 34);
            btnOnlineHelp.TabIndex = 38;
            btnOnlineHelp.Text = "Online Help";
            btnOnlineHelp.UseVisualStyleBackColor = false;
            // 
            // frmProjectMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 641);
            Controls.Add(btnOnlineHelp);
            Controls.Add(btnProblemList);
            Controls.Add(btnTickets);
            Controls.Add(pictureLogo);
            Controls.Add(btnHomeMember);
            Controls.Add(btnAccountMember);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Controls.Add(Rectangle2);
            Controls.Add(Rectangle1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProjectMember";
            Text = "IT Help Desk - Project Member";
            Load += frmProjectMember_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnSearch;
        private Button btnHomeMember;
        private TextBox txtAdminHome;
        private Button btnGenerate;
        private Button btnRegistration;
        private Button btnAccount;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox Rectangle2;
        private PictureBox Rectangle1;
        private Button btnAccountMember;
        private Button btnTickets;
        private Button btnProblemList;
        private Button btnOnlineHelp;
    }
}