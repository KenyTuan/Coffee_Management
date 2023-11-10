namespace QuanLyQuanCF
{
    partial class fManageProduct
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
            dataGridView2 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductSize = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            ImageFile = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label1 = new Label();
            btnNew = new Button();
            label3 = new Label();
            txtName = new TextBox();
            cbCategories = new ComboBox();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, ProductSize, Type, Quantity, Price, ImageFile, Status, Edit, Delete });
            dataGridView2.Location = new Point(16, 289);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(972, 435);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "Mã";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.Width = 59;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Tên Sản Phẩm";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 130;
            // 
            // ProductSize
            // 
            ProductSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductSize.DataPropertyName = "ProductSize";
            ProductSize.HeaderText = "Size";
            ProductSize.MinimumWidth = 6;
            ProductSize.Name = "ProductSize";
            ProductSize.Width = 65;
            // 
            // Type
            // 
            Type.DataPropertyName = "CategoryName";
            Type.HeaderText = "Loại Sản Phẩm";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Số Lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 101;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 60;
            // 
            // ImageFile
            // 
            ImageFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ImageFile.DataPropertyName = "ImageFile";
            ImageFile.HeaderText = "Hình Ảnh";
            ImageFile.MinimumWidth = 6;
            ImageFile.Name = "ImageFile";
            ImageFile.Resizable = DataGridViewTriState.True;
            ImageFile.Width = 99;
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
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(996, 50);
            label1.TabIndex = 0;
            label1.Text = "Quản lý Sản Phẩm";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Location = new Point(874, 66);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(114, 47);
            btnNew.TabIndex = 0;
            btnNew.Text = "Thêm";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 118);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "Loại:";
            // 
            // txtName
            // 
            txtName.Location = new Point(52, 215);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Tên Sản Phẩm.....";
            txtName.Size = new Size(302, 27);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.DisplayMember = "Tất cả";
            cbCategories.FormattingEnabled = true;
            cbCategories.Items.AddRange(new object[] { "Tất cả" });
            cbCategories.Location = new Point(105, 115);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(115, 28);
            cbCategories.TabIndex = 1;
            cbCategories.ValueMember = "*";
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Location = new Point(467, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(874, 215);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(114, 47);
            btnClose.TabIndex = 7;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fManageProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(996, 736);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(cbCategories);
            Controls.Add(btnNew);
            Name = "fManageProduct";
            Text = "Manage Product";
            WindowState = FormWindowState.Maximized;
            Activated += fManageProduct_Activated;
            Load += fManageProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn NameCustomer;
        private DataGridViewCheckBoxColumn Gender;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Point;
        private DataGridViewCheckBoxColumn sta;
        private DataGridViewButtonColumn et;
        private DataGridViewButtonColumn dt;
        private DataGridView dataGridView2;
        private Label label1;
        private Button btnNew;
        private Label label3;
        private TextBox txtName;
        private ComboBox cbCategories;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductSize;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn ImageFile;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnClose;
    }
}