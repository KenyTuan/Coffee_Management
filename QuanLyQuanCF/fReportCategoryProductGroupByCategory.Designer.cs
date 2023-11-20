namespace QuanLyQuanCF
{
    partial class fReportCategoryProductGroupByCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReportCategoryProductGroupByCategory));
            cbCategory = new ComboBox();
            SuspendLayout();
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(585, 2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 1;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // fReportCategoryProductGroupByCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbCategory);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fReportCategoryProductGroupByCategory";
            Text = "Xuất Danh Sách Sản Phẩm";
            WindowState = FormWindowState.Maximized;
            Load += fReportCategoryProductGroupByCategory_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbCategory;
    }
}