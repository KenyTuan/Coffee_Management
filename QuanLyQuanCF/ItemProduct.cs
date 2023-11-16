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
    public partial class ItemProduct : UserControl
    {
        public ItemProduct()
        {
            InitializeComponent();
        }

        #region Properties
        private String title;
        private decimal price;
        private String size;
        private String image;

        private void btnSelect_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(numCount.Text) * Convert.ToDecimal(lblPrice.Text);

            string[] result = { lblName.Text, lblSize.Text, numCount.Text,lblPrice.Text,total.ToString() };


            fManageOrderDetail.Instance.LsOrder.Items.Add(new ListViewItem(result));
            total += (fManageOrderDetail.Instance.Total.Text.IsNullOrEmpty())? 0 :Convert.ToDecimal(fManageOrderDetail.Instance.Total.Text) ;
            fManageOrderDetail.Instance.Total.Text = total.ToString() ;
        }

        [Category("Preparation Product")]
        public String Title
        {
            set { title = value; lblName.Text = value; }
            get { return title; }
        }

        [Category("Preparation Product")]
        public String SizeProduct
        {
            set { size = value; lblSize.Text = value; }
            get { return size; }
        }

        [Category("Preparation Product")]
        public decimal Price
        {
            set { size = value + ""; lblPrice.Text = value + ""; }
            get { return Convert.ToDecimal(size); }
        }

        [Category("Preparation Product")]
        public String Image
        {
            set { image = value; pbProduct.ImageLocation = value; }
            get { return image; }
        }


        #endregion

    }
}
