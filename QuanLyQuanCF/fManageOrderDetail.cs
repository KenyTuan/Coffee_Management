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

namespace QuanLyQuanCF
{
    public partial class fManageOrderDetail : Form
    {
        ItemProduct[] item_product;
        EFDbContext db;
        string txtName;
        System.Windows.Forms.Timer timer;
        static fManageOrderDetail _obj;

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

        public ListView LsOrder
        {
            get { return lsOrder; }
            set { lsOrder = value; }
        }

        public TextBox Total
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
            lsOrder.Items.Clear();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

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

                flowLayoutPanel1.Controls.Add(item_product[i++]);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mtbDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
