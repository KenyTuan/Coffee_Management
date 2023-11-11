namespace QuanLyQuanCF
{
    partial class itemPreparationRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemPreparationRecipe));
            ListViewItem listViewItem2 = new ListViewItem("Hạt Cafe");
            imgProduct = new PictureBox();
            lsIngredient = new ListView();
            colum1 = new ColumnHeader();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)imgProduct).BeginInit();
            SuspendLayout();
            // 
            // imgProduct
            // 
            imgProduct.Dock = DockStyle.Top;
            imgProduct.ErrorImage = null;
            imgProduct.Image = (Image)resources.GetObject("imgProduct.Image");
            imgProduct.Location = new Point(0, 0);
            imgProduct.Name = "imgProduct";
            imgProduct.Size = new Size(250, 150);
            imgProduct.TabIndex = 0;
            imgProduct.TabStop = false;
            // 
            // lsIngredient
            // 
            lsIngredient.Columns.AddRange(new ColumnHeader[] { colum1 });
            lsIngredient.Dock = DockStyle.Top;
            lsIngredient.Enabled = false;
            lsIngredient.Items.AddRange(new ListViewItem[] { listViewItem2 });
            lsIngredient.Location = new Point(0, 150);
            lsIngredient.Name = "lsIngredient";
            lsIngredient.Size = new Size(250, 189);
            lsIngredient.TabIndex = 1;
            lsIngredient.UseCompatibleStateImageBehavior = false;
            lsIngredient.View = View.Details;
            // 
            // colum1
            // 
            colum1.Text = "colum1";
            colum1.Width = 180;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ControlLight;
            btnEdit.Dock = DockStyle.Left;
            btnEdit.Location = new Point(0, 339);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 41);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLight;
            btnDelete.Dock = DockStyle.Right;
            btnDelete.Location = new Point(125, 339);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 41);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // itemPreparationRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lsIngredient);
            Controls.Add(imgProduct);
            Name = "itemPreparationRecipe";
            Size = new Size(250, 380);
            ((System.ComponentModel.ISupportInitialize)imgProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgProduct;
        private ListView lsIngredient;
        private ColumnHeader colum1;
        private Button btnEdit;
        private Button btnDelete;
    }
}
