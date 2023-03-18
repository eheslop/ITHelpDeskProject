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
            tabMonitor = new TabPage();
            DGVT = new DataGridView();
            tabAssign = new TabPage();
            lblMonitor = new Label();
            btnUnsolved = new Button();
            btnSolved = new Button();
            btnReOpened = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVT).BeginInit();
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
            label1.Location = new Point(413, 114);
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
            pictureBox2.Location = new Point(-10, 109);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1188, 58);
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMonitor);
            tabControl1.Controls.Add(tabAssign);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(-5, 164);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1183, 494);
            tabControl1.TabIndex = 50;
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
            tabMonitor.Size = new Size(1175, 453);
            tabMonitor.TabIndex = 0;
            tabMonitor.Text = "Monitor Tickets";
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
            tabAssign.Location = new Point(4, 37);
            tabAssign.Name = "tabAssign";
            tabAssign.Padding = new Padding(3);
            tabAssign.Size = new Size(1175, 453);
            tabAssign.TabIndex = 1;
            tabAssign.Text = "Assign Tickets";
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
            // btnUnsolved
            // 
            btnUnsolved.BackColor = Color.FromArgb(64, 0, 0);
            btnUnsolved.FlatStyle = FlatStyle.Popup;
            btnUnsolved.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnsolved.ForeColor = Color.White;
            btnUnsolved.Location = new Point(13, 44);
            btnUnsolved.Name = "btnUnsolved";
            btnUnsolved.Size = new Size(191, 40);
            btnUnsolved.TabIndex = 55;
            btnUnsolved.Text = "Unsolved Tickets";
            btnUnsolved.UseVisualStyleBackColor = false;
            // 
            // btnSolved
            // 
            btnSolved.BackColor = Color.FromArgb(64, 0, 0);
            btnSolved.FlatStyle = FlatStyle.Popup;
            btnSolved.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSolved.ForeColor = Color.White;
            btnSolved.Location = new Point(253, 44);
            btnSolved.Name = "btnSolved";
            btnSolved.Size = new Size(164, 40);
            btnSolved.TabIndex = 56;
            btnSolved.Text = "Solved Tickets";
            btnSolved.UseVisualStyleBackColor = false;
            // 
            // btnReOpened
            // 
            btnReOpened.BackColor = Color.FromArgb(64, 0, 0);
            btnReOpened.FlatStyle = FlatStyle.Popup;
            btnReOpened.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnReOpened.ForeColor = Color.White;
            btnReOpened.Location = new Point(468, 43);
            btnReOpened.Name = "btnReOpened";
            btnReOpened.Size = new Size(205, 40);
            btnReOpened.TabIndex = 57;
            btnReOpened.Text = "Re-Opened Tickets";
            btnReOpened.UseVisualStyleBackColor = false;
            // 
            // frmReportManage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 641);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lblHeader);
            Controls.Add(pictureLogo);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Controls.Add(Rectangle1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReportManage";
            Text = "IT Help Desk Report Manager Ticket Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabMonitor.ResumeLayout(false);
            tabMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVT).EndInit();
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
    }
}