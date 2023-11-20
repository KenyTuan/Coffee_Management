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
            menuLsOrder = new ToolStripMenuItem();
            menuCategory = new ToolStripMenuItem();
            MenuCustomer = new ToolStripMenuItem();
            menuEmployee = new ToolStripMenuItem();
            menuProduct = new ToolStripMenuItem();
            menuPreparationRecipe = new ToolStripMenuItem();
            menuIngredient = new ToolStripMenuItem();
            menuReport = new ToolStripMenuItem();
            menuReportProduct = new ToolStripMenuItem();
            menuReportIngredient = new ToolStripMenuItem();
            menuReportBill = new ToolStripMenuItem();
            menuOrderCustomer = new ToolStripMenuItem();
            MenuLogout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuSystem, menuLsOrder, menuCategory, menuReport, MenuLogout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(156, 486);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            menuSystem.AutoSize = false;
            menuSystem.Image = Properties.Resources.icon_Order;
            menuSystem.Margin = new Padding(0, 5, 0, 5);
            menuSystem.Name = "menuSystem";
            menuSystem.Size = new Size(150, 50);
            menuSystem.Text = "Gọi Món";
            menuSystem.Click += menuSystem_Click;
            // 
            // menuLsOrder
            // 
            menuLsOrder.AutoSize = false;
            menuLsOrder.Image = Properties.Resources.icon_Order11;
            menuLsOrder.Margin = new Padding(0, 5, 0, 5);
            menuLsOrder.Name = "menuLsOrder";
            menuLsOrder.Size = new Size(143, 50);
            menuLsOrder.Text = "Đơn Hàng";
            menuLsOrder.Click += menuOrder_Click;
            // 
            // menuCategory
            // 
            menuCategory.AutoSize = false;
            menuCategory.DropDownItems.AddRange(new ToolStripItem[] { MenuCustomer, menuEmployee, menuProduct, menuPreparationRecipe, menuIngredient });
            menuCategory.Image = Properties.Resources.icon_category;
            menuCategory.Margin = new Padding(0, 5, 0, 5);
            menuCategory.Name = "menuCategory";
            menuCategory.Size = new Size(150, 50);
            menuCategory.Text = "Danh Mục";
            // 
            // MenuCustomer
            // 
            MenuCustomer.AutoSize = false;
            MenuCustomer.Image = Properties.Resources.icon_ManageCustomer;
            MenuCustomer.Name = "MenuCustomer";
            MenuCustomer.Size = new Size(200, 35);
            MenuCustomer.Text = "Khách Hàng";
            MenuCustomer.Click += MenuCustomer_Click;
            // 
            // menuEmployee
            // 
            menuEmployee.AutoSize = false;
            menuEmployee.Image = Properties.Resources.icon_ManageEmployee;
            menuEmployee.Name = "menuEmployee";
            menuEmployee.Size = new Size(200, 35);
            menuEmployee.Text = "Nhân Viên";
            menuEmployee.Click += menuEmployee_Click;
            // 
            // menuProduct
            // 
            menuProduct.AutoSize = false;
            menuProduct.Image = Properties.Resources.icon_ManageProduct;
            menuProduct.Name = "menuProduct";
            menuProduct.Size = new Size(200, 35);
            menuProduct.Text = "Sản Phẩm";
            menuProduct.Click += menuProduct_Click;
            // 
            // menuPreparationRecipe
            // 
            menuPreparationRecipe.AutoSize = false;
            menuPreparationRecipe.Image = Properties.Resources.icon_preparation_recipe;
            menuPreparationRecipe.Name = "menuPreparationRecipe";
            menuPreparationRecipe.Size = new Size(200, 35);
            menuPreparationRecipe.Text = "Công Thức Chuẩn Bị";
            menuPreparationRecipe.Click += menuPreparationRecipe_Click;
            // 
            // menuIngredient
            // 
            menuIngredient.AutoSize = false;
            menuIngredient.Image = Properties.Resources.icon_Ingredient;
            menuIngredient.Name = "menuIngredient";
            menuIngredient.Size = new Size(200, 35);
            menuIngredient.Text = "Nguyên Liệu";
            menuIngredient.Click += menuIngredient_Click;
            // 
            // menuReport
            // 
            menuReport.AutoSize = false;
            menuReport.DropDownItems.AddRange(new ToolStripItem[] { menuReportProduct, menuReportIngredient, menuReportBill, menuOrderCustomer });
            menuReport.Image = Properties.Resources.icon_Report;
            menuReport.Margin = new Padding(0, 5, 0, 5);
            menuReport.Name = "menuReport";
            menuReport.Size = new Size(150, 50);
            menuReport.Text = "Báo Cáo";
            // 
            // menuReportProduct
            // 
            menuReportProduct.AutoSize = false;
            menuReportProduct.Name = "menuReportProduct";
            menuReportProduct.Size = new Size(200, 35);
            menuReportProduct.Text = "Sản Phẩm";
            menuReportProduct.Click += toolStripMenuItem1_Click;
            // 
            // menuReportIngredient
            // 
            menuReportIngredient.AutoSize = false;
            menuReportIngredient.Name = "menuReportIngredient";
            menuReportIngredient.Size = new Size(200, 35);
            menuReportIngredient.Text = "Nguyên Liệu";
            menuReportIngredient.Click += menuReportIngredient_Click;
            // 
            // menuReportBill
            // 
            menuReportBill.AutoSize = false;
            menuReportBill.Name = "menuReportBill";
            menuReportBill.Size = new Size(200, 35);
            menuReportBill.Text = "In Bill";
            menuReportBill.Click += menuReportBill_Click;
            // 
            // menuOrderCustomer
            // 
            menuOrderCustomer.AutoSize = false;
            menuOrderCustomer.Name = "menuOrderCustomer";
            menuOrderCustomer.Size = new Size(200, 35);
            menuOrderCustomer.Text = "Lịch Sử Đặt";
            menuOrderCustomer.Click += menuOrderCustomer_Click;
            // 
            // MenuLogout
            // 
            MenuLogout.AutoSize = false;
            MenuLogout.Image = Properties.Resources.icon_Logout;
            MenuLogout.Margin = new Padding(0, 5, 0, 5);
            MenuLogout.Name = "MenuLogout";
            MenuLogout.Size = new Size(150, 50);
            MenuLogout.Text = "Đăng Xuất";
            MenuLogout.Click += MenuLogout_Click;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 486);
            ControlBox = false;
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "fAdmin";
            Text = "Quán Coffee 86";
            WindowState = FormWindowState.Maximized;
            Load += fAdmin_Load;
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
        private ToolStripMenuItem menuLsOrder;
        private ToolStripMenuItem menuPreparationRecipe;
        private ToolStripMenuItem menuEmployee;
        private ToolStripMenuItem menuReport;
        private ToolStripMenuItem menuReportProduct;
        private ToolStripMenuItem menuIngredient;
        private ToolStripMenuItem menuReportIngredient;
        private ToolStripMenuItem menuReportBill;
        private ToolStripMenuItem menuOrderCustomer;
    }
}