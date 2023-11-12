namespace QuanLyQuanCF
{
    partial class fShowDetailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fShowDetailOrder));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            btnClose = new Button();
            lsDetail = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lblTime = new Label();
            lblDateOrder = new Label();
            lblNameEmployee = new Label();
            lblNameCustomer = new Label();
            lblID = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(686, 90);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN ĐƠN HÀNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lsDetail);
            panel2.Controls.Add(lblTime);
            panel2.Controls.Add(lblDateOrder);
            panel2.Controls.Add(lblNameEmployee);
            panel2.Controls.Add(lblNameCustomer);
            panel2.Controls.Add(lblID);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 90);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 594);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(104, 435);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 35);
            label2.TabIndex = 9;
            label2.Text = "Total:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 499);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(686, 95);
            panel3.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(220, 19);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(260, 52);
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lsDetail
            // 
            lsDetail.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader3 });
            lsDetail.GridLines = true;
            lsDetail.Location = new Point(16, 150);
            lsDetail.Margin = new Padding(4, 3, 4, 3);
            lsDetail.Name = "lsDetail";
            lsDetail.RightToLeft = RightToLeft.No;
            lsDetail.Size = new Size(652, 257);
            lsDetail.TabIndex = 7;
            lsDetail.UseCompatibleStateImageBehavior = false;
            lsDetail.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Số Lượng";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Thức Uống";
            columnHeader2.Width = 320;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Size";
            columnHeader4.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Giá";
            columnHeader3.Width = 120;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(418, 32);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(80, 22);
            lblTime.TabIndex = 6;
            lblTime.Text = "Giờ Đặt:";
            lblTime.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDateOrder
            // 
            lblDateOrder.AutoSize = true;
            lblDateOrder.Location = new Point(198, 32);
            lblDateOrder.Margin = new Padding(4, 0, 4, 0);
            lblDateOrder.Name = "lblDateOrder";
            lblDateOrder.Size = new Size(90, 22);
            lblDateOrder.TabIndex = 5;
            lblDateOrder.Text = "Ngày Đặt:";
            lblDateOrder.TextAlign = ContentAlignment.TopRight;
            // 
            // lblNameEmployee
            // 
            lblNameEmployee.AutoSize = true;
            lblNameEmployee.Location = new Point(365, 88);
            lblNameEmployee.Margin = new Padding(4, 0, 4, 0);
            lblNameEmployee.Name = "lblNameEmployee";
            lblNameEmployee.Size = new Size(133, 22);
            lblNameEmployee.TabIndex = 4;
            lblNameEmployee.Text = "Tên Nhân Viên:";
            lblNameEmployee.TextAlign = ContentAlignment.TopRight;
            // 
            // lblNameCustomer
            // 
            lblNameCustomer.AutoSize = true;
            lblNameCustomer.Location = new Point(30, 88);
            lblNameCustomer.Margin = new Padding(4, 0, 4, 0);
            lblNameCustomer.Name = "lblNameCustomer";
            lblNameCustomer.Size = new Size(147, 22);
            lblNameCustomer.TabIndex = 2;
            lblNameCustomer.Text = "Tên Khách Hàng:";
            lblNameCustomer.TextAlign = ContentAlignment.TopRight;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(30, 32);
            lblID.Margin = new Padding(4, 0, 4, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(42, 22);
            lblID.TabIndex = 1;
            lblID.Text = "Mã:";
            lblID.TextAlign = ContentAlignment.TopRight;
            // 
            // fShowDetailOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(686, 684);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fShowDetailOrder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông Tin Đơn Hàng";
            WindowState = FormWindowState.Minimized;
            Load += fShowDetailOrder_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label lblNameEmployee;
        private Label lblNameCustomer;
        private Label lblID;
        private Label lblTime;
        private Label lblDateOrder;
        private Panel panel3;
        private ListView lsDetail;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnClose;
        private Label label2;
        private ColumnHeader columnHeader4;
    }
}