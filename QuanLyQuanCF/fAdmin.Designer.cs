namespace QuanLyQuanCF
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            menuStrip1 = new MenuStrip();
            menuSystem = new ToolStripMenuItem();
            menuCategory = new ToolStripMenuItem();
            MenuCustomer = new ToolStripMenuItem();
            menuProduct = new ToolStripMenuItem();
            menuIngredient = new ToolStripMenuItem();
            MenuLogout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuSystem, menuCategory, MenuLogout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1136, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            menuSystem.AutoSize = false;
            menuSystem.Image = Properties.Resources.icon_System;
            menuSystem.Name = "menuSystem";
            menuSystem.Size = new Size(150, 25);
            menuSystem.Text = "Hệ Thống";
            // 
            // menuCategory
            // 
            menuCategory.AutoSize = false;
            menuCategory.DropDownItems.AddRange(new ToolStripItem[] { MenuCustomer, menuProduct, menuIngredient });
            menuCategory.Image = Properties.Resources.icon_category;
            menuCategory.Name = "menuCategory";
            menuCategory.Size = new Size(150, 25);
            menuCategory.Text = "Danh Mục";
            // 
            // MenuCustomer
            // 
            MenuCustomer.Image = Properties.Resources.icon_ManageCustomer;
            MenuCustomer.Name = "MenuCustomer";
            MenuCustomer.Size = new Size(224, 26);
            MenuCustomer.Text = "Khách Hàng";
            MenuCustomer.Click += MenuCustomer_Click;
            // 
            // menuProduct
            // 
            menuProduct.Image = Properties.Resources.icon_ManageProduct;
            menuProduct.Name = "menuProduct";
            menuProduct.Size = new Size(224, 26);
            menuProduct.Text = "Sản Phẩm";
            menuProduct.Click += menuProduct_Click;
            // 
            // menuIngredient
            // 
            menuIngredient.Image = Properties.Resources.icon_Ingredient;
            menuIngredient.Name = "menuIngredient";
            menuIngredient.Size = new Size(224, 26);
            menuIngredient.Text = "Nguyên Liệu";
            menuIngredient.Click += menuIngredient_Click;
            // 
            // MenuLogout
            // 
            MenuLogout.AutoSize = false;
            MenuLogout.Image = Properties.Resources.icon_Logout;
            MenuLogout.Name = "MenuLogout";
            MenuLogout.Size = new Size(150, 25);
            MenuLogout.Text = "Đăng Xuất";
            MenuLogout.Click += MenuLogout_Click;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 450);
            ControlBox = false;
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "fAdmin";
            Text = "Quán Coffee 86";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuSystem;
        private ToolStripMenuItem menuCategory;
        private ToolStripMenuItem MenuCustomer;
        private ToolStripMenuItem menuProduct;
        private ToolStripMenuItem MenuLogout;
        private ToolStripMenuItem menuIngredient;
    }
}