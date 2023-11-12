namespace QuanLyQuanCF
{
    partial class fManageOrder
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            txtID = new TextBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            NameCustomer = new DataGridViewTextBoxColumn();
            OrderTime = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Select = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            toolTip1 = new ToolTip(components);
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
            panel1.Size = new Size(1292, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1292, 94);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Đơn Hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(txtID);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 94);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1292, 97);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(1138, 23);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 55);
            btnClose.TabIndex = 1;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(50, 23);
            txtID.Margin = new Padding(4, 3, 4, 3);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Mã Đơn Hàng.....";
            txtID.Size = new Size(414, 30);
            txtID.TabIndex = 0;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 191);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1292, 416);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderID, EmployeeName, NameCustomer, OrderTime, OrderDate, Total, Select, Delete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1292, 416);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OrderID
            // 
            OrderID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "Mã";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            OrderID.Width = 59;
            // 
            // EmployeeName
            // 
            EmployeeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeName.DataPropertyName = "EmployeeName";
            EmployeeName.HeaderText = "Tên Nhân Viên";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            EmployeeName.Width = 133;
            // 
            // NameCustomer
            // 
            NameCustomer.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NameCustomer.DataPropertyName = "NameCustomer";
            NameCustomer.HeaderText = "Tên Khách Hàng";
            NameCustomer.MinimumWidth = 6;
            NameCustomer.Name = "NameCustomer";
            NameCustomer.ReadOnly = true;
            NameCustomer.Resizable = DataGridViewTriState.True;
            NameCustomer.Width = 145;
            // 
            // OrderTime
            // 
            OrderTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderTime.DataPropertyName = "OrderTime";
            OrderTime.HeaderText = "Giờ Đặt";
            OrderTime.MinimumWidth = 6;
            OrderTime.Name = "OrderTime";
            OrderTime.ReadOnly = true;
            OrderTime.Width = 89;
            // 
            // OrderDate
            // 
            OrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderDate.DataPropertyName = "OrderDate";
            OrderDate.HeaderText = "Ngày Đặt";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            OrderDate.Width = 101;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Thành Tiền";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 110;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Select.DataPropertyName = "Select";
            Select.HeaderText = "Xem Chi Tiết";
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.ReadOnly = true;
            Select.Resizable = DataGridViewTriState.True;
            Select.SortMode = DataGridViewColumnSortMode.Automatic;
            Select.Width = 122;
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
            // fManageOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1292, 607);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fManageOrder";
            Text = "Danh Sách Đơn Hàng";
            WindowState = FormWindowState.Maximized;
            Load += fManageOrder_Load;
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
        private TextBox txtID;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn NameCustomer;
        private DataGridViewTextBoxColumn OrderTime;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn Select;
        private DataGridViewButtonColumn Delete;
        private ToolTip toolTip1;
        private Button btnClose;
    }
}