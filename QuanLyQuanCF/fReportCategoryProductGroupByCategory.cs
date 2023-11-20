using Microsoft.Reporting.WinForms;
using QuanLyQuanCF.Models;
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

        ReportViewer reportViewer;
        public fReportCategoryProductGroupByCategory()
        {
            InitializeComponent();
        }

        private void fReportCategoryProductGroupByCategory_Load(object sender, EventArgs e)
        {
            reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };

            using (var db = new EFDbContext())
            {
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";
                cbCategory.DataSource = db.Category.Select(c => new { c.CategoryID, c.CategoryName }).ToList();
                cbCategory.Text = null;
            }



        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var db = new EFDbContext())
            {
                long categoryID = Convert.ToInt64(cbCategory.SelectedValue);

                reportViewer.Reset();



                reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("ds_View_CategoryProduct", db.Product.Where(p => p.CategoryID == categoryID || cbCategory.SelectedIndex < 0).Select((p => new
                {
                    p.CategoryID,
                    p.ProductID,
                    p.ProductName,

                    p.ProductSize,
                    p.Price,
                    p.Quantity,
                    p.Status,
                    CategoryId = p.CategoryID,
                    CategoryName = p.Category.CategoryName,
                    CategoryStatus = p.Category.Status
                })).ToList()));

                reportViewer.Dock = DockStyle.Fill;
                reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\rCategoryProduct.rdlc";
                Controls.Add(reportViewer);

                reportViewer.RefreshReport();
            }

        }
    }
}
