namespace QuanLyQuanCF
{
    partial class ItemProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pbProduct = new PictureBox();
            panel2 = new Panel();
            panel5 = new Panel();
            btnSelect = new Button();
            panel4 = new Panel();
            numCount = new NumericUpDown();
            lblPrice = new Label();
            lblSize = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lblName = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pbProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 200);
            panel1.TabIndex = 0;
            // 
            // pbProduct
            // 
            pbProduct.Dock = DockStyle.Fill;
            pbProduct.Location = new Point(0, 0);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(300, 200);
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 200);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSelect);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 130);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 70);
            panel5.TabIndex = 2;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = SystemColors.ControlDark;
            btnSelect.Location = new Point(70, 17);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(150, 40);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Chọn";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(numCount);
            panel4.Controls.Add(lblPrice);
            panel4.Controls.Add(lblSize);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 80);
            panel4.TabIndex = 1;
            // 
            // numCount
            // 
            numCount.Location = new Point(191, 21);
            numCount.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCount.Name = "numCount";
            numCount.ReadOnly = true;
            numCount.Size = new Size(96, 27);
            numCount.TabIndex = 4;
            numCount.TextAlign = HorizontalAlignment.Center;
            numCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(101, 37);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "1000";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(101, 3);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(17, 20);
            lblSize.TabIndex = 2;
            lblSize.Text = "S";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 37);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Đơn Giá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 3);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Kích Thước";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 50);
            panel3.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(300, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Sản Phẩm";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ItemProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ItemProduct";
            Size = new Size(300, 400);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pbProduct;
        private Panel panel4;
        private Button btnSelect;
        private Panel panel3;
        private Label lblName;
        private Panel panel5;
        private Label label1;
        private Label lblPrice;
        private Label lblSize;
        private Label label2;
        private NumericUpDown numCount;
    }
}
