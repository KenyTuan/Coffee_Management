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
    public partial class fReportCustomerOrder : Form
    {
        EFDbContext db = new EFDbContext();

        ReportViewer reportViewer;
        public fReportCustomerOrder()
        {
            InitializeComponent();
        }

        private void fReportCustomerOrder_Load(object sender, EventArgs e)
        {

            reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };

            using (var db = new EFDbContext())
            {
                cbOrder.DisplayMember = "OrderID";
                cbOrder.ValueMember = "OrderID";
                cbOrder.DataSource = db.Orders.Select(c => new { c.OrderID }).OrderByDescending(c => c.OrderID).ToList();
            }


        }

        private void cbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            long OrderID = Convert.ToInt64(cbOrder.SelectedValue);

            reportViewer.Reset();


            reportViewer.LocalReport.DataSources.Add(
            new ReportDataSource("ds_View_CustomerOrderProduct", db.OrderDetails.Where(p => p.OrderID == OrderID || cbOrder.SelectedIndex < 0).Select((p => new
            {
                OrderID,
                p.Order.Customer.NameCustomer,
                p.Order.Employee.EmployeeName,
                p.Order.OrderDate,
                p.Order.OrderTime,
                p.Product.ProductName,
                p.Product.ProductSize,
                p.Product.Price,
                p.Quantity,
            })).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\rOrder.rdlc";
            Controls.Add(reportViewer);

            reportViewer.RefreshReport();
        }
    }
}
