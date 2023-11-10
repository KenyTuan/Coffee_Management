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
using System.Xml.Linq;

namespace QuanLyQuanCF
{
    public partial class fManageProduct : Form
    {

        public string CategoryName;

        public fManageProduct()
        {
            InitializeComponent();
        }


        private void fManageProduct_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                foreach (var item in db.Category.Select(c => new { c.CategoryName }).ToList())
                {
                    cbCategories.Items.Add(item.CategoryName);
                }
                cbCategories.SelectedIndex = 0;
            }
        }

        private void fManageProduct_Activated(object sender, EventArgs e)
        {
            cbCategories_SelectedIndexChanged(sender, e);
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                CategoryName = (cbCategories.Text == "Tất cả") ? "" : cbCategories.Text;
                dataGridView2.DataSource = db.Product.Where(p => p.Category.CategoryName.Contains(CategoryName)).Select(p => new
                {
                    p.ProductID,
                    p.ProductName,
                    p.ProductSize,
                    p.Category.CategoryName,
                    p.Quantity,
                    p.Price,
                    p.ImageFile,
                    p.Status
                }).ToList();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView2.DataSource = db.Product.Where(p =>
                p.ProductName.Contains(txtName.Text)).Select(p => new
                {
                    p.ProductID,
                    p.ProductName,
                    p.ProductSize,
                    p.Category.CategoryName,
                    p.Quantity,
                    p.Price,
                    p.ImageFile,
                    p.Status
                }).ToList();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewProduct"))
                return;
            fNewProduct f = new fNewProduct();
            f.ShowDialog();
            fManageProduct_Activated(sender, e);
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long ProductID =
                   Convert.ToInt64(dataGridView2.Rows[e.RowIndex].Cells["ProductID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Product product = db.Product.Single(c => c.ProductID == ProductID);
                        if (MessageBox.Show("Bạn muốn xóa sản phẩm " + product.ProductName, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Product.Remove(product);
                            db.SaveChanges();
                            fManageProduct_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditProduct"))
                    return;
                fEditProduct f = new fEditProduct(Convert.ToInt64(dataGridView2.Rows[e.RowIndex].Cells["ProductID"].Value));
                f.ShowDialog();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.ImageLocation = Utility.ImagePath + dataGridView2.Rows[e.RowIndex].Cells["ImageFile"].Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
