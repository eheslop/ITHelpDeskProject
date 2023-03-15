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
            btnHome = new Button();
            btnGenerate = new Button();
            btnRegistration = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            Rectangle2 = new PictureBox();
            Rectangle1 = new PictureBox();
            pnlRegistration = new Panel();
            btnRefresh = new Button();
            DGVR = new DataGridView();
            lblNewReg = new Label();
            pictureBox4 = new PictureBox();
            pnlReportGenerate = new Panel();
            lblReportGen = new Label();
            pictureBox3 = new PictureBox();
            lblHome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            pnlRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlReportGenerate.SuspendLayout();
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
            pictureLogo.TabIndex = 23;
            pictureLogo.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHome.AutoSize = true;
            btnHome.BackColor = Color.Black;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(766, 54);
            btnHome.Margin = new Padding(4);
            btnHome.MaximumSize = new Size(125, 125);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 51);
            btnHome.TabIndex = 20;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.AutoSize = true;
            btnGenerate.BackColor = Color.Black;
            btnGenerate.FlatStyle = FlatStyle.Popup;
            btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(974, 51);
            btnGenerate.Margin = new Padding(2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(196, 54);
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
            btnRegistration.Location = new Point(842, 51);
            btnRegistration.Margin = new Padding(2);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(145, 54);
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
            btnLogout.Location = new Point(1048, 0);
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
            pictureBox1.Size = new Size(1175, 41);
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
            Rectangle2.Size = new Size(1175, 125);
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
            Rectangle1.Size = new Size(1175, 98);
            Rectangle1.TabIndex = 12;
            Rectangle1.TabStop = false;
            // 
            // pnlRegistration
            // 
            pnlRegistration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRegistration.Controls.Add(pnlReportGenerate);
            pnlRegistration.Controls.Add(btnRefresh);
            pnlRegistration.Controls.Add(DGVR);
            pnlRegistration.Controls.Add(lblNewReg);
            pnlRegistration.Controls.Add(pictureBox4);
            pnlRegistration.Location = new Point(-2, 106);
            pnlRegistration.Margin = new Padding(2);
            pnlRegistration.Name = "pnlRegistration";
            pnlRegistration.Size = new Size(1172, 539);
            pnlRegistration.TabIndex = 24;
            pnlRegistration.Paint += pnlRegistration_Paint;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1018, 198);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(118, 69);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += button1_Click;
            // 
            // DGVR
            // 
            DGVR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVR.Location = new Point(18, 196);
            DGVR.Margin = new Padding(4);
            DGVR.Name = "DGVR";
            DGVR.RowHeadersWidth = 51;
            DGVR.RowTemplate.Height = 29;
            DGVR.Size = new Size(972, 305);
            DGVR.TabIndex = 19;
            DGVR.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblNewReg
            // 
            lblNewReg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNewReg.AutoSize = true;
            lblNewReg.BackColor = Color.FromArgb(64, 0, 0);
            lblNewReg.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewReg.ForeColor = Color.White;
            lblNewReg.Location = new Point(388, 19);
            lblNewReg.Margin = new Padding(2, 0, 2, 0);
            lblNewReg.Name = "lblNewReg";
            lblNewReg.Size = new Size(430, 47);
            lblNewReg.TabIndex = 18;
            lblNewReg.Text = "New User Registration";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox4.Location = new Point(-2, 0);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1171, 122);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pnlReportGenerate
            // 
            pnlReportGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlReportGenerate.Controls.Add(lblReportGen);
            pnlReportGenerate.Controls.Add(pictureBox3);
            pnlReportGenerate.Location = new Point(2, 0);
            pnlReportGenerate.Margin = new Padding(2);
            pnlReportGenerate.Name = "pnlReportGenerate";
            pnlReportGenerate.Size = new Size(1167, 539);
            pnlReportGenerate.TabIndex = 15;
            pnlReportGenerate.Paint += pnlReportGenerate_Paint;
            // 
            // lblReportGen
            // 
            lblReportGen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReportGen.AutoSize = true;
            lblReportGen.BackColor = Color.FromArgb(64, 0, 0);
            lblReportGen.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblReportGen.ForeColor = Color.White;
            lblReportGen.Location = new Point(414, 36);
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
            pictureBox3.Location = new Point(-5, 0);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1169, 125);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // lblHome
            // 
            lblHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHome.AutoSize = true;
            lblHome.BackColor = Color.FromArgb(64, 0, 0);
            lblHome.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(351, 125);
            lblHome.Margin = new Padding(2, 0, 2, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(465, 47);
            lblHome.TabIndex = 16;
            lblHome.Text = "Welcome Home, Admin!";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 641);
            Controls.Add(pnlRegistration);
            Controls.Add(pictureLogo);
            Controls.Add(btnHome);
            Controls.Add(btnGenerate);
            Controls.Add(btnRegistration);
            Controls.Add(btnLogout);
            Controls.Add(lblHome);
            Controls.Add(pictureBox1);
            Controls.Add(Rectangle2);
            Controls.Add(Rectangle1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmAdmin";
            Text = "IT Help Desk Admin Homepage";
            Load += frmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            pnlRegistration.ResumeLayout(false);
            pnlRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlReportGenerate.ResumeLayout(false);
            pnlReportGenerate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnHome;
        private Button btnGenerate;
        private Button btnRegistration;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox Rectangle2;
        private PictureBox Rectangle1;
        private Panel pnlRegistration;
        private Panel pnlReportGenerate;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblNewReg;
        private Label lblReportGen;
        private Label lblHome;
        private DataGridView DGVR;
        private Button btnRefresh;
    }
}