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
    public partial class fReportCustomerOrder : Form
    {
        EFDbContext db = new EFDbContext();
        public fReportCustomerOrder()
        {
            InitializeComponent();
        }

        private void fReportCustomerOrder_Load(object sender, EventArgs e)
        {

            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };

            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("ds_View_Ingredient", db.Ingredients.Select((p => new
                {
                    p.IngredientID,
                    p.IngredientName,
                    p.Amount,
                    p.Status
                })).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\rIngdient.rdlc";
            Controls.Add(reportViewer);

            reportViewer.RefreshReport();
        }
    }
}
