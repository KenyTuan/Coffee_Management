namespace QuanLyQuanCF
{
    partial class fManageEmployee
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnNew = new Button();
            txtNameEmployee = new TextBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            EmployeeID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewCheckBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            RoleID = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1436, 112);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1436, 112);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhân Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(txtNameEmployee);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 112);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1436, 138);
            panel2.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.AutoSize = true;
            btnNew.Location = new Point(1285, 41);
            btnNew.Margin = new Padding(4, 3, 4, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(138, 55);
            btnNew.TabIndex = 6;
            btnNew.Text = "Thêm";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtNameEmployee
            // 
            txtNameEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNameEmployee.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameEmployee.Location = new Point(77, 54);
            txtNameEmployee.Margin = new Padding(4, 3, 4, 3);
            txtNameEmployee.Name = "txtNameEmployee";
            txtNameEmployee.PlaceholderText = "Nhập Tên Nhân Viên...";
            txtNameEmployee.Size = new Size(369, 30);
            txtNameEmployee.TabIndex = 5;
            txtNameEmployee.TextChanged += txtNameEmployee_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 250);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1436, 235);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, EmployeeName, Gender, Birthday, Address, Phone, Email, Password, RoleID, Status, Edit, Delete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1436, 235);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.HeaderText = "Mã";
            EmployeeID.MinimumWidth = 6;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            EmployeeID.Width = 65;
            // 
            // EmployeeName
            // 
            EmployeeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeName.DataPropertyName = "EmployeeName";
            EmployeeName.HeaderText = "Tên Nhân Viên";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            EmployeeName.Width = 156;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới Tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 94;
            // 
            // Birthday
            // 
            Birthday.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Birthday.DataPropertyName = "Birthday";
            Birthday.HeaderText = "Ngày Sinh";
            Birthday.MinimumWidth = 6;
            Birthday.Name = "Birthday";
            Birthday.ReadOnly = true;
            Birthday.Width = 120;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Địa Chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 101;
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Số Điện Thoại";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 154;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 86;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Mật Khẩu";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Width = 116;
            // 
            // RoleID
            // 
            RoleID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RoleID.DataPropertyName = "RoleID";
            RoleID.HeaderText = "Đặc Quyền";
            RoleID.MinimumWidth = 6;
            RoleID.Name = "RoleID";
            RoleID.ReadOnly = true;
            RoleID.Width = 126;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Trạng Thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 102;
            // 
            // Edit
            // 
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Sửa";
            Edit.Width = 125;
            // 
            // Delete
            // 
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Xóa";
            Delete.Width = 125;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(947, 29);
            button1.Name = "button1";
            button1.Size = new Size(120, 47);
            button1.TabIndex = 7;
            button1.Text = "Đóng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fManageEmployee
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 485);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fManageEmployee";
            Text = "Nhân Viên";
            WindowState = FormWindowState.Maximized;
            Activated += fManageEmployee_Activated;
            FormClosing += fManageEmployee_FormClosing;
            Load += fManageEmployee_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private TextBox txtNameEmployee;
        private Button btnNew;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewCheckBoxColumn Gender;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn RoleID;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button button1;
    }
}