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
            btnClose = new Button();
            panel2 = new Panel();
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
            btnExport = new Button();
            btnReport = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            dataGridView1.Location = new Point(16, 251);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(902, 399);
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
            IngredientID.Width = 65;
            // 
            // IngredientName
            // 
            IngredientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IngredientName.DataPropertyName = "IngredientName";
            IngredientName.HeaderText = "Tên Nguyên Liệu";
            IngredientName.MinimumWidth = 6;
            IngredientName.Name = "IngredientName";
            IngredientName.Width = 158;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Số Lượng";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 107;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Trạng Thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 92;
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
            Edit.Width = 70;
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
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1492, 90);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Nguyên Liệu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(80, 197);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tên Nguyên Liệu.....";
            textBox1.Size = new Size(313, 30);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(935, 90);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 576);
            panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(395, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 50);
            btnClose.TabIndex = 6;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(txtAmount);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cbStatus);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 410);
            panel2.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(361, 278);
            btnReset.Margin = new Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(129, 32);
            btnReset.TabIndex = 19;
            btnReset.Text = "Xóa";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(126, 278);
            btnNew.Margin = new Padding(4, 3, 4, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(129, 32);
            btnNew.TabIndex = 18;
            btnNew.Text = "Lưu Lại";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(218, 178);
            txtAmount.Margin = new Padding(4, 3, 4, 3);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(162, 30);
            txtAmount.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 185);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 22);
            label5.TabIndex = 16;
            label5.Text = "Số Lượng:";
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Checked = true;
            cbStatus.CheckState = CheckState.Checked;
            cbStatus.Enabled = false;
            cbStatus.Location = new Point(361, 49);
            cbStatus.Margin = new Padding(4, 3, 4, 3);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(118, 26);
            cbStatus.TabIndex = 15;
            cbStatus.Text = "Trạng Thái";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 118);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 22);
            label4.TabIndex = 14;
            label4.Text = "Tên Nguyên Liệu:";
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 115);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(331, 30);
            txtName.TabIndex = 13;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(126, 50);
            txtID.Margin = new Padding(4, 3, 4, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(147, 30);
            txtID.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 53);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 22);
            label3.TabIndex = 11;
            label3.Text = "Mã:";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(557, 166);
            label2.TabIndex = 0;
            label2.Text = "Tạo Mới";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.Location = new Point(619, 195);
            btnImport.Margin = new Padding(4, 3, 4, 3);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(150, 50);
            btnImport.TabIndex = 0;
            btnImport.Text = "Nhập";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.Location = new Point(777, 195);
            btnExport.Margin = new Padding(4, 3, 4, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(150, 50);
            btnExport.TabIndex = 5;
            btnExport.Text = "Xuất";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(13, 80);
            btnReport.Margin = new Padding(4, 3, 4, 3);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(150, 50);
            btnReport.TabIndex = 6;
            btnReport.Text = "Xuất Báo Cáo";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(692, 122);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 7;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fManageIngredient
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1492, 666);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnReport);
            Controls.Add(panel1);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fManageIngredient";
            Text = "Quản Lý Nguyên Liệu";
            WindowState = FormWindowState.Maximized;
            Activated += fManageIngredient_Activated;
            FormClosing += fManageIngredient_FormClosing;
            Load += fManageIngredient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label2;
        private DataGridViewTextBoxColumn IngredientID;
        private DataGridViewTextBoxColumn IngredientName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private ToolTip toolTip1;
        private Button btnImport;
        private Button btnExport;
        private Panel panel2;
        private Button btnReset;
        private Button btnNew;
        private MaskedTextBox txtAmount;
        private Label label5;
        private CheckBox cbStatus;
        private Label label4;
        private TextBox txtName;
        private TextBox txtID;
        private Label label3;
        private Button btnClose;
        private Button btnReport;
        private Button button1;
    }
}