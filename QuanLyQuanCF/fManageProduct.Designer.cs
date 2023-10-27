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
            panel1 = new Panel();
            panel4 = new Panel();
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
            panel2 = new Panel();
            cbCategories = new ComboBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnNew = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 447);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.Controls.Add(dataGridView2);
            panel4.Location = new Point(420, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(888, 314);
            panel4.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, ProductSize, Type, Quantity, Price, ImageFile, Status, Edit, Delete });
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(882, 308);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "Product ID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.Width = 108;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 78;
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
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 94;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 70;
            // 
            // ImageFile
            // 
            ImageFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ImageFile.DataPropertyName = "ImageFile";
            ImageFile.HeaderText = "Image";
            ImageFile.MinimumWidth = 6;
            ImageFile.Name = "ImageFile";
            ImageFile.Width = 80;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 55;
            // 
            // Edit
            // 
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 125;
            // 
            // Delete
            // 
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 125;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(cbCategories);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1302, 121);
            panel2.TabIndex = 1;
            // 
            // cbCategories
            // 
            cbCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.DisplayMember = "Tất cả";
            cbCategories.FormattingEnabled = true;
            cbCategories.Items.AddRange(new object[] { "Tất cả" });
            cbCategories.Location = new Point(1184, 46);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(115, 28);
            cbCategories.TabIndex = 1;
            cbCategories.ValueMember = "*";
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtName.Location = new Point(1073, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 27);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1133, 49);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Filter:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1015, 87);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnNew.Location = new Point(24, 44);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(114, 47);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(396, 2);
            label1.Name = "label1";
            label1.Size = new Size(354, 51);
            label1.TabIndex = 0;
            label1.Text = "MANAGE MENU";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 308);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(12, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 314);
            panel3.TabIndex = 8;
            // 
            // fManageProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 471);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fManageProduct";
            Text = "Manage Product";
            WindowState = FormWindowState.Maximized;
            Activated += fManageProduct_Activated;
            Load += fManageProduct_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
        private Panel panel2;
        private TextBox txtName;
        private Label label2;
        private Button btnNew;
        private Label label1;
        private DataGridView dataGridView2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel4;
        private ComboBox cbCategories;
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
    }
}