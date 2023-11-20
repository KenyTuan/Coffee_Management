namespace QuanLyQuanCF
{
    partial class fEditrPeparationRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditrPeparationRecipe));
            label1 = new Label();
            panel1 = new Panel();
            btnDelete = new Button();
            button3 = new Button();
            button2 = new Button();
            btnAdd = new Button();
            panel6 = new Panel();
            panel5 = new Panel();
            txtAmount = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            comboBox1 = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            lblSize = new Label();
            lblID = new Label();
            lblProduct = new Label();
            panel2 = new Panel();
            toolTip1 = new ToolTip(components);
            lsIngredient = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(738, 79);
            label1.TabIndex = 2;
            label1.Text = "Công Thức Chuẩn Bị";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(375, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 371);
            panel1.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Right;
            btnDelete.Location = new Point(183, 250);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 60);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.Location = new Point(273, 250);
            button3.Name = "button3";
            button3.Size = new Size(90, 60);
            button3.TabIndex = 8;
            button3.Text = "Lưu Lại";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(90, 250);
            button2.Name = "button2";
            button2.Size = new Size(90, 60);
            button2.TabIndex = 7;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Left;
            btnAdd.Location = new Point(0, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 60);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 203);
            panel6.Name = "panel6";
            panel6.Size = new Size(363, 47);
            panel6.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtAmount);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 153);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 10, 0, 10);
            panel5.Size = new Size(363, 50);
            panel5.TabIndex = 4;
            // 
            // txtAmount
            // 
            txtAmount.Dock = DockStyle.Left;
            txtAmount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(120, 10);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(231, 30);
            txtAmount.TabIndex = 2;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 10);
            label4.Name = "label4";
            label4.Size = new Size(120, 30);
            label4.TabIndex = 1;
            label4.Text = "Số Lượng:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 103);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 10, 0, 10);
            panel4.Size = new Size(363, 50);
            panel4.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(129, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 10);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 1;
            label3.Text = "Nguyên Liệu:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblSize);
            panel3.Controls.Add(lblID);
            panel3.Controls.Add(lblProduct);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 103);
            panel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 15);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 5;
            label6.Text = "Mã: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 15);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 4;
            label5.Text = "Size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 52);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên Sản Phẩm:";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(222, 15);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(39, 20);
            lblSize.TabIndex = 2;
            lblSize.Text = "Size:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(62, 15);
            lblID.Name = "lblID";
            lblID.Size = new Size(37, 20);
            lblID.TabIndex = 1;
            lblID.Text = "Mã: ";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(129, 52);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(104, 20);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Tên Sản Phẩm:";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(363, 61);
            panel2.TabIndex = 1;
            // 
            // lsIngredient
            // 
            lsIngredient.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lsIngredient.FullRowSelect = true;
            lsIngredient.GridLines = true;
            lsIngredient.Location = new Point(8, 87);
            lsIngredient.Name = "lsIngredient";
            lsIngredient.Size = new Size(361, 351);
            lsIngredient.TabIndex = 10;
            lsIngredient.UseCompatibleStateImageBehavior = false;
            lsIngredient.View = View.Details;
            lsIngredient.SelectedIndexChanged += lsIngredient_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Nguyên Liệu";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số Lượng";
            columnHeader2.Width = 100;
            // 
            // fEditrPeparationRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 450);
            Controls.Add(lsIngredient);
            Controls.Add(panel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fEditrPeparationRecipe";
            Text = "Chỉnh Sửa Công Thức Chuẩn Bị";
            WindowState = FormWindowState.Minimized;
            Activated += fEditrPeparationRecipe_Activated;
            Load += fEditrPeparationRecipe_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtAmount;
        private Label label4;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button btnAdd;
        private Button btnDelete;
        private ComboBox comboBox1;
        private Label lblSize;
        private Label lblID;
        private Label lblProduct;
        private ToolTip toolTip1;
        private Label label5;
        private Label label2;
        private Label label6;
        private ListView lsIngredient;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}