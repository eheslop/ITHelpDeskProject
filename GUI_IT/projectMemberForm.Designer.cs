﻿namespace GUI_IT
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
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            Rectangle1 = new PictureBox();
            btnTickets = new Button();
            btnProblemList = new Button();
            btnOnlineHelp = new Button();
            pnlTickets = new Panel();
            tabControl1 = new TabControl();
            tabRaiseTicket = new TabPage();
            cbxType = new ComboBox();
            cbxUrgency = new ComboBox();
            lblUrgency = new Label();
            lblType = new Label();
            txtProblemDescribe = new TextBox();
            pictureBox2 = new PictureBox();
            btnClear = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            tabReopenTicket = new TabPage();
            lblTicket = new Label();
            pictureBox3 = new PictureBox();
            pnlProblemList = new Panel();
            lblProblem = new Label();
            pictureBox4 = new PictureBox();
            lblOnlineHelp = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            pnlTickets.SuspendLayout();
            tabControl1.SuspendLayout();
            tabRaiseTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlProblemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            btnTickets.Location = new Point(968, 48);
            btnTickets.Margin = new Padding(2);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(189, 57);
            btnTickets.TabIndex = 36;
            btnTickets.Text = "Ticket Dashboard";
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
            btnProblemList.Location = new Point(826, 46);
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
            btnOnlineHelp.Location = new Point(697, 46);
            btnOnlineHelp.Margin = new Padding(4);
            btnOnlineHelp.Name = "btnOnlineHelp";
            btnOnlineHelp.Size = new Size(141, 61);
            btnOnlineHelp.TabIndex = 38;
            btnOnlineHelp.Text = "Online Help";
            btnOnlineHelp.UseVisualStyleBackColor = false;
            btnOnlineHelp.Click += btnOnlineHelp_Click;
            // 
            // pnlTickets
            // 
            pnlTickets.Controls.Add(tabControl1);
            pnlTickets.Controls.Add(lblTicket);
            pnlTickets.Controls.Add(pictureBox3);
            pnlTickets.Location = new Point(0, 106);
            pnlTickets.Margin = new Padding(2);
            pnlTickets.Name = "pnlTickets";
            pnlTickets.Size = new Size(1172, 541);
            pnlTickets.TabIndex = 45;
            pnlTickets.Paint += pnlOnlineHelp_Paint;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabRaiseTicket);
            tabControl1.Controls.Add(tabReopenTicket);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 74);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1172, 467);
            tabControl1.TabIndex = 50;
            // 
            // tabRaiseTicket
            // 
            tabRaiseTicket.BackColor = Color.LightGray;
            tabRaiseTicket.Controls.Add(cbxType);
            tabRaiseTicket.Controls.Add(cbxUrgency);
            tabRaiseTicket.Controls.Add(lblUrgency);
            tabRaiseTicket.Controls.Add(lblType);
            tabRaiseTicket.Controls.Add(txtProblemDescribe);
            tabRaiseTicket.Controls.Add(pictureBox2);
            tabRaiseTicket.Controls.Add(btnClear);
            tabRaiseTicket.Controls.Add(button1);
            tabRaiseTicket.Controls.Add(label1);
            tabRaiseTicket.Controls.Add(label2);
            tabRaiseTicket.Location = new Point(4, 37);
            tabRaiseTicket.Name = "tabRaiseTicket";
            tabRaiseTicket.Padding = new Padding(3);
            tabRaiseTicket.Size = new Size(1164, 426);
            tabRaiseTicket.TabIndex = 0;
            tabRaiseTicket.Text = "Raise Ticket";
            // 
            // cbxType
            // 
            cbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "Type 1", "Type 2", "Type 3", "Type 4", "Other" });
            cbxType.Location = new Point(13, 141);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(384, 36);
            cbxType.TabIndex = 60;
            // 
            // cbxUrgency
            // 
            cbxUrgency.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUrgency.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbxUrgency.FormattingEnabled = true;
            cbxUrgency.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cbxUrgency.Location = new Point(491, 141);
            cbxUrgency.Name = "cbxUrgency";
            cbxUrgency.Size = new Size(383, 36);
            cbxUrgency.TabIndex = 59;
            // 
            // lblUrgency
            // 
            lblUrgency.AutoSize = true;
            lblUrgency.Location = new Point(491, 110);
            lblUrgency.Name = "lblUrgency";
            lblUrgency.Size = new Size(381, 28);
            lblUrgency.TabIndex = 58;
            lblUrgency.Text = "Select the level of urgency of problem:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(13, 110);
            lblType.Name = "lblType";
            lblType.Size = new Size(384, 28);
            lblType.TabIndex = 57;
            lblType.Text = "Select the most accurate problem type:";
            // 
            // txtProblemDescribe
            // 
            txtProblemDescribe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtProblemDescribe.Location = new Point(25, 209);
            txtProblemDescribe.MaxLength = 250;
            txtProblemDescribe.Multiline = true;
            txtProblemDescribe.Name = "txtProblemDescribe";
            txtProblemDescribe.PlaceholderText = "Enter a description of your problem here in 250 characters or less.";
            txtProblemDescribe.Size = new Size(966, 190);
            txtProblemDescribe.TabIndex = 56;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.Location = new Point(13, 198);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(989, 210);
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 0, 0);
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(1015, 302);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 44);
            btnClear.TabIndex = 54;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1015, 361);
            button1.Name = "button1";
            button1.Size = new Size(135, 44);
            button1.TabIndex = 53;
            button1.Text = "Raise Ticket";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-2, 35);
            label1.Name = "label1";
            label1.Size = new Size(1169, 63);
            label1.TabIndex = 52;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(0, 3);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 51;
            label2.Text = "New Ticket Entry";
            // 
            // tabReopenTicket
            // 
            tabReopenTicket.BackColor = Color.LightGray;
            tabReopenTicket.Location = new Point(4, 37);
            tabReopenTicket.Name = "tabReopenTicket";
            tabReopenTicket.Padding = new Padding(3);
            tabReopenTicket.Size = new Size(1164, 423);
            tabReopenTicket.TabIndex = 1;
            tabReopenTicket.Text = "Re-open Ticket";
            // 
            // lblTicket
            // 
            lblTicket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTicket.AutoSize = true;
            lblTicket.BackColor = Color.FromArgb(64, 0, 0);
            lblTicket.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTicket.ForeColor = Color.White;
            lblTicket.Location = new Point(409, 7);
            lblTicket.Margin = new Padding(2, 0, 2, 0);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(340, 47);
            lblTicket.TabIndex = 45;
            lblTicket.Text = "Ticket Dashboard";
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
            pnlProblemList.Location = new Point(-4, 104);
            pnlProblemList.Margin = new Padding(2);
            pnlProblemList.Name = "pnlProblemList";
            pnlProblemList.Size = new Size(1176, 541);
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
            // lblOnlineHelp
            // 
            lblOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblOnlineHelp.AutoSize = true;
            lblOnlineHelp.BackColor = Color.FromArgb(64, 0, 0);
            lblOnlineHelp.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOnlineHelp.ForeColor = Color.White;
            lblOnlineHelp.Location = new Point(482, 136);
            lblOnlineHelp.Margin = new Padding(2, 0, 2, 0);
            lblOnlineHelp.Name = "lblOnlineHelp";
            lblOnlineHelp.Size = new Size(235, 47);
            lblOnlineHelp.TabIndex = 47;
            lblOnlineHelp.Text = "Online Help";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox5.Location = new Point(-1, 104);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1171, 128);
            pictureBox5.TabIndex = 46;
            pictureBox5.TabStop = false;
            // 
            // frmProjectMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 641);
            Controls.Add(pnlTickets);
            Controls.Add(pnlProblemList);
            Controls.Add(lblOnlineHelp);
            Controls.Add(pictureBox5);
            Controls.Add(btnOnlineHelp);
            Controls.Add(btnProblemList);
            Controls.Add(btnTickets);
            Controls.Add(pictureLogo);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Controls.Add(Rectangle1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmProjectMember";
            Text = "IT Help Desk Project Member Online Help";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            pnlTickets.ResumeLayout(false);
            pnlTickets.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabRaiseTicket.ResumeLayout(false);
            tabRaiseTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlProblemList.ResumeLayout(false);
            pnlProblemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnSearch;
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
        private Panel pnlTickets;
        private Panel pnlProblemList;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label lblTicket;
        private Label lblProblem;
        private TabControl tabControl1;
        private TabPage tabRaiseTicket;
        private Button button1;
        private Label label1;
        private Label label2;
        private TabPage tabReopenTicket;
        private Label lblOnlineHelp;
        private PictureBox pictureBox5;
        private TextBox txtProblemDescribe;
        private PictureBox pictureBox2;
        private Button btnClear;
        private ComboBox cbxType;
        private ComboBox cbxUrgency;
        private Label lblUrgency;
        private Label lblType;
    }
}