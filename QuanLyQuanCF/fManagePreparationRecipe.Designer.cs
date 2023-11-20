namespace QuanLyQuanCF
{
    partial class fManagePreparationRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManagePreparationRecipe));
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnClose = new Button();
            btnNew = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3, 10, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(920, 117);
            label1.TabIndex = 10;
            label1.Text = "CÔNG THỨC CHUẨN BỊ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 117);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(733, 615);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnNew);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(739, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 615);
            panel1.TabIndex = 12;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Top;
            btnClose.Location = new Point(0, 57);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(181, 57);
            btnClose.TabIndex = 1;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Top;
            btnNew.Location = new Point(0, 0);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(181, 57);
            btnNew.TabIndex = 0;
            btnNew.Text = "Thêm Mới";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(26, 71);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm tên sản phẩm.....";
            textBox1.Size = new Size(370, 34);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // fManagePreparationRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(920, 732);
            ControlBox = false;
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fManagePreparationRecipe";
            Text = "Quản Lý Công Thức Chuẩn bị";
            WindowState = FormWindowState.Maximized;
            Load += fManagePreparationRecipe_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button btnNew;
        private Button btnClose;
        private TextBox textBox1;
        public static FlowLayoutPanel flowLayoutPanel1;
    }
}