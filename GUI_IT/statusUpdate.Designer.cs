﻿namespace GUI_IT
{
    partial class frmstatusUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstatusUpdate));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnApprove = new Button();
            btnDeny = new Button();
            lblStatusQuestion = new Label();
            lblinfo = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblHeader = new Label();
            pictureBox6 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblfirstName = new Label();
            lblUserType = new Label();
            lblEmail = new Label();
            lbllastName = new Label();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            txtname = new TextBox();
            txtuser = new TextBox();
            textemail = new TextBox();
            textrole = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Location = new Point(-15, 29);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(481, 33);
            pictureBox3.TabIndex = 37;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = Properties.Resources.redAgentsLogo;
            pictureBox2.Location = new Point(6, 33);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Green;
            btnApprove.FlatStyle = FlatStyle.Popup;
            btnApprove.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(84, 424);
            btnApprove.Margin = new Padding(2);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(116, 47);
            btnApprove.TabIndex = 39;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnDeny
            // 
            btnDeny.BackColor = Color.FromArgb(192, 0, 0);
            btnDeny.FlatStyle = FlatStyle.Popup;
            btnDeny.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeny.ForeColor = Color.White;
<<<<<<< HEAD
            btnDeny.Location = new Point(246, 423);
            btnDeny.Margin = new Padding(2);
=======
            btnDeny.Location = new Point(308, 530);
>>>>>>> efce1ead8d5197b607c96f808af0840ee75fa2a7
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(116, 47);
            btnDeny.TabIndex = 40;
            btnDeny.Text = "Deny";
            btnDeny.UseVisualStyleBackColor = false;
            btnDeny.Click += btnDeny_Click;
            // 
            // lblStatusQuestion
            // 
            lblStatusQuestion.AutoSize = true;
            lblStatusQuestion.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            lblStatusQuestion.Location = new Point(49, 375);
            lblStatusQuestion.Margin = new Padding(2, 0, 2, 0);
=======
            lblStatusQuestion.Location = new Point(61, 473);
>>>>>>> efce1ead8d5197b607c96f808af0840ee75fa2a7
            lblStatusQuestion.Name = "lblStatusQuestion";
            lblStatusQuestion.Size = new Size(381, 23);
            lblStatusQuestion.TabIndex = 41;
            lblStatusQuestion.Text = "Approve or Deny the registration of this user?";
            // 
            // lblinfo
            // 
            lblinfo.AutoSize = true;
            lblinfo.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblinfo.Location = new Point(25, 76);
            lblinfo.Margin = new Padding(2, 0, 2, 0);
            lblinfo.MaximumSize = new Size(429, 19);
            lblinfo.MinimumSize = new Size(429, 19);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new Size(429, 19);
            lblinfo.TabIndex = 42;
            lblinfo.Text = "Below is the information of a new user who wishes to register.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(10, 103);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 261);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox4.Location = new Point(18, 118);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(429, 231);
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox5.Location = new Point(-15, -7);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(487, 37);
            pictureBox5.TabIndex = 45;
            pictureBox5.TabStop = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(64, 0, 0);
            lblHeader.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(4, 4);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(245, 24);
            lblHeader.TabIndex = 49;
            lblHeader.Text = "Red Agents IT Help Desk";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Black;
            pictureBox6.Location = new Point(31, 411);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(395, 74);
            pictureBox6.TabIndex = 50;
            pictureBox6.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
<<<<<<< HEAD
            label1.Location = new Point(49, 375);
            label1.Margin = new Padding(2, 0, 2, 0);
=======
            label1.Location = new Point(61, 473);
>>>>>>> efce1ead8d5197b607c96f808af0840ee75fa2a7
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 51;
            label1.Text = "Approve";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
<<<<<<< HEAD
            label2.Location = new Point(142, 375);
            label2.Margin = new Padding(2, 0, 2, 0);
=======
            label2.Location = new Point(177, 473);
>>>>>>> efce1ead8d5197b607c96f808af0840ee75fa2a7
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 52;
            label2.Text = "Deny";
            // 
            // lblfirstName
            // 
            lblfirstName.AutoSize = true;
            lblfirstName.BackColor = Color.White;
            lblfirstName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblfirstName.Location = new Point(35, 141);
            lblfirstName.Margin = new Padding(2, 0, 2, 0);
            lblfirstName.Name = "lblfirstName";
            lblfirstName.Size = new Size(98, 19);
            lblfirstName.TabIndex = 53;
            lblfirstName.Text = "First Name: ";
            lblfirstName.Click += lblfirstName_Click;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.BackColor = Color.White;
            lblUserType.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserType.Location = new Point(36, 308);
            lblUserType.Margin = new Padding(2, 0, 2, 0);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(46, 19);
            lblUserType.TabIndex = 54;
            lblUserType.Text = "Role:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.White;
            lblEmail.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(35, 251);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 19);
            lblEmail.TabIndex = 55;
            lblEmail.Text = "Email:";
            // 
            // lbllastName
            // 
            lbllastName.AutoSize = true;
            lbllastName.BackColor = Color.White;
            lbllastName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbllastName.Location = new Point(36, 194);
            lbllastName.Margin = new Padding(2, 0, 2, 0);
            lbllastName.Name = "lbllastName";
            lbllastName.Size = new Size(97, 19);
            lbllastName.TabIndex = 56;
            lbllastName.Text = "Last Name: ";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Location = new Point(31, 131);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(395, 38);
            pictureBox7.TabIndex = 57;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.White;
            pictureBox8.Location = new Point(31, 184);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(395, 38);
            pictureBox8.TabIndex = 58;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.White;
            pictureBox9.Location = new Point(31, 298);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(395, 38);
            pictureBox9.TabIndex = 59;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.White;
            pictureBox10.Location = new Point(31, 242);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(395, 38);
            pictureBox10.TabIndex = 60;
            pictureBox10.TabStop = false;
            // 
            // txtname
            // 
            txtname.Location = new Point(138, 137);
            txtname.Name = "txtname";
            txtname.Size = new Size(125, 27);
            txtname.TabIndex = 61;
            txtname.TextChanged += textBox1_TextChanged;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(138, 186);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(125, 27);
            txtuser.TabIndex = 62;
            // 
            // textemail
            // 
            textemail.Location = new Point(94, 247);
            textemail.Name = "textemail";
            textemail.Size = new Size(155, 27);
            textemail.TabIndex = 63;
            // 
            // textrole
            // 
            textrole.Location = new Point(84, 304);
            textrole.Name = "textrole";
            textrole.Size = new Size(125, 27);
            textrole.TabIndex = 64;
            // 
            // frmstatusUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(464, 494);
            Controls.Add(textrole);
            Controls.Add(textemail);
            Controls.Add(txtuser);
            Controls.Add(txtname);
            Controls.Add(lblEmail);
            Controls.Add(lblUserType);
            Controls.Add(lbllastName);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(lblfirstName);
            Controls.Add(pictureBox7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(lblinfo);
            Controls.Add(lblStatusQuestion);
            Controls.Add(btnDeny);
            Controls.Add(btnApprove);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmstatusUpdate";
            Text = "Red Agents IT Registration Status Update";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btnApprove;
        private Button btnDeny;
        private Label lblStatusQuestion;
        private Label lblinfo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblHeader;
        private PictureBox pictureBox6;
        private Label label1;
        private Label label2;
        private Label lblfirstName;
        private Label lblUserType;
        private Label lblEmail;
        private Label lbllastName;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private TextBox txtname;
        private TextBox txtuser;
        private TextBox textemail;
        private TextBox textrole;
    }
}