﻿namespace QuanLyQuanCF
{
    partial class fNewEmployee
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNewEmployee));
            panel2 = new Panel();
            btnClose = new Button();
            btnSave = new Button();
            cbRole = new ComboBox();
            cbGender = new CheckBox();
            txtAddress = new TextBox();
            label8 = new Label();
            label7 = new Label();
            dtkBirthday = new DateTimePicker();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            cbStatus = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(cbRole);
            panel2.Controls.Add(cbGender);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dtkBirthday);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(cbStatus);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(639, 318);
            panel2.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(368, 259);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 17;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(180, 259);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "Lưu Lại";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(491, 126);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(111, 28);
            cbRole.TabIndex = 15;
            cbRole.Text = "Quyền Hạn";
            // 
            // cbGender
            // 
            cbGender.AutoSize = true;
            cbGender.Checked = true;
            cbGender.CheckState = CheckState.Checked;
            cbGender.Location = new Point(512, 82);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(90, 24);
            cbGender.TabIndex = 1;
            cbGender.Text = "Giới Tính";
            cbGender.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(148, 202);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(314, 27);
            txtAddress.TabIndex = 13;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 205);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 12;
            label8.Text = "Địa Chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(406, 167);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 11;
            label7.Text = "Ngày Sinh:";
            // 
            // dtkBirthday
            // 
            dtkBirthday.CustomFormat = "dd/MM/yyyy";
            dtkBirthday.Format = DateTimePickerFormat.Custom;
            dtkBirthday.Location = new Point(491, 166);
            dtkBirthday.Name = "dtkBirthday";
            dtkBirthday.Size = new Size(111, 27);
            dtkBirthday.TabIndex = 5;
            dtkBirthday.Value = new DateTime(2023, 11, 12, 0, 0, 0, 0);
            dtkBirthday.Validating += dtkBirthday_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(149, 164);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(156, 27);
            txtPhone.TabIndex = 4;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(148, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(314, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(148, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(314, 27);
            txtEmail.TabIndex = 2;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(314, 27);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Checked = true;
            cbStatus.CheckState = CheckState.Checked;
            cbStatus.Enabled = false;
            cbStatus.Location = new Point(512, 41);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(100, 24);
            cbStatus.TabIndex = 5;
            cbStatus.Text = "Trạng Thái";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 171);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 4;
            label6.Text = "Số Điện Thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 129);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 3;
            label5.Text = "Mật Khẩu Cấp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 86);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 41);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 73);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 81);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(639, 81);
            label1.TabIndex = 0;
            label1.Text = "Thêm Nhân Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fNewEmployee
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(639, 399);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fNewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân Viên";
            WindowState = FormWindowState.Minimized;
            FormClosing += fNewEmployee_FormClosing;
            Load += fNewEmployee_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cbRole;
        private CheckBox cbGender;
        private TextBox txtAddress;
        private Label label8;
        private Label label7;
        private DateTimePicker dtkBirthday;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtName;
        private CheckBox cbStatus;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private ToolTip toolTip1;
    }
}