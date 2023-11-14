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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCF
{
    public partial class fEditrPeparationRecipe : Form
    {
        EFDbContext EFDbContext;
        long id;
        List<IngredientOrder> ingredientOrders;

        Product product;

        public fEditrPeparationRecipe(long id)
        {
            InitializeComponent();
            EFDbContext = new EFDbContext();
            this.id = id;

            product = EFDbContext.Product.Single(p => p.ProductID == id);
            ingredientOrders = EFDbContext.IngredientOrders.Where(i => i.ProductID == product.ProductID).ToList();
        }

        private void fEditrPeparationRecipe_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "IngredientName";
            comboBox1.ValueMember = "IngredientID";
            comboBox1.DataSource = EFDbContext.Ingredients.Select(io => new { io.IngredientID, io.IngredientName }).ToList();

            lblID.Text = id.ToString();
            lblProduct.Text = product.ProductName;
            lblSize.Text = product.ProductSize;

            foreach (var item in ingredientOrders)
            {
                Ingredient ingredient = EFDbContext.Ingredients.Single(i => i.IngredientID == item.IngredientID);
                string[] array = new string[] { ingredient.IngredientName, ingredient.Amount + "" };
                lsIngredient.Items.Add(new ListViewItem(array));

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                toolTip1.Show("Bạn quên nhập!", txtAmount, 0, 0, 1000);
                return;
            }
            if (!Regex.IsMatch(txtAmount.Text, @"^\d+$"))
            {
                toolTip1.Show("Bạn cần nhập số nguyên", txtAmount, 0, 0, 1000);
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                toolTip1.Show("Bạn Quên Chọn Sản Phẩm!", comboBox1, 0, 0, 1000);
                return;
            }

            string[] row = new string[] { comboBox1.Text, txtAmount.Text };

            lsIngredient.Items.Add(new ListViewItem(row));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsIngredient.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lsIngredient.SelectedItems.Count; i++)
                {
                    ListViewItem select = lsIngredient.SelectedItems[i];

                    lsIngredient.Items.Remove(select);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn hoặc kéo chọn để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lsIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lsIngredient_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            txtAmount.Text = lsIngredient.Items[e.Index].SubItems[1].Text;
            comboBox1.Text = lsIngredient.Items[e.Index].SubItems[0].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
