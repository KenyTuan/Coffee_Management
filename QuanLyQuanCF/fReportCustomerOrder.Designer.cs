﻿namespace QuanLyQuanCF
{
    partial class fReportCustomerOrder
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
            cbOrder = new ComboBox();
            SuspendLayout();
            // 
            // cbOrder
            // 
            cbOrder.FormattingEnabled = true;
            cbOrder.Location = new Point(637, 31);
            cbOrder.Name = "cbOrder";
            cbOrder.Size = new Size(151, 28);
            cbOrder.TabIndex = 0;
            cbOrder.SelectedIndexChanged += cbOrder_SelectedIndexChanged;
            // 
            // fReportCustomerOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbOrder);
            Name = "fReportCustomerOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa Đơn";
            WindowState = FormWindowState.Maximized;
            Load += fReportCustomerOrder_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbOrder;
    }
}