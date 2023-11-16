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
    public partial class fNewProduct : Form
    {
        Product product;

        public fNewProduct()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All file|*.*|Bitmap File | *.bmp; *.dib | JPEG | *.jpg; *.jpe; *.jpeg; *.jfif | GIF | *.gif | TIFF | *.tif; *.tiff | PNG | *.png | ICO | *.ico";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                product = new Product();
                product.ProductName = txtName.Text;
                product.ProductSize = cbSize.Text;
                product.Price = Convert.ToDecimal(mPrice.Text);
                product.Quantity = (int)Convert.ToInt64(numQuantity.Value);
                product.Status = ckbStatus.Checked;
                product.CategoryID = Convert.ToInt64(cbCategories.SelectedValue);
                using (var db = new EFDbContext())
                {
                    db.Product.Add(product);
                    db.SaveChanges();

                    if (!string.IsNullOrWhiteSpace(txtImage.Text))
                    {

                        string image = txtImage.Text.Substring(txtImage.Text.LastIndexOf("."), txtImage.Text.Length - txtImage.Text.LastIndexOf("."));

                        product.ImageFile = product.ProductID + image;
                        pictureBox1.Image.Save(Utility.ImagePath + product.ProductID + image);
                        db.SaveChanges();

                    }
                }



                toolTip1.Show("Lưu thành công.", btnSave, 0, 0, 1000);
                Close();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnSave, 0, 0,
              1000);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fNewProduct_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                cbCategories.DisplayMember = "CategoryName";
                cbCategories.ValueMember = "CategoryID";
                cbCategories.DataSource = db.Category.Select(c => new { c.CategoryID, c.CategoryName }).ToList();
                cbSize.SelectedIndex = 0;

            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            if (txtName.Text.Length > 255)
            {
                toolTip1.Show("Tên sản phẩm đã dài hơn 255 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }


        private void fNewProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;

        }

        private void mPrice_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu số thực?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
            else
            if ((decimal)e.ReturnValue < 0)
            {
                toolTip1.Show("Giá không được nhỏ hơn 1?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
        }
    }
}
