namespace QuanLyQuanCF
{
    partial class fManagerCustomer
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtNameCustomer = new TextBox();
            btnNew = new Button();
            CustomerID = new DataGridViewTextBoxColumn();
            NameCustomer = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewCheckBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Point = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(995, 78);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Khách Hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID, NameCustomer, Gender, Birthday, Address, Phone, Point, Status, Edit, Delete });
            dataGridView1.Location = new Point(12, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(971, 370);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtNameCustomer
            // 
            txtNameCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNameCustomer.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameCustomer.Location = new Point(591, 101);
            txtNameCustomer.Name = "txtNameCustomer";
            txtNameCustomer.PlaceholderText = "Nhập Tên Khách Hàng......";
            txtNameCustomer.Size = new Size(357, 30);
            txtNameCustomer.TabIndex = 4;
            txtNameCustomer.TextChanged += txtNameCustomer_TextChanged;
            // 
            // btnNew
            // 
            btnNew.AutoSize = true;
            btnNew.Location = new Point(43, 81);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 50);
            btnNew.TabIndex = 1;
            btnNew.Text = "Thêm";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "Mã";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 59;
            // 
            // NameCustomer
            // 
            NameCustomer.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NameCustomer.DataPropertyName = "NameCustomer";
            NameCustomer.HeaderText = "Tên Khách Hàng";
            NameCustomer.MinimumWidth = 6;
            NameCustomer.Name = "NameCustomer";
            NameCustomer.Width = 145;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới Tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 74;
            // 
            // Birthday
            // 
            Birthday.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Birthday.DataPropertyName = "Birthday";
            Birthday.HeaderText = "Ngày Sinh";
            Birthday.MinimumWidth = 6;
            Birthday.Name = "Birthday";
            Birthday.Width = 105;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Địa Chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 86;
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Số Điện Thoại";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 131;
            // 
            // Point
            // 
            Point.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Point.DataPropertyName = "Point";
            Point.HeaderText = "Điểm";
            Point.MinimumWidth = 6;
            Point.Name = "Point";
            Point.Width = 74;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Trạng Thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 84;
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
            // fManagerCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 541);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(btnNew);
            Controls.Add(txtNameCustomer);
            Controls.Add(label1);
            Name = "fManagerCustomer";
            Text = "ManagerCustomer";
            WindowState = FormWindowState.Maximized;
            Activated += fManagerCustomer_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtNameCustomer;
        private Button btnNew;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn NameCustomer;
        private DataGridViewCheckBoxColumn Gender;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Point;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}