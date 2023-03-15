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
            btnHomeReport = new Button();
            btnTicketDash = new Button();
            btnLogout = new Button();
            lblHome = new Label();
            pictureBox1 = new PictureBox();
            Rectangle2 = new PictureBox();
            Rectangle1 = new PictureBox();
            pnlTicketDashReportMan = new Panel();
            lblTicketDash = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            pnlTicketDashReportMan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Black;
            pictureLogo.Image = Properties.Resources.redAgentsLogo;
            pictureLogo.Location = new Point(11, 48);
            pictureLogo.Margin = new Padding(2);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(62, 52);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 40;
            pictureLogo.TabStop = false;
            // 
            // btnHomeReport
            // 
            btnHomeReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHomeReport.AutoSize = true;
            btnHomeReport.BackColor = Color.Black;
            btnHomeReport.FlatStyle = FlatStyle.Popup;
            btnHomeReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHomeReport.ForeColor = Color.White;
            btnHomeReport.Location = new Point(896, 53);
            btnHomeReport.Margin = new Padding(4);
            btnHomeReport.MaximumSize = new Size(125, 125);
            btnHomeReport.Name = "btnHomeReport";
            btnHomeReport.Size = new Size(86, 51);
            btnHomeReport.TabIndex = 39;
            btnHomeReport.Text = "Home";
            btnHomeReport.UseVisualStyleBackColor = false;
            btnHomeReport.Click += btnHomeReport_Click;
            // 
            // btnTicketDash
            // 
            btnTicketDash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTicketDash.AutoSize = true;
            btnTicketDash.BackColor = Color.Black;
            btnTicketDash.FlatStyle = FlatStyle.Popup;
            btnTicketDash.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTicketDash.ForeColor = Color.White;
            btnTicketDash.Location = new Point(979, 51);
            btnTicketDash.Margin = new Padding(2);
            btnTicketDash.Name = "btnTicketDash";
            btnTicketDash.Size = new Size(188, 54);
            btnTicketDash.TabIndex = 38;
            btnTicketDash.Text = "Ticket Dashboard";
            btnTicketDash.UseVisualStyleBackColor = false;
            btnTicketDash.Click += btnTicketDash_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.AutoSize = true;
            btnLogout.BackColor = Color.FromArgb(64, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1048, 0);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(119, 41);
            btnLogout.TabIndex = 36;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblHome
            // 
            lblHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHome.AutoSize = true;
            lblHome.BackColor = Color.FromArgb(64, 0, 0);
            lblHome.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(253, 135);
            lblHome.Margin = new Padding(2, 0, 2, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(642, 47);
            lblHome.TabIndex = 37;
            lblHome.Text = "Welcome Home, Report Manager!";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox1.Location = new Point(-5, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1175, 41);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // Rectangle2
            // 
            Rectangle2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle2.BackColor = Color.FromArgb(64, 0, 0);
            Rectangle2.Location = new Point(-2, 106);
            Rectangle2.Margin = new Padding(2);
            Rectangle2.Name = "Rectangle2";
            Rectangle2.Size = new Size(1175, 125);
            Rectangle2.TabIndex = 34;
            Rectangle2.TabStop = false;
            // 
            // Rectangle1
            // 
            Rectangle1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle1.BackColor = Color.Black;
            Rectangle1.Location = new Point(-5, 25);
            Rectangle1.Margin = new Padding(2);
            Rectangle1.Name = "Rectangle1";
            Rectangle1.Size = new Size(1175, 98);
            Rectangle1.TabIndex = 33;
            Rectangle1.TabStop = false;
            // 
            // pnlTicketDashReportMan
            // 
            pnlTicketDashReportMan.Controls.Add(lblTicketDash);
            pnlTicketDashReportMan.Controls.Add(pictureBox3);
            pnlTicketDashReportMan.Location = new Point(-5, 105);
            pnlTicketDashReportMan.Name = "pnlTicketDashReportMan";
            pnlTicketDashReportMan.Size = new Size(1188, 544);
            pnlTicketDashReportMan.TabIndex = 41;
            // 
            // lblTicketDash
            // 
            lblTicketDash.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTicketDash.AutoSize = true;
            lblTicketDash.BackColor = Color.FromArgb(64, 0, 0);
            lblTicketDash.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTicketDash.ForeColor = Color.White;
            lblTicketDash.Location = new Point(425, 11);
            lblTicketDash.Margin = new Padding(2, 0, 2, 0);
            lblTicketDash.Name = "lblTicketDash";
            lblTicketDash.Size = new Size(340, 47);
            lblTicketDash.TabIndex = 47;
            lblTicketDash.Text = "Ticket Dashboard";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1188, 73);
            pictureBox3.TabIndex = 46;
            pictureBox3.TabStop = false;
            // 
            // frmReportManage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 641);
            Controls.Add(pnlTicketDashReportMan);
            Controls.Add(pictureLogo);
            Controls.Add(btnHomeReport);
            Controls.Add(btnTicketDash);
            Controls.Add(btnLogout);
            Controls.Add(lblHome);
            Controls.Add(pictureBox1);
            Controls.Add(Rectangle2);
            Controls.Add(Rectangle1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReportManage";
            Text = "IT Help Desk Report Manager Homepage";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            pnlTicketDashReportMan.ResumeLayout(false);
            pnlTicketDashReportMan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnHomeReport;
        private Button btnTicketDash;
        private Button btnLogout;
        private Label lblHome;
        private PictureBox pictureBox1;
        private PictureBox Rectangle2;
        private PictureBox Rectangle1;
        private Panel pnlTicketDashReportMan;
        private PictureBox pictureBox3;
        private Label lblTicketDash;
    }
}