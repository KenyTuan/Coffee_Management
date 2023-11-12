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
    public partial class fShowDetailOrder : Form
    {
        long OrderID;
        public fShowDetailOrder(long OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;
        }

        private void fShowDetailOrder_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                Order order = db.Orders
                 .Where(o => o.OrderID == OrderID)
                 .Select(o => new Order
                 {
                     OrderID = o.OrderID,
                     Customer = new Customer { NameCustomer = o.Customer.NameCustomer },
                     Employee = new Employee { EmployeeName = o.Employee.EmployeeName },
                     OrderDate = o.OrderDate,
                     Total = o.Total,
                     OrderTime = o.OrderTime
                 })
                 .FirstOrDefault();

                lblID.Text = order.OrderID.ToString();
                lblNameCustomer.Text = order.Customer.NameCustomer.ToString();
                lblNameEmployee.Text = order.Employee.EmployeeName.ToString();
                lblDateOrder.Text = order.OrderDate.ToString();
                lblTime.Text = order.OrderTime.ToString();

                var lsOrder = db.OrderDetails.Where(o => o.OrderID == OrderID).Select(o =>
                    new
                    {
                        o.Product.ProductName,
                        o.Product.ProductSize,
                        o.Product.Price,
                        o.Quantity
                    }).ToList();



                foreach (var item in lsOrder)
                {
                    ListViewItem orderDetail = new ListViewItem();

                    orderDetail.SubItems[0].Text = item.Quantity + "";
                    orderDetail.SubItems[1].Text = item.ProductName;
                    orderDetail.SubItems[2].Text = item.ProductSize;
                    orderDetail.SubItems[3].Text = item.Price + "";




                    lsDetail.Items.Add(orderDetail);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
