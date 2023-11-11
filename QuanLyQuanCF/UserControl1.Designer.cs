namespace QuanLyQuanCF
{
    partial class UserControl1
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
            lsIngredient = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel2 = new Panel();
            lblName = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(pbProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 43);
            panel1.TabIndex = 0;
            // 
            // pbProduct
            // 
            pbProduct.Dock = DockStyle.Fill;
            pbProduct.Location = new Point(0, 0);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(286, 43);
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            // 
            // lsIngredient
            // 
            lsIngredient.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lsIngredient.Dock = DockStyle.Fill;
            lsIngredient.GridLines = true;
            lsIngredient.Location = new Point(0, 0);
            lsIngredient.Name = "lsIngredient";
            lsIngredient.Size = new Size(286, 148);
            lsIngredient.TabIndex = 1;
            lsIngredient.UseCompatibleStateImageBehavior = false;
            lsIngredient.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nguyên Liệu";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số Lượng";
            columnHeader2.Width = 80;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsIngredient);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 148);
            panel2.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(286, 43);
            lblName.TabIndex = 0;
            lblName.Text = "Sản Phẩm";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 107);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnEdit);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 304);
            panel4.Name = "panel4";
            panel4.Size = new Size(286, 55);
            panel4.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Right;
            btnDelete.Location = new Point(143, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 55);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Left;
            btnEdit.Location = new Point(0, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(143, 55);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(panel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(286, 359);
            panel5.TabIndex = 4;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Name = "UserControl1";
            Size = new Size(286, 359);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbProduct;
        private ListView lsIngredient;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panel2;
        private Panel panel3;
        private Label lblName;
        private Panel panel4;
        private Button btnDelete;
        private Button btnEdit;
        private Panel panel5;
    }
}
