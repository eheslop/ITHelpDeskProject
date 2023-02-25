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
            Rectangle1 = new PictureBox();
            btnTickets = new Button();
            btnProblemList = new Button();
            btnOnlineHelp = new Button();
            pictureBox2 = new PictureBox();
            pnlOnlineHelp = new Panel();
            lblOnline = new Label();
            pictureBox3 = new PictureBox();
            pnlProblemList = new Panel();
            lblProblem = new Label();
            pictureBox4 = new PictureBox();
            pnlTickets = new Panel();
            lblTicketDash = new Label();
            pictureBox5 = new PictureBox();
            lblHomeProject = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlOnlineHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlProblemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            btnHomeMember.Location = new Point(738, 60);
            btnHomeMember.Margin = new Padding(4);
            btnHomeMember.Name = "btnHomeMember";
            btnHomeMember.Size = new Size(75, 34);
            btnHomeMember.TabIndex = 32;
            btnHomeMember.Text = "Home";
            btnHomeMember.UseVisualStyleBackColor = false;
            btnHomeMember.Click += btnHomeMember_Click;
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
            // Rectangle1
            // 
            Rectangle1.BackColor = Color.Black;
            Rectangle1.Location = new Point(-7, 23);
            Rectangle1.Margin = new Padding(2);
            Rectangle1.Name = "Rectangle1";
            Rectangle1.Size = new Size(1179, 84);
            Rectangle1.TabIndex = 24;
            Rectangle1.TabStop = false;
            // 
            // btnTickets
            // 
            btnTickets.BackColor = Color.Black;
            btnTickets.FlatStyle = FlatStyle.Popup;
            btnTickets.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTickets.ForeColor = Color.White;
            btnTickets.Location = new Point(1068, 58);
            btnTickets.Margin = new Padding(2);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(89, 40);
            btnTickets.TabIndex = 36;
            btnTickets.Text = "Tickets";
            btnTickets.UseVisualStyleBackColor = false;
            btnTickets.Click += btnTickets_Click;
            // 
            // btnProblemList
            // 
            btnProblemList.BackColor = Color.Black;
            btnProblemList.FlatStyle = FlatStyle.Popup;
            btnProblemList.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnProblemList.ForeColor = Color.White;
            btnProblemList.Location = new Point(933, 58);
            btnProblemList.Margin = new Padding(2);
            btnProblemList.Name = "btnProblemList";
            btnProblemList.Size = new Size(142, 40);
            btnProblemList.TabIndex = 37;
            btnProblemList.Text = "Problem List";
            btnProblemList.UseVisualStyleBackColor = false;
            btnProblemList.Click += btnProblemList_Click;
            // 
            // btnOnlineHelp
            // 
            btnOnlineHelp.BackColor = Color.Black;
            btnOnlineHelp.FlatStyle = FlatStyle.Popup;
            btnOnlineHelp.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOnlineHelp.ForeColor = Color.White;
            btnOnlineHelp.Location = new Point(810, 60);
            btnOnlineHelp.Margin = new Padding(4);
            btnOnlineHelp.Name = "btnOnlineHelp";
            btnOnlineHelp.Size = new Size(132, 34);
            btnOnlineHelp.TabIndex = 38;
            btnOnlineHelp.Text = "Online Help";
            btnOnlineHelp.UseVisualStyleBackColor = false;
            btnOnlineHelp.Click += btnOnlineHelp_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox2.Location = new Point(-7, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1179, 123);
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // pnlOnlineHelp
            // 
            pnlOnlineHelp.Controls.Add(lblOnline);
            pnlOnlineHelp.Controls.Add(pictureBox3);
            pnlOnlineHelp.Location = new Point(-1, 102);
            pnlOnlineHelp.Name = "pnlOnlineHelp";
            pnlOnlineHelp.Size = new Size(1173, 543);
            pnlOnlineHelp.TabIndex = 45;
            // 
            // lblOnline
            // 
            lblOnline.AutoSize = true;
            lblOnline.BackColor = Color.FromArgb(64, 0, 0);
            lblOnline.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOnline.ForeColor = Color.White;
            lblOnline.Location = new Point(463, 19);
            lblOnline.Name = "lblOnline";
            lblOnline.Size = new Size(235, 47);
            lblOnline.TabIndex = 45;
            lblOnline.Text = "Online Help";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox3.Location = new Point(0, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1179, 123);
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // pnlProblemList
            // 
            pnlProblemList.Controls.Add(lblProblem);
            pnlProblemList.Controls.Add(pictureBox4);
            pnlProblemList.Location = new Point(-4, 103);
            pnlProblemList.Name = "pnlProblemList";
            pnlProblemList.Size = new Size(1176, 542);
            pnlProblemList.TabIndex = 45;
            // 
            // lblProblem
            // 
            lblProblem.AutoSize = true;
            lblProblem.BackColor = Color.FromArgb(64, 0, 0);
            lblProblem.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblProblem.ForeColor = Color.White;
            lblProblem.Location = new Point(326, 25);
            lblProblem.Name = "lblProblem";
            lblProblem.Size = new Size(529, 47);
            lblProblem.TabIndex = 45;
            lblProblem.Text = "Frequently Asked Questions";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox4.Location = new Point(-6, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1179, 123);
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // pnlTickets
            // 
            pnlTickets.Controls.Add(lblTicketDash);
            pnlTickets.Controls.Add(pictureBox5);
            pnlTickets.Location = new Point(-7, 102);
            pnlTickets.Name = "pnlTickets";
            pnlTickets.Size = new Size(1179, 543);
            pnlTickets.TabIndex = 45;
            // 
            // lblTicketDash
            // 
            lblTicketDash.AutoSize = true;
            lblTicketDash.BackColor = Color.FromArgb(64, 0, 0);
            lblTicketDash.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTicketDash.ForeColor = Color.White;
            lblTicketDash.Location = new Point(438, 20);
            lblTicketDash.Name = "lblTicketDash";
            lblTicketDash.Size = new Size(340, 47);
            lblTicketDash.TabIndex = 45;
            lblTicketDash.Text = "Ticket Dashboard";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox5.Location = new Point(0, -5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1179, 123);
            pictureBox5.TabIndex = 44;
            pictureBox5.TabStop = false;
            // 
            // lblHomeProject
            // 
            lblHomeProject.AutoSize = true;
            lblHomeProject.BackColor = Color.FromArgb(64, 0, 0);
            lblHomeProject.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHomeProject.ForeColor = Color.White;
            lblHomeProject.Location = new Point(246, 126);
            lblHomeProject.Name = "lblHomeProject";
            lblHomeProject.Size = new Size(638, 47);
            lblHomeProject.TabIndex = 46;
            lblHomeProject.Text = "Welcome Home, Project Member!";
            // 
            // frmProjectMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 641);
            Controls.Add(pnlOnlineHelp);
            Controls.Add(pnlProblemList);
            Controls.Add(pnlTickets);
            Controls.Add(btnOnlineHelp);
            Controls.Add(btnProblemList);
            Controls.Add(btnTickets);
            Controls.Add(lblHomeProject);
            Controls.Add(pictureLogo);
            Controls.Add(btnHomeMember);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Rectangle1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProjectMember";
            Text = "IT Help Desk Project Member Homepage";
            Load += frmProjectMember_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlOnlineHelp.ResumeLayout(false);
            pnlOnlineHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlProblemList.ResumeLayout(false);
            pnlProblemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlTickets.ResumeLayout(false);
            pnlTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox Rectangle1;
        private Button btnTickets;
        private Button btnProblemList;
        private Button btnOnlineHelp;
        private PictureBox pictureBox2;
        private Panel pnlOnlineHelp;
        private Panel pnlProblemList;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel pnlTickets;
        private PictureBox pictureBox5;
        private Label lblOnline;
        private Label lblProblem;
        private Label lblTicketDash;
        private Label lblHomeProject;
    }
}