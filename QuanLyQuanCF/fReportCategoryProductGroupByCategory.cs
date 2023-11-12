using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCF
{
    public partial class fReportCategoryProductGroupByCategory : Form
    {
        EFDbContext db = new EFDbContext();
        public fReportCategoryProductGroupByCategory()
        {
            InitializeComponent();
        }

        private void fReportCategoryProductGroupByCategory_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };

            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("view_CategoryProduct", db.Product.Select((p => new
                {
                    p.ProductID,
                    p.ProductName,
                    p.Quantity,
                    p.Price,
                    p.ProductSize,
                    p.Category.CategoryName
                })).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\rCategoryProduct.rdlc";
            Controls.Add(reportViewer);

            reportViewer.RefreshReport();

        }
    }
}
