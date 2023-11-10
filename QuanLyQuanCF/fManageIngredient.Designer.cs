namespace QuanLyQuanCF
{
    partial class fManageIngredient
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
            dataGridView1 = new DataGridView();
            IngredientID = new DataGridViewTextBoxColumn();
            IngredientName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            btnReset = new Button();
            btnNew = new Button();
            txtAmount = new MaskedTextBox();
            label5 = new Label();
            cbStatus = new CheckBox();
            label4 = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            btnImport = new Button();
            btnXuat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IngredientID, IngredientName, Amount, Status, Edit, Delete });
            dataGridView1.Location = new Point(12, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(656, 363);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IngredientID
            // 
            IngredientID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IngredientID.DataPropertyName = "IngredientID";
            IngredientID.HeaderText = "Mã";
            IngredientID.MinimumWidth = 6;
            IngredientID.Name = "IngredientID";
            IngredientID.Width = 59;
            // 
            // IngredientName
            // 
            IngredientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IngredientName.DataPropertyName = "IngredientName";
            IngredientName.HeaderText = "Tên Nguyên Liệu";
            IngredientName.MinimumWidth = 6;
            IngredientName.Name = "IngredientName";
            IngredientName.Width = 147;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Số Lượng";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 101;
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
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.Width = 63;
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
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1085, 82);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Nguyên Liệu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(58, 179);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tên Nguyên Liệu.....";
            textBox1.Size = new Size(349, 30);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(680, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 523);
            panel1.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(253, 297);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 10;
            btnReset.Text = "Xóa";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(82, 297);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 9;
            btnNew.Text = "Lưu Lại";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(149, 206);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(119, 27);
            txtAmount.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 213);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 6;
            label5.Text = "Số Lượng:";
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Checked = true;
            cbStatus.CheckState = CheckState.Checked;
            cbStatus.Enabled = false;
            cbStatus.Location = new Point(253, 89);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(100, 24);
            cbStatus.TabIndex = 5;
            cbStatus.Text = "Trạng Thái";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 152);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 4;
            label4.Text = "Tên Nguyên Liệu:";
            // 
            // txtName
            // 
            txtName.Location = new Point(149, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 27);
            txtName.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(82, 90);
            txtID.Name = "txtID";
            txtID.Size = new Size(108, 27);
            txtID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 93);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã:";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(405, 51);
            label2.TabIndex = 0;
            label2.Text = "Tạo Mới";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(548, 109);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(94, 29);
            btnImport.TabIndex = 0;
            btnImport.Text = "Nhập";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(548, 161);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 5;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // fManageIngredient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 605);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(btnXuat);
            Controls.Add(btnImport);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "fManageIngredient";
            Text = "Quản Lý Nguyên Liệu";
            WindowState = FormWindowState.Maximized;
            Activated += fManageIngredient_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Button btnReset;
        private Button btnNew;
        private MaskedTextBox txtAmount;
        private Label label5;
        private CheckBox cbStatus;
        private Label label4;
        private TextBox txtName;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn IngredientID;
        private DataGridViewTextBoxColumn IngredientName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private ToolTip toolTip1;
        private Button btnImport;
        private Button btnXuat;
    }
}