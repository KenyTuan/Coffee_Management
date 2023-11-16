namespace QuanLyQuanCF
{
    partial class fEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditProduct));
            panel1 = new Panel();
            panel9 = new Panel();
            label3 = new Label();
            cbCategories = new ComboBox();
            panel8 = new Panel();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            btnBrowse = new Button();
            label7 = new Label();
            txtImage = new TextBox();
            panel6 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            panel5 = new Panel();
            mPrice = new MaskedTextBox();
            label6 = new Label();
            panel4 = new Panel();
            txtID = new TextBox();
            label8 = new Label();
            ckbStatus = new CheckBox();
            cbSize = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            txtName = new TextBox();
            numQuantity = new NumericUpDown();
            label5 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 533);
            panel1.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(label3);
            panel9.Controls.Add(cbCategories);
            panel9.Location = new Point(3, 210);
            panel9.Name = "panel9";
            panel9.Size = new Size(341, 54);
            panel9.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 20);
            label3.Name = "label3";
            label3.Size = new Size(52, 22);
            label3.TabIndex = 1;
            label3.Text = "Loại:";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(107, 14);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(174, 28);
            cbCategories.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(350, 207);
            panel8.Name = "panel8";
            panel8.Size = new Size(264, 252);
            panel8.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnBrowse);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(txtImage);
            panel7.Location = new Point(3, 330);
            panel7.Name = "panel7";
            panel7.Size = new Size(341, 129);
            panel7.TabIndex = 8;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.ButtonShadow;
            btnBrowse.Location = new Point(218, 50);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(79, 29);
            btnBrowse.TabIndex = 9;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 17);
            label7.Name = "label7";
            label7.Size = new Size(130, 22);
            label7.TabIndex = 5;
            label7.Text = "Hình Sản Phẩm";
            // 
            // txtImage
            // 
            txtImage.Enabled = false;
            txtImage.Location = new Point(19, 50);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(190, 27);
            txtImage.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(btnSave);
            panel6.Location = new Point(3, 465);
            panel6.Name = "panel6";
            panel6.Size = new Size(611, 63);
            panel6.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(340, 17);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Đóng";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(151, 17);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Xác Nhận";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(mPrice);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(3, 270);
            panel5.Name = "panel5";
            panel5.Size = new Size(341, 54);
            panel5.TabIndex = 6;
            // 
            // mPrice
            // 
            mPrice.Location = new Point(107, 15);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(153, 27);
            mPrice.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 17);
            label6.Name = "label6";
            label6.Size = new Size(45, 22);
            label6.TabIndex = 3;
            label6.Text = "Giá:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtID);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(ckbStatus);
            panel4.Controls.Add(cbSize);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 87);
            panel4.Name = "panel4";
            panel4.Size = new Size(611, 54);
            panel4.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(107, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(124, 30);
            txtID.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(19, 18);
            label8.Name = "label8";
            label8.Size = new Size(42, 22);
            label8.TabIndex = 3;
            label8.Text = "Mã:";
            // 
            // ckbStatus
            // 
            ckbStatus.AutoSize = true;
            ckbStatus.Checked = true;
            ckbStatus.CheckState = CheckState.Checked;
            ckbStatus.Enabled = false;
            ckbStatus.FlatStyle = FlatStyle.Popup;
            ckbStatus.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckbStatus.Location = new Point(483, 16);
            ckbStatus.Name = "ckbStatus";
            ckbStatus.Size = new Size(115, 26);
            ckbStatus.TabIndex = 5;
            ckbStatus.Text = "Trạng Thái";
            ckbStatus.UseVisualStyleBackColor = true;
            // 
            // cbSize
            // 
            cbSize.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSize.FormattingEnabled = true;
            cbSize.Items.AddRange(new object[] { "S", "M", "L" });
            cbSize.Location = new Point(332, 15);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(118, 30);
            cbSize.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(276, 18);
            label4.Name = "label4";
            label4.Size = new Size(50, 22);
            label4.TabIndex = 3;
            label4.Text = "Size:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(numQuantity);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(3, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(611, 54);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 17);
            label2.Name = "label2";
            label2.Size = new Size(124, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(149, 14);
            txtName.Name = "txtName";
            txtName.Size = new Size(234, 30);
            txtName.TabIndex = 1;
            // 
            // numQuantity
            // 
            numQuantity.BackColor = SystemColors.HighlightText;
            numQuantity.Enabled = false;
            numQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numQuantity.ImeMode = ImeMode.NoControl;
            numQuantity.Location = new Point(510, 14);
            numQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(72, 30);
            numQuantity.TabIndex = 2;
            numQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(409, 17);
            label5.Name = "label5";
            label5.Size = new Size(93, 22);
            label5.TabIndex = 1;
            label5.Text = "Số Lượng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(611, 78);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(141, 13);
            label1.Name = "label1";
            label1.Size = new Size(379, 45);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Sản Phẩm";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // fEditProduct
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(643, 560);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fEditProduct";
            Text = "Chỉnh Sửa";
            FormClosing += fEditProduct_FormClosing;
            Load += fEditProduct_Load;
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel9;
        private Label label3;
        private ComboBox cbCategories;
        private Panel panel8;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Button btnBrowse;
        private Label label7;
        private TextBox txtImage;
        private Panel panel6;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel5;
        private MaskedTextBox mPrice;
        private Label label6;
        private Panel panel4;
        private TextBox txtID;
        private Label label8;
        private CheckBox ckbStatus;
        private ComboBox cbSize;
        private Label label4;
        private Panel panel3;
        private Label label2;
        private TextBox txtName;
        private NumericUpDown numQuantity;
        private Label label5;
        private Panel panel2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
    }
}