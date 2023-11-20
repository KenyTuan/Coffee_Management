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
    public partial class fManagePreparationRecipe : Form
    {

        UserControl1 userControl1;
        public static string txtProduct;


        public fManagePreparationRecipe()
        {
            InitializeComponent();
            userControl1 = new UserControl1();
            txtProduct = (string.IsNullOrWhiteSpace(textBox1.Text)) ? "" : textBox1.Text;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewpreparationRecipe"))
                return;
            fNewpreparationRecipe f = new fNewpreparationRecipe();
            f.ShowDialog();
            fManagePreparationRecipe_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fManagePreparationRecipe_Load(sender, e);
        }

        public static void fManagePreparationRecipe_Load(object sender, EventArgs e)
        {

            using (var db = new EFDbContext())
            {
                var products = db.Product.Where(p => p.ProductName.Contains(txtProduct)).Select(p => new
                {
                    p.ProductID,
                    p.ProductName,
                    p.ProductSize,
                    p.ImageFile
                });
                var ingredientOrder = db.IngredientOrders.Select(
                    ig => new
                    {
                        ig.ProductID,
                        ig.IngredientOrderID,
                        ig.Product.ProductName,
                        ig.Product.ImageFile,
                        ig.Ingredient.IngredientName,
                        ig.Capacity,
                        ig.Amount
                    }).ToList();

                int i = 0;

                flowLayoutPanel1.Controls.Clear();
                UserControl1[] userControl1s = new UserControl1[products.Count()];
                foreach (var p in products)
                {
                    userControl1s[i] = new UserControl1();
                    userControl1s[i].Title = p.ProductName + " " + p.ProductSize;
                    userControl1s[i].Image = Utility.ImagePath + p.ImageFile;
                    userControl1s[i].IdProduct = p.ProductID;


                    foreach (var item in ingredientOrder)
                    {
                        if (item.ProductID == p.ProductID)
                        {
                            string[] data = new string[] { item.IngredientName, item.Amount.ToString() };


                            userControl1s[i].List = new ListViewItem(data);
                        }


                    }
                    flowLayoutPanel1.Controls.Add(userControl1s[i++]);

                }

            }


        }
    }
}
