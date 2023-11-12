using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using QuanLyQuanCF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCF
{
    public partial class fEditProduct : Form
    {
        Product product;
        public long ProductID;
        EFDbContext db = new EFDbContext();


        public fEditProduct(long ProductID)
        {
            this.ProductID = ProductID;
            InitializeComponent();
        }

        private void fEditProduct_Load(object sender, EventArgs e)
        {
            product = db.Product.Include(p => p.Category).Single(p => p.ProductID == this.ProductID);

            txtID.Text = product.ProductID.ToString();
            txtName.Text = product.ProductName.ToString();
            cbSize.Text = product.ProductSize.ToString();
            mPrice.Text = product.Price.ToString();
            numQuantity.Text = product.Quantity.ToString();
            txtImage.Text = (string.IsNullOrWhiteSpace(product.ImageFile)) ? null : Utility.ImagePath + product.ImageFile;
            ckbStatus.Checked = product.Status;
            pictureBox1.ImageLocation = txtImage.Text;

            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "CategoryID";

            cbCategories.DataSource = db.Category.Select(c => new
            {
                c.CategoryID,
                c.CategoryName
            }).ToList();

            cbCategories.Text = product.Category.CategoryName;


        }

        private void fEditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    toolTip1.Show("Không Được để trống!", txtName, 0, 0, 1000);
                    return;
                }
                if (txtName.Text.Length > 255)
                {
                    toolTip1.Show("Không được quá 255?", txtName, 0, 0, 1000);
                    return;
                }
                if (string.IsNullOrWhiteSpace(mPrice.Text))
                {
                    toolTip1.Show("Không Được để trống!", mPrice, 0, 0, 1000);
                    return;
                }
                if (!Regex.IsMatch(mPrice.Text, @"^[-+]?[0-9]*.?[0-9]+$"))
                {
                    toolTip1.Show("Không hợp lệ?", mPrice, 0, 0, 1000);
                    return;
                }



                product.ProductName = txtName.Text;
                product.ProductSize = cbSize.Text;
                product.Price = Convert.ToDecimal(mPrice.Text);
                product.Quantity = (int)Convert.ToInt64(numQuantity.Value);
                product.Status = ckbStatus.Checked;
                product.CategoryID = Convert.ToInt64(cbCategories.SelectedValue);

                db.SaveChanges();
                int lastIndex = txtImage.Text.LastIndexOf(".");


                if (!string.IsNullOrWhiteSpace(txtImage.Text) && txtImage.Text != product.ImageFile && lastIndex > 0)
                {

                    string image = txtImage.Text.Substring(lastIndex, txtImage.Text.Length - lastIndex);


                    product.ImageFile = product.ProductID.ToString() + image;
                    pictureBox1.Image.Save(Utility.ImagePath + product.ImageFile);
                    db.SaveChanges();
                }

                MessageBox.Show("Lưu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại!", "Thông Báo", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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



    }
}
