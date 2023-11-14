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
                var lsOrder = db.OrderDetails.Where(o => o.OrderID == OrderID).Select(od => new
                {
                    od.Quantity,
                    od.Price,
                    od.ProductID,
                }).ToList();


                var order = db.Orders.Where(o => o.OrderID == OrderID).Select(o => new
                {
                    o.OrderID,
                    o.Total,
                    o.Customer.NameCustomer,
                    o.Employee.EmployeeName,
                    o.OrderDate,
                    o.OrderTime,

                }).FirstOrDefault();

                lblID.Text = order.OrderID.ToString();
                lblNameCustomer.Text = order.NameCustomer.ToString();
                lblNameEmployee.Text = order.EmployeeName.ToString();
                lblDateOrder.Text = order.OrderDate.ToString();
                lblTime.Text = order.OrderTime.ToString();
                label2.Text = order.Total.ToString();



                foreach (var item in lsOrder)
                {
                    ListViewItem orderDetail = new ListViewItem();

                    var product = db.Product.Where(o => o.ProductID == item.ProductID).Select(o => new
                    {
                        o.ProductName,
                        o.ProductSize
                    }).First();


                    string[] subItem = { item.Quantity + "", product.ProductName, product.ProductSize, item.Price + "" };



                    lsDetail.Items.Add(new ListViewItem(subItem));
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
