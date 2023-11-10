namespace QuanLyQuanCF
{
    partial class fNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNewCustomer));
            panel1 = new Panel();
            panel4 = new Panel();
            btnClose = new Button();
            btnSave = new Button();
            panel6 = new Panel();
            label5 = new Label();
            txtAddress = new TextBox();
            panel3 = new Panel();
            numPoint = new NumericUpDown();
            label7 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            panel5 = new Panel();
            dtpBirthday = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            txtPhone = new TextBox();
            panel2 = new Panel();
            cbGender = new CheckBox();
            cbStatus = new CheckBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPoint).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 469);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnClose);
            panel4.Controls.Add(btnSave);
            panel4.Location = new Point(20, 376);
            panel4.Name = "panel4";
            panel4.Size = new Size(506, 70);
            panel4.TabIndex = 16;
            // 
            // btnClose
            // 
            btnClose.CausesValidation = false;
            btnClose.Location = new Point(304, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(137, 21);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtAddress);
            panel6.Location = new Point(20, 300);
            panel6.Name = "panel6";
            panel6.Size = new Size(506, 70);
            panel6.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 24);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 3;
            label5.Text = "Địa Chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(96, 17);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(407, 27);
            txtAddress.TabIndex = 7;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // panel3
            // 
            panel3.Controls.Add(numPoint);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtName);
            panel3.Location = new Point(20, 148);
            panel3.Name = "panel3";
            panel3.Size = new Size(506, 70);
            panel3.TabIndex = 13;
            // 
            // numPoint
            // 
            numPoint.Enabled = false;
            numPoint.Location = new Point(440, 18);
            numPoint.Name = "numPoint";
            numPoint.Size = new Size(63, 27);
            numPoint.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(379, 20);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 13;
            label7.Text = "Điểm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 24);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên Khách:";
            // 
            // txtName
            // 
            txtName.Location = new Point(96, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 27);
            txtName.TabIndex = 3;
            txtName.Validating += txtName_Validating;
            // 
            // panel5
            // 
            panel5.Controls.Add(dtpBirthday);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtPhone);
            panel5.Location = new Point(20, 224);
            panel5.Name = "panel5";
            panel5.Size = new Size(506, 70);
            panel5.TabIndex = 15;
            // 
            // dtpBirthday
            // 
            dtpBirthday.CustomFormat = "dd/MM/yyyy";
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.Location = new Point(389, 19);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(114, 27);
            dtpBirthday.TabIndex = 6;
            dtpBirthday.Validating += dtpBirthday_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 24);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 11;
            label6.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 24);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Điện Thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(96, 21);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(136, 27);
            txtPhone.TabIndex = 5;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbGender);
            panel2.Controls.Add(cbStatus);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtID);
            panel2.Location = new Point(20, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 70);
            panel2.TabIndex = 12;
            // 
            // cbGender
            // 
            cbGender.AutoSize = true;
            cbGender.Location = new Point(261, 24);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(90, 24);
            cbGender.TabIndex = 1;
            cbGender.Text = "Giới Tính";
            cbGender.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Checked = true;
            cbStatus.CheckState = CheckState.Checked;
            cbStatus.Enabled = false;
            cbStatus.Location = new Point(403, 23);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(100, 24);
            cbStatus.TabIndex = 4;
            cbStatus.Text = "Trạng Thái";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 23);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "ID Khách:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(96, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(136, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 14);
            label1.Name = "label1";
            label1.Size = new Size(242, 35);
            label1.TabIndex = 0;
            label1.Text = "Thêm Thành Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fNewCustomer
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(572, 493);
            ControlBox = false;
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fNewCustomer";
            Text = "Thêm Thành Viên";
            WindowState = FormWindowState.Minimized;
            FormClosing += fNewCustomer_FormClosing;
            Load += fNewCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPoint).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Panel panel6;
        private Label label5;
        private TextBox txtAddress;
        private Panel panel3;
        private NumericUpDown numPoint;
        private Label label7;
        private Panel panel5;
        private DateTimePicker dtpBirthday;
        private Label label6;
        private Label label4;
        private TextBox txtPhone;
        private Panel panel2;
        private CheckBox cbGender;
        private CheckBox cbStatus;
        private Panel panel4;
        private Button btnClose;
        private Button btnSave;
        private ToolTip toolTip1;
    }
}