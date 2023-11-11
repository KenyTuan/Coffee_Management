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
        public fManagePreparationRecipe()
        {
            InitializeComponent();
            userControl1 = new UserControl1();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fManagePreparationRecipe_Load(object sender, EventArgs e)
        {

            using (var db = new EFDbContext())
            {
                var products = db.Product.Select(p => new
                {
                    p.ProductID,
                    p.ProductName,
                    p.ImageFile
                });

                var ingredientOrder = db.IngredientOrders.Select(
                    i => new
                    {
                        i.ProductID,
                        i.IngredientOrderID,
                        i.Product.ProductName,
                        i.Product.ImageFile,
                        i.Ingredient.IngredientName,
                        i.Capacity,

                    }).OrderBy(i => i.ProductID).ToList();

                UserControl1[] userControl1s = new UserControl1[products.Count()];
                int i = 0;
                foreach (var p in products)
                {
                    userControl1s[i] = new UserControl1();
                    userControl1s[i].Title = p.ProductName;
                    userControl1s[i].Image = Utility.ImagePath + p.ImageFile;

                    foreach (var ig in ingredientOrder)
                    {
                        if (p.ProductID == ig.ProductID)
                        {
                            string[] result = { ig.IngredientName, ig.Capacity + "" };
                            userControl1s[i].List = new ListViewItem(result);
                        }
                        else
                        {
                            flowLayoutPanel1.Controls.Add(userControl1s[i++]);
                            break;
                        }
                    }
                }

            }


        }
    }
}
