using Microsoft.IdentityModel.Tokens;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCF
{
    public partial class fManageOrderDetail : Form
    {
        ItemProduct[] item_product;
        EFDbContext db;
        string txtName;

        System.Windows.Forms.Timer timer;
        static fManageOrderDetail _obj;

        Order Order;
        OrderDetail orderDetail;
        EFDbContext context = new EFDbContext();

        public static fManageOrderDetail Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new fManageOrderDetail();
                }
                return _obj;

            }

        }

        public System.Windows.Forms.ListView LsOrder
        {
            get { return lsOrder; }
            set { lsOrder = value; }
        }

        public System.Windows.Forms.TextBox Total
        {
            get { return txtTotal; }
            set { txtTotal = value; }
        }



        public fManageOrderDetail()
        {
            db = new EFDbContext();
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;

            timer.Start();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            txtName = textBox1.Text;
            fManageOrderDetail_Load(sender, e);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            fManageOrderDetail_Load(sender, e);
           
            txtTotal.Text = null;
            lsOrder.Items.Clear();
            txtNameCustomer.Text = null;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty( txtNameCustomer.Text))
                {
                    toolTip1.Show("Bạn quên chọn thành viên", txtNameCustomer, 0, 0,
               1000);
                    return;
                }
                if (lsOrder.Items.Count < 0)
                {
                    toolTip1.Show("Bạn vẫn chưa chọn món!", lsOrder, 0, 0,
               1000);
                    return;
                }

                Order = new Order();
                Order.Total = Convert.ToDecimal(txtTotal.Text);
                Order.CustomerID = Convert.ToInt64(cbCustomer.SelectedValue);
                Order.EmployeeID = 1;
                Order.OrderDate = DateTime.Now.Date;
                Order.OrderTime = DateTime.Now.TimeOfDay;
                using (EFDbContext db = new EFDbContext())
                {
                    db.Orders.Add(Order);
                    db.SaveChanges();
                }

                using (var db = new EFDbContext())
                {
                    for (int i = 0; i < lsOrder.Items.Count; i++)
                    {
                        orderDetail = new OrderDetail();
                        orderDetail.Price = Convert.ToDecimal(lsOrder.Items[i].SubItems[3].Text);
                        orderDetail.Quantity = Convert.ToInt32(lsOrder.Items[i].SubItems[2].Text);

                        orderDetail.ProductID = db.Product.Single(p => p.ProductName.Contains(lsOrder.Items[i].SubItems[0].Text) && p.ProductSize.Contains(lsOrder.Items[i].SubItems[1].Text)).ProductID;
                        orderDetail.OrderID = db.Orders.ToArray().Last().OrderID;
                        db.OrderDetails.Add(orderDetail);
                        db.SaveChanges();


                    }
                    lsOrder.Items.Clear();
                }

                Customer customer = context.Customers.Single(c => c.NameCustomer.Contains(txtNameCustomer.Text));
                customer.Point = customer.Point + (int)Convert.ToDecimal(txtTotal.Text.Trim());
                context.SaveChanges();
                toolTip1.Show("Lưu thành Công", btnPay, 0, 0,
               1000);
                fManageOrderDetail_Load(sender,e);
                txtTotal.Text = null;
                lsOrder.Items.Clear();
                txtNameCustomer.Text = null;

            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnPay, 0, 0,
               1000);
            }
        }

        private void fManageOrderDetail_Load(object sender, EventArgs e)
        {

            _obj = this;

            flowLayoutPanel1.Controls.Clear();
            List<Product> product = db.Product.Where(p => p.ProductName.Contains((!txtName.IsNullOrEmpty()) ? txtName : "")).ToList();
            int i = 0;
            item_product = new ItemProduct[product.Count()];
            foreach (Product productItem in product)
            {
                item_product[i] = new ItemProduct();

                item_product[i].Title = productItem.ProductName;
                item_product[i].Price = productItem.Price;
                item_product[i].SizeProduct = productItem.ProductSize;
                item_product[i].Image = Utility.ImagePath + productItem.ImageFile;
                item_product[i].Count = productItem.Quantity;

                flowLayoutPanel1.Controls.Add(item_product[i++]);
            }

            cbCustomer.DisplayMember = "NameCustomer";
            cbCustomer.ValueMember = "CustomerID";

            cbCustomer.DataSource = db.Customers.Select(a => new { a.CustomerID, a.NameCustomer }).ToList();




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mtbDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtNameCustomer.Text = cbCustomer.Text;
        }


    }
}
