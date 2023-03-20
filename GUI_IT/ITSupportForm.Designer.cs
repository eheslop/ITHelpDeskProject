﻿namespace GUI_IT
{
    partial class frmITSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmITSupport));
            pictureLogo = new PictureBox();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            Rectangle1 = new PictureBox();
            lblHeader = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            tabControl1 = new TabControl();
            tabSolve = new TabPage();
            tabShare = new TabPage();
            lblSolve = new Label();
            lblShare = new Label();
            DGVS = new DataGridView();
            lblSolveTickets = new Label();
            txtSolution = new TextBox();
            pictureBox6 = new PictureBox();
            btnSolveTicket = new Button();
            btnSolveClear = new Button();
            txtSolveTicketID = new TextBox();
            lblTicketID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabSolve.SuspendLayout();
            tabShare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            pictureLogo.TabIndex = 32;
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
            btnLogout.TabIndex = 27;
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
            pictureBox1.TabIndex = 26;
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
            Rectangle1.TabIndex = 24;
            Rectangle1.TabStop = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(64, 0, 0);
            lblHeader.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 6);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(307, 29);
            lblHeader.TabIndex = 34;
            lblHeader.Text = "Red Agents IT Help Desk";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(413, 110);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 47);
            label1.TabIndex = 48;
            label1.Text = "Ticket Dashboard";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox2.Location = new Point(0, 109);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1167, 51);
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabSolve);
            tabControl1.Controls.Add(tabShare);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(-5, 160);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1185, 485);
            tabControl1.TabIndex = 49;
            // 
            // tabSolve
            // 
            tabSolve.BackColor = Color.LightGray;
            tabSolve.Controls.Add(txtSolveTicketID);
            tabSolve.Controls.Add(lblTicketID);
            tabSolve.Controls.Add(btnSolveTicket);
            tabSolve.Controls.Add(btnSolveClear);
            tabSolve.Controls.Add(txtSolution);
            tabSolve.Controls.Add(pictureBox6);
            tabSolve.Controls.Add(lblSolveTickets);
            tabSolve.Controls.Add(DGVS);
            tabSolve.Controls.Add(lblSolve);
            tabSolve.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabSolve.Location = new Point(4, 37);
            tabSolve.Name = "tabSolve";
            tabSolve.Padding = new Padding(3);
            tabSolve.Size = new Size(1177, 444);
            tabSolve.TabIndex = 0;
            tabSolve.Text = "Solve Tickets";
            // 
            // tabShare
            // 
            tabShare.BackColor = Color.LightGray;
            tabShare.Controls.Add(lblShare);
            tabShare.Location = new Point(4, 37);
            tabShare.Name = "tabShare";
            tabShare.Padding = new Padding(3);
            tabShare.Size = new Size(1177, 444);
            tabShare.TabIndex = 1;
            tabShare.Text = "Share Tickets";
            // 
            // lblSolve
            // 
            lblSolve.AutoSize = true;
            lblSolve.BackColor = Color.Transparent;
            lblSolve.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSolve.Location = new Point(2, 2);
            lblSolve.Name = "lblSolve";
            lblSolve.Size = new Size(159, 32);
            lblSolve.TabIndex = 55;
            lblSolve.Text = "Solve Tickets";
            // 
            // lblShare
            // 
            lblShare.AutoSize = true;
            lblShare.BackColor = Color.Transparent;
            lblShare.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblShare.Location = new Point(2, 2);
            lblShare.Name = "lblShare";
            lblShare.Size = new Size(162, 32);
            lblShare.TabIndex = 55;
            lblShare.Text = "Share Tickets";
            // 
            // DGVS
            // 
            DGVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVS.Location = new Point(6, 91);
            DGVS.Name = "DGVS";
            DGVS.RowHeadersWidth = 62;
            DGVS.RowTemplate.Height = 33;
            DGVS.Size = new Size(993, 186);
            DGVS.TabIndex = 56;
            // 
            // lblSolveTickets
            // 
            lblSolveTickets.AutoSize = true;
            lblSolveTickets.BackColor = Color.Transparent;
            lblSolveTickets.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSolveTickets.Location = new Point(0, 34);
            lblSolveTickets.Name = "lblSolveTickets";
            lblSolveTickets.Size = new Size(1164, 54);
            lblSolveTickets.TabIndex = 57;
            lblSolveTickets.Text = resources.GetString("lblSolveTickets.Text");
            // 
            // txtSolution
            // 
            txtSolution.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtSolution.Location = new Point(19, 299);
            txtSolution.MaxLength = 500;
            txtSolution.Multiline = true;
            txtSolution.Name = "txtSolution";
            txtSolution.PlaceholderText = "Explain the solution to this ticket in 500 characters or less.";
            txtSolution.Size = new Size(970, 133);
            txtSolution.TabIndex = 59;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.BackColor = Color.Gray;
            pictureBox6.Location = new Point(6, 291);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(993, 147);
            pictureBox6.TabIndex = 58;
            pictureBox6.TabStop = false;
            // 
            // btnSolveTicket
            // 
            btnSolveTicket.BackColor = Color.FromArgb(64, 0, 0);
            btnSolveTicket.FlatStyle = FlatStyle.Popup;
            btnSolveTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSolveTicket.ForeColor = Color.White;
            btnSolveTicket.Location = new Point(1007, 391);
            btnSolveTicket.Name = "btnSolveTicket";
            btnSolveTicket.Size = new Size(150, 40);
            btnSolveTicket.TabIndex = 64;
            btnSolveTicket.Text = "Solve Ticket";
            btnSolveTicket.UseVisualStyleBackColor = false;
            // 
            // btnSolveClear
            // 
            btnSolveClear.BackColor = Color.FromArgb(64, 0, 0);
            btnSolveClear.FlatStyle = FlatStyle.Popup;
            btnSolveClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSolveClear.ForeColor = Color.White;
            btnSolveClear.Location = new Point(1007, 349);
            btnSolveClear.Name = "btnSolveClear";
            btnSolveClear.Size = new Size(150, 36);
            btnSolveClear.TabIndex = 63;
            btnSolveClear.Text = "Clear";
            btnSolveClear.UseVisualStyleBackColor = false;
            // 
            // txtSolveTicketID
            // 
            txtSolveTicketID.Anchor = AnchorStyles.None;
            txtSolveTicketID.Location = new Point(1007, 119);
            txtSolveTicketID.Margin = new Padding(4);
            txtSolveTicketID.Name = "txtSolveTicketID";
            txtSolveTicketID.Size = new Size(144, 31);
            txtSolveTicketID.TabIndex = 69;
            // 
            // lblTicketID
            // 
            lblTicketID.AutoSize = true;
            lblTicketID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTicketID.Location = new Point(1006, 91);
            lblTicketID.Name = "lblTicketID";
            lblTicketID.Size = new Size(143, 25);
            lblTicketID.TabIndex = 68;
            lblTicketID.Text = "Enter Ticket ID:";
            // 
            // frmITSupport
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
            Name = "frmITSupport";
            Text = "IT Help Desk IT Support Team Ticket Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabSolve.ResumeLayout(false);
            tabSolve.PerformLayout();
            tabShare.ResumeLayout(false);
            tabShare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private TabPage tabSolve;
        private TabPage tabShare;
        private Label lblSolve;
        private Label lblShare;
        private DataGridView DGVS;
        private Label lblSolveTickets;
        private TextBox txtSolution;
        private PictureBox pictureBox6;
        private Button btnSolveTicket;
        private Button btnSolveClear;
        private TextBox txtSolveTicketID;
        private Label lblTicketID;
    }
}