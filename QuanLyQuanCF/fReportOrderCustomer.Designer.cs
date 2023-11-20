namespace QuanLyQuanCF
{
    partial class fReportOrderCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReportOrderCustomer));
            cbCustomer = new ComboBox();
            SuspendLayout();
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(625, 21);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(151, 28);
            cbCustomer.TabIndex = 0;
            cbCustomer.SelectedIndexChanged += cbCustomer_SelectedIndexChanged;
            // 
            // fReportOrderCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbCustomer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fReportOrderCustomer";
            Text = "Danh sách đơn hàng Của Khách Hang";
            WindowState = FormWindowState.Maximized;
            Load += fReportOrderCustomer_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbCustomer;
    }
}