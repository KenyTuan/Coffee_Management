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
    public partial class fReportOrderCustomer : Form
    {
        EFDbContext db = new EFDbContext();

        ReportViewer reportViewer;
        public fReportOrderCustomer()
        {
            InitializeComponent();
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            long OrderID = Convert.ToInt64(cbCustomer.SelectedValue);

            reportViewer.Reset();


            reportViewer.LocalReport.DataSources.Add(
            new ReportDataSource("ds_View_OrderCustomer", db.OrderDetails.Where(p => p.Order.CustomerID == OrderID || cbCustomer.SelectedIndex < 0).Select((p => new
            {
                p.OrderID,
                p.Order.Customer.NameCustomer,
                p.Product.ProductName,
                p.Product.ProductSize,
                p.Product.Price,
                p.Quantity,
            })).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\rCustomerOrder.rdlc";
            Controls.Add(reportViewer);

            reportViewer.RefreshReport();
        }

        private void fReportOrderCustomer_Load(object sender, EventArgs e)
        {
            reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };

            using (var db = new EFDbContext())
            {
                cbCustomer.DisplayMember = "NameCustomer";
                cbCustomer.ValueMember = "CustomerID";
                cbCustomer.DataSource = db.Customers.Select(c => new { c.CustomerID,c.NameCustomer }).ToList();
            }
        }
    }
}
