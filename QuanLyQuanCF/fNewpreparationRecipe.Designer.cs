namespace QuanLyQuanCF
{
    partial class fNewpreparationRecipe
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
            btnDelete = new Button();
            button3 = new Button();
            btnAdd = new Button();
            panel6 = new Panel();
            panel5 = new Panel();
            textBox2 = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            comboBox1 = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            comboBox2 = new ComboBox();
            label2 = new Label();
            lblID = new Label();
            lblProduct = new Label();
            panel2 = new Panel();
            label1 = new Label();
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
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(437, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 371);
            panel1.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(123, 250);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 60);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.Location = new Point(240, 250);
            button3.Name = "button3";
            button3.Size = new Size(123, 60);
            button3.TabIndex = 8;
            button3.Text = "Lưu Lại";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Left;
            btnAdd.Location = new Point(0, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 60);
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
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 153);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 10, 0, 10);
            panel5.Size = new Size(363, 50);
            panel5.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Left;
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(120, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 30);
            textBox2.TabIndex = 2;
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
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblID);
            panel3.Controls.Add(lblProduct);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 103);
            panel3.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(62, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(128, 28);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 15);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Size:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(19, 15);
            lblID.Name = "lblID";
            lblID.Size = new Size(37, 20);
            lblID.TabIndex = 1;
            lblID.Text = "Mã: ";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(19, 51);
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
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 79);
            label1.TabIndex = 5;
            label1.Text = "Công Thức Chuẩn Bị";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lsIngredient
            // 
            lsIngredient.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lsIngredient.GridLines = true;
            lsIngredient.Location = new Point(12, 79);
            lsIngredient.Name = "lsIngredient";
            lsIngredient.Size = new Size(419, 359);
            lsIngredient.TabIndex = 7;
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
            // fNewpreparationRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsIngredient);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "fNewpreparationRecipe";
            Text = "Tạo Công Thức";
            Activated += fNewpreparationRecipe_Activated;
            Load += fNewpreparationRecipe_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDelete;
        private Button button3;
        private Button btnAdd;
        private Panel panel6;
        private Panel panel5;
        private TextBox textBox2;
        private Label label4;
        private Panel panel4;
        private ComboBox comboBox1;
        private Label label3;
        private Panel panel3;
        private ComboBox comboBox2;
        private Label label2;
        private Label lblID;
        private Label lblProduct;
        private Panel panel2;
        private Label label1;
        private ToolTip toolTip1;
        private ListView lsIngredient;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}