namespace QuanLyQuanCF
{
    partial class fImportIngredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportIngredient));
            panel2 = new Panel();
            label5 = new Label();
            cbIngredient = new ComboBox();
            panel1 = new Panel();
            numAmount = new NumericUpDown();
            btnReset = new Button();
            btnAdd = new Button();
            btnClose = new Button();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            label1 = new Label();
            lsIngredient = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            toolTip1 = new ToolTip(components);
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cbIngredient);
            panel2.Location = new Point(530, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 96);
            panel2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 48);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 10;
            label5.Text = "Chọn Nguyên Liệu:";
            // 
            // cbIngredient
            // 
            cbIngredient.FormattingEnabled = true;
            cbIngredient.Location = new Point(194, 45);
            cbIngredient.Name = "cbIngredient";
            cbIngredient.Size = new Size(186, 28);
            cbIngredient.TabIndex = 6;
            cbIngredient.SelectionChangeCommitted += cbIngredient_SelectionChangeCommitted;
            // 
            // panel1
            // 
            panel1.Controls.Add(numAmount);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(530, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 383);
            panel1.TabIndex = 10;
            // 
            // numAmount
            // 
            numAmount.Location = new Point(166, 159);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(127, 27);
            numAmount.TabIndex = 12;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(145, 246);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 11;
            btnReset.Text = "Xóa";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(24, 246);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(356, 246);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 161);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Số Lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 106);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 6;
            label3.Text = "Tên Nguyên Liệu:";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(145, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(305, 27);
            txtName.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(83, 58);
            txtID.Name = "txtID";
            txtID.Size = new Size(101, 27);
            txtID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 61);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 4;
            label2.Text = "Mã:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(256, 246);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu Lại";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1025, 75);
            label1.TabIndex = 9;
            label1.Text = "Nhập Kho";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lsIngredient
            // 
            lsIngredient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lsIngredient.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsIngredient.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsIngredient.FullRowSelect = true;
            lsIngredient.HoverSelection = true;
            lsIngredient.Location = new Point(1, 82);
            lsIngredient.Name = "lsIngredient";
            lsIngredient.Size = new Size(523, 494);
            lsIngredient.TabIndex = 8;
            lsIngredient.UseCompatibleStateImageBehavior = false;
            lsIngredient.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Sản Phẩm";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số Lượng";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // fImportIngredient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 588);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lsIngredient);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fImportIngredient";
            Text = "Nhập Nguyên Liệu";
            WindowState = FormWindowState.Minimized;
            Load += fImportIngredient_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label5;
        private ComboBox cbIngredient;
        private Panel panel1;
        private NumericUpDown numAmount;
        private Button btnReset;
        private Button btnAdd;
        private Button btnClose;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private TextBox txtID;
        private Label label2;
        private Button btnSave;
        private Label label1;
        private ListView lsIngredient;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ToolTip toolTip1;
    }
}