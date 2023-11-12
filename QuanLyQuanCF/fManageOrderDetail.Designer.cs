namespace QuanLyQuanCF
{
    partial class fManageOrderDetail
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
            mtbDate = new MaskedTextBox();
            label1 = new Label();
            panel2 = new Panel();
            lsOrder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel6 = new Panel();
            label2 = new Label();
            cbCustomer = new ComboBox();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            textBox1 = new TextBox();
            panel4 = new Panel();
            txtTotal = new TextBox();
            btnClose = new Button();
            btnRest = new Button();
            btnPay = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mtbDate);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1273, 165);
            panel1.TabIndex = 0;
            // 
            // mtbDate
            // 
            mtbDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            mtbDate.Enabled = false;
            mtbDate.Location = new Point(1047, 48);
            mtbDate.Name = "mtbDate";
            mtbDate.Size = new Size(216, 27);
            mtbDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1273, 165);
            label1.TabIndex = 0;
            label1.Text = "COFFEE AE 86";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lsOrder);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(726, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 529);
            panel2.TabIndex = 1;
            // 
            // lsOrder
            // 
            lsOrder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader4, columnHeader2, columnHeader3, columnHeader5 });
            lsOrder.Dock = DockStyle.Fill;
            lsOrder.FullRowSelect = true;
            lsOrder.GridLines = true;
            lsOrder.Location = new Point(0, 0);
            lsOrder.Name = "lsOrder";
            lsOrder.Size = new Size(545, 360);
            lsOrder.TabIndex = 1;
            lsOrder.UseCompatibleStateImageBehavior = false;
            lsOrder.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Sản Phẩm";
            columnHeader1.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Size";
            columnHeader4.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số Lượng";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn Giá";
            columnHeader3.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Thành Tiền";
            columnHeader5.Width = 100;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label2);
            panel6.Controls.Add(cbCustomer);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 360);
            panel6.Name = "panel6";
            panel6.Size = new Size(545, 167);
            panel6.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Khách Hàng";
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(152, 38);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(226, 28);
            cbCustomer.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(726, 529);
            panel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 58);
            flowLayoutPanel1.Margin = new Padding(15, 3, 15, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(726, 346);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(726, 58);
            panel5.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(35, 6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập Thức Uống.......";
            textBox1.Size = new Size(264, 30);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtTotal);
            panel4.Controls.Add(btnClose);
            panel4.Controls.Add(btnRest);
            panel4.Controls.Add(btnPay);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 404);
            panel4.Name = "panel4";
            panel4.Size = new Size(726, 125);
            panel4.TabIndex = 0;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(165, 28);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(249, 76);
            txtTotal.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(582, 24);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 78);
            btnClose.TabIndex = 2;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRest
            // 
            btnRest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnRest.Location = new Point(456, 24);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(120, 78);
            btnRest.TabIndex = 1;
            btnRest.Text = "Làm Mới";
            btnRest.UseVisualStyleBackColor = true;
            btnRest.Click += btnRest_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(23, 24);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(120, 80);
            btnPay.TabIndex = 0;
            btnPay.Text = "Thanh Toán";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // fManageOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1273, 694);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fManageOrderDetail";
            Text = "Đặt Hàng";
            WindowState = FormWindowState.Maximized;
            Load += fManageOrderDetail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnClose;
        private Button btnRest;
        private Button btnPay;
        private TextBox txtTotal;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private TextBox textBox1;
        private MaskedTextBox mtbDate;
        private Panel panel6;
        private ListView lsOrder;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private ComboBox cbCustomer;
        private ToolTip toolTip1;
    }
}