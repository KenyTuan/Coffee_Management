namespace QuanLyQuanCF
{
    partial class fEditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditEmployee));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtID = new TextBox();
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
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 81);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(657, 81);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Nhân Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtID);
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
            panel2.Size = new Size(657, 354);
            panel2.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Enabled = false;
            txtID.Location = new Point(497, 39);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 19;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(331, 286);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 17;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(182, 286);
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
            cbRole.Items.AddRange(new object[] { "Quyền Hạn" });
            cbRole.Location = new Point(460, 126);
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
            cbGender.Enabled = false;
            cbGender.Location = new Point(404, 89);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(90, 24);
            cbGender.TabIndex = 14;
            cbGender.Text = "Giới Tính";
            cbGender.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(148, 221);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(314, 27);
            txtAddress.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 221);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 12;
            label8.Text = "Địa Chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 178);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 11;
            label7.Text = "Ngày Sinh:";
            // 
            // dtkBirthday
            // 
            dtkBirthday.CustomFormat = "dd/MM/yyyy";
            dtkBirthday.Format = DateTimePickerFormat.Custom;
            dtkBirthday.Location = new Point(445, 173);
            dtkBirthday.Name = "dtkBirthday";
            dtkBirthday.Size = new Size(111, 27);
            dtkBirthday.TabIndex = 10;
            dtkBirthday.Value = new DateTime(1999, 12, 31, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(148, 175);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(156, 27);
            txtPhone.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(148, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(204, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(148, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(314, 27);
            txtName.TabIndex = 6;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Checked = true;
            cbStatus.CheckState = CheckState.Checked;
            cbStatus.Enabled = false;
            cbStatus.Location = new Point(522, 89);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(100, 24);
            cbStatus.TabIndex = 5;
            cbStatus.Text = "Trạng Thái";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 180);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 4;
            label6.Text = "Số Điện Thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 129);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 3;
            label5.Text = "Mật Khẩu Cấp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 89);
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
            // fEditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 435);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fEditEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh Sửa";
            WindowState = FormWindowState.Minimized;
            FormClosing += fEditEmployee_FormClosing;
            Load += fEditEmployee_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dtkBirthday;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtName;
        private CheckBox cbStatus;
        private Label label7;
        private CheckBox cbGender;
        private TextBox txtAddress;
        private Label label8;
        private ComboBox cbRole;
        private Button btnClose;
        private Button btnSave;
        private TextBox txtID;
        private ToolTip toolTip1;
    }
}