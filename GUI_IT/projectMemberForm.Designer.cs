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
            pnlTickets = new Panel();
            btnRaiseTicket = new Button();
            lblDescription = new Label();
            lblNewEntry = new Label();
            textBox1 = new TextBox();
            lblTicket = new Label();
            pictureBox3 = new PictureBox();
            pnlProblemList = new Panel();
            lblProblem = new Label();
            pictureBox4 = new PictureBox();
            pnlOnlineHelp = new Panel();
            lblOnlineHelp = new Label();
            pictureBox5 = new PictureBox();
            lblHomeProject = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlProblemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlOnlineHelp.SuspendLayout();
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
            btnHomeMember.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHomeMember.BackColor = Color.Black;
            btnHomeMember.FlatStyle = FlatStyle.Popup;
            btnHomeMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHomeMember.ForeColor = Color.White;
            btnHomeMember.Location = new Point(716, 48);
            btnHomeMember.Margin = new Padding(4);
            btnHomeMember.Name = "btnHomeMember";
            btnHomeMember.Size = new Size(95, 59);
            btnHomeMember.TabIndex = 32;
            btnHomeMember.Text = "Home";
            btnHomeMember.UseVisualStyleBackColor = false;
            btnHomeMember.Click += btnHomeMember_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(64, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1052, -2);
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
            pictureBox1.Size = new Size(1179, 41);
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
            Rectangle1.Size = new Size(1179, 84);
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
            btnTickets.Location = new Point(1068, 48);
            btnTickets.Margin = new Padding(2);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(89, 57);
            btnTickets.TabIndex = 36;
            btnTickets.Text = "Tickets";
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
            btnProblemList.Location = new Point(927, 46);
            btnProblemList.Margin = new Padding(2);
            btnProblemList.Name = "btnProblemList";
            btnProblemList.Size = new Size(148, 61);
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
            btnOnlineHelp.Location = new Point(797, 46);
            btnOnlineHelp.Margin = new Padding(4);
            btnOnlineHelp.Name = "btnOnlineHelp";
            btnOnlineHelp.Size = new Size(139, 61);
            btnOnlineHelp.TabIndex = 38;
            btnOnlineHelp.Text = "Online Help";
            btnOnlineHelp.UseVisualStyleBackColor = false;
            btnOnlineHelp.Click += btnOnlineHelp_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox2.Location = new Point(-8, 106);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1179, 122);
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // pnlTickets
            // 
            pnlTickets.Controls.Add(btnRaiseTicket);
            pnlTickets.Controls.Add(lblDescription);
            pnlTickets.Controls.Add(lblNewEntry);
            pnlTickets.Controls.Add(textBox1);
            pnlTickets.Controls.Add(lblTicket);
            pnlTickets.Controls.Add(pictureBox3);
            pnlTickets.Location = new Point(-1, 101);
            pnlTickets.Margin = new Padding(2);
            pnlTickets.Name = "pnlTickets";
            pnlTickets.Size = new Size(1172, 544);
            pnlTickets.TabIndex = 45;
            pnlTickets.Paint += pnlOnlineHelp_Paint;
            // 
            // btnRaiseTicket
            // 
            btnRaiseTicket.BackColor = Color.FromArgb(64, 0, 0);
            btnRaiseTicket.FlatStyle = FlatStyle.Popup;
            btnRaiseTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaiseTicket.ForeColor = Color.White;
            btnRaiseTicket.Location = new Point(991, 445);
            btnRaiseTicket.Name = "btnRaiseTicket";
            btnRaiseTicket.Size = new Size(135, 34);
            btnRaiseTicket.TabIndex = 49;
            btnRaiseTicket.Text = "Raise Ticket";
            btnRaiseTicket.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(5, 123);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1065, 108);
            lblDescription.TabIndex = 48;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // lblNewEntry
            // 
            lblNewEntry.AutoSize = true;
            lblNewEntry.BackColor = Color.Transparent;
            lblNewEntry.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNewEntry.Location = new Point(3, 75);
            lblNewEntry.Name = "lblNewEntry";
            lblNewEntry.Size = new Size(307, 48);
            lblNewEntry.TabIndex = 47;
            lblNewEntry.Text = "New Ticket Entry";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 234);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter a description of your problem here.";
            textBox1.Size = new Size(1113, 205);
            textBox1.TabIndex = 46;
            // 
            // lblTicket
            // 
            lblTicket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTicket.AutoSize = true;
            lblTicket.BackColor = Color.FromArgb(64, 0, 0);
            lblTicket.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTicket.ForeColor = Color.White;
            lblTicket.Location = new Point(433, 10);
            lblTicket.Margin = new Padding(2, 0, 2, 0);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(292, 47);
            lblTicket.TabIndex = 45;
            lblTicket.Text = "Raising Tickets";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox3.Location = new Point(0, -1);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1172, 73);
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // pnlProblemList
            // 
            pnlProblemList.Controls.Add(lblProblem);
            pnlProblemList.Controls.Add(pictureBox4);
            pnlProblemList.Location = new Point(-4, 101);
            pnlProblemList.Margin = new Padding(2);
            pnlProblemList.Name = "pnlProblemList";
            pnlProblemList.Size = new Size(1176, 544);
            pnlProblemList.TabIndex = 45;
            // 
            // lblProblem
            // 
            lblProblem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProblem.AutoSize = true;
            lblProblem.BackColor = Color.FromArgb(64, 0, 0);
            lblProblem.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblProblem.ForeColor = Color.White;
            lblProblem.Location = new Point(326, 25);
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
            pictureBox4.Location = new Point(2, 0);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1174, 122);
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // pnlOnlineHelp
            // 
            pnlOnlineHelp.Controls.Add(lblOnlineHelp);
            pnlOnlineHelp.Controls.Add(pictureBox5);
            pnlOnlineHelp.Location = new Point(1, 106);
            pnlOnlineHelp.Margin = new Padding(2);
            pnlOnlineHelp.Name = "pnlOnlineHelp";
            pnlOnlineHelp.Size = new Size(1171, 539);
            pnlOnlineHelp.TabIndex = 45;
            // 
            // lblOnlineHelp
            // 
            lblOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblOnlineHelp.AutoSize = true;
            lblOnlineHelp.BackColor = Color.FromArgb(64, 0, 0);
            lblOnlineHelp.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOnlineHelp.ForeColor = Color.White;
            lblOnlineHelp.Location = new Point(431, 20);
            lblOnlineHelp.Margin = new Padding(2, 0, 2, 0);
            lblOnlineHelp.Name = "lblOnlineHelp";
            lblOnlineHelp.Size = new Size(235, 47);
            lblOnlineHelp.TabIndex = 45;
            lblOnlineHelp.Text = "Online Help";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox5.Location = new Point(0, -5);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1171, 128);
            pictureBox5.TabIndex = 44;
            pictureBox5.TabStop = false;
            // 
            // lblHomeProject
            // 
            lblHomeProject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHomeProject.AutoSize = true;
            lblHomeProject.BackColor = Color.FromArgb(64, 0, 0);
            lblHomeProject.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHomeProject.ForeColor = Color.White;
            lblHomeProject.Location = new Point(246, 126);
            lblHomeProject.Margin = new Padding(2, 0, 2, 0);
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
            Controls.Add(pnlTickets);
            Controls.Add(pnlProblemList);
            Controls.Add(pnlOnlineHelp);
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
            Margin = new Padding(2);
            Name = "frmProjectMember";
            Text = "IT Help Desk Project Member Homepage";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlTickets.ResumeLayout(false);
            pnlTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlProblemList.ResumeLayout(false);
            pnlProblemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlOnlineHelp.ResumeLayout(false);
            pnlOnlineHelp.PerformLayout();
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
        private Panel pnlTickets;
        private Panel pnlProblemList;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel pnlOnlineHelp;
        private PictureBox pictureBox5;
        private Label lblTicket;
        private Label lblProblem;
        private Label lblOnlineHelp;
        private Label lblHomeProject;
        private Button btnRaiseTicket;
        private Label lblDescription;
        private Label lblNewEntry;
        private TextBox textBox1;
    }
}