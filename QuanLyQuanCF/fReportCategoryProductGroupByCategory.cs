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
                new ReportDataSource("ds_View_CategoryProduct", db.Product.Select((p => new
                {
                    p.CategoryID,
                    p.ProductID,
                    p.ProductName,
                    CategoryName = p.Category.CategoryName,
                    CategoryStatus = p.Category.Status,
                    p.ProductSize,
                    p.Price,
                    p.Quantity,
                    p.Status
                })).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\rCategoryProduct.rdlc";
            Controls.Add(reportViewer);

            reportViewer.RefreshReport();

        }
    }
}
