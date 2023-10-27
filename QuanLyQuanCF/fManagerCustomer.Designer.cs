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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
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
            panel2 = new Panel();
            txtNameCustomer = new TextBox();
            label2 = new Label();
            btnFind = new Button();
            btnNew = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(357, 2);
            label1.Name = "label1";
            label1.Size = new Size(490, 51);
            label1.TabIndex = 0;
            label1.Text = "MANAGER CUSTOMER";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1230, 396);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID, NameCustomer, Gender, Birthday, Address, Phone, Point, Status, Edit, Delete });
            dataGridView1.Location = new Point(0, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1227, 287);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "Customer ID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 120;
            // 
            // NameCustomer
            // 
            NameCustomer.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NameCustomer.DataPropertyName = "NameCustomer";
            NameCustomer.HeaderText = "Name";
            NameCustomer.MinimumWidth = 6;
            NameCustomer.Name = "NameCustomer";
            NameCustomer.Width = 78;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 63;
            // 
            // Birthday
            // 
            Birthday.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Birthday.DataPropertyName = "Birthday";
            Birthday.HeaderText = "Birthday";
            Birthday.MinimumWidth = 6;
            Birthday.Name = "Birthday";
            Birthday.Width = 93;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 91;
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 79;
            // 
            // Point
            // 
            Point.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Point.DataPropertyName = "Point";
            Point.HeaderText = "Point";
            Point.MinimumWidth = 6;
            Point.Name = "Point";
            Point.Width = 71;
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
            panel2.Controls.Add(txtNameCustomer);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnFind);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1224, 100);
            panel2.TabIndex = 1;
            // 
            // txtNameCustomer
            // 
            txtNameCustomer.Location = new Point(884, 62);
            txtNameCustomer.Name = "txtNameCustomer";
            txtNameCustomer.Size = new Size(226, 27);
            txtNameCustomer.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(759, 66);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 3;
            label2.Text = "Name Customer:";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1116, 62);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(24, 44);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(114, 47);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // fManagerCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 420);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "fManagerCustomer";
            Text = "ManagerCustomer";
            WindowState = FormWindowState.Maximized;
            Activated += fManagerCustomer_Activated;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtNameCustomer;
        private Label label2;
        private Button btnFind;
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