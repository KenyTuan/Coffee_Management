namespace QuanLyQuanCF
{
    partial class fManageWarehouse
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
            WareHouseHistoryID = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            DateUpdate = new DataGridViewTextBoxColumn();
            TimeUpdate = new DataGridViewTextBoxColumn();
            Content = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1039, 87);
            label1.TabIndex = 0;
            label1.Text = "Lịch Sử Nhập Xuất";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { WareHouseHistoryID, Type, DateUpdate, TimeUpdate, Content, Edit, Delete });
            dataGridView1.Location = new Point(12, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1015, 371);
            dataGridView1.TabIndex = 1;
            // 
            // WareHouseHistoryID
            // 
            WareHouseHistoryID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WareHouseHistoryID.DataPropertyName = "WareHouseHistoryID";
            WareHouseHistoryID.HeaderText = "Mã";
            WareHouseHistoryID.MinimumWidth = 6;
            WareHouseHistoryID.Name = "WareHouseHistoryID";
            WareHouseHistoryID.Width = 59;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Loại";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 66;
            // 
            // DateUpdate
            // 
            DateUpdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DateUpdate.DataPropertyName = "DateUpdate";
            DateUpdate.HeaderText = "Ngày Cập Nhật";
            DateUpdate.MinimumWidth = 6;
            DateUpdate.Name = "DateUpdate";
            DateUpdate.Width = 139;
            // 
            // TimeUpdate
            // 
            TimeUpdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TimeUpdate.DataPropertyName = "TimeUpdate";
            TimeUpdate.HeaderText = "Vào Lúc";
            TimeUpdate.MinimumWidth = 6;
            TimeUpdate.Name = "TimeUpdate";
            TimeUpdate.Width = 89;
            // 
            // Content
            // 
            Content.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Content.DataPropertyName = "Content";
            Content.HeaderText = "Nội Dung";
            Content.MinimumWidth = 6;
            Content.Name = "Content";
            Content.Width = 102;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.Width = 63;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Xóa";
            Delete.Width = 41;
            // 
            // fManageWarehouse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 630);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "fManageWarehouse";
            Text = "fManageWarehouse";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn WareHouseHistoryID;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn DateUpdate;
        private DataGridViewTextBoxColumn TimeUpdate;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}