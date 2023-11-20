using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.Logging;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCF
{
    public partial class fEditrPeparationRecipe : Form
    {
        EFDbContext EFDbContext = new EFDbContext();
        long id;

        int indexSelected;

        Product product;

        static fEditrPeparationRecipe _obj;
        List<IngredientOrder> ingredientOrders;
        public static fEditrPeparationRecipe Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new fEditrPeparationRecipe();
                }
                return _obj;

            }

        }

        public fEditrPeparationRecipe(long id)
        {
            InitializeComponent();
            this.id = id;
            indexSelected = 0;



        }

        public fEditrPeparationRecipe()
        {
        }

        private void fEditrPeparationRecipe_Load(object sender, EventArgs e)
        {

            product = EFDbContext.Product.Single(p => p.ProductID == id);

            ingredientOrders = EFDbContext.IngredientOrders.Where(i => i.ProductID == product.ProductID).ToList();

            lblID.Text = id.ToString();
            lblProduct.Text = product.ProductName;
            lblSize.Text = product.ProductSize;

            foreach (var item in ingredientOrders)
            {
                decimal amount = item.Amount;
                Ingredient ingredient = EFDbContext.Ingredients.Single(i => i.IngredientID == item.IngredientID);
                string[] array = new string[] { ingredient.IngredientName, amount + "" };
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
            decimal number;
            if (!decimal.TryParse(txtAmount.Text, out number) && number < 0)
            {
                toolTip1.Show("Không hợp lệ", txtAmount, 0, 0, 1000);
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                toolTip1.Show("Bạn Quên Chọn Sản Phẩm!", comboBox1, 0, 0, 1000);
                return;
            }

            string[] row = new string[] { comboBox1.Text, txtAmount.Text };

            lsIngredient.Items.Add(new ListViewItem(row));

            fEditrPeparationRecipe_Activated(sender, e);
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

                fEditrPeparationRecipe_Activated(sender, e);

            }
            else
            {
                MessageBox.Show("Bạn cần chọn hoặc kéo chọn để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsIngredient.Items.Count < 0)
                {
                    MessageBox.Show("Bạn chưa thêm số lượng nguyên liệu pha chế", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


                int min = int.MaxValue;

                List<IngredientOrder> updatedIngredientOrders = new List<IngredientOrder>();
                int i = 0;

                

                foreach (var item in ingredientOrders)
                {
                    bool check = false;
                    if (i < lsIngredient.Items.Count) { 
                        var ingredient = EFDbContext.Ingredients.Single(o => o.IngredientName.Contains(lsIngredient.Items[i].SubItems[0].Text));

                        if(ingredient != null)
                        {

                            item.ProductID = Convert.ToInt32(lblID.Text);

                            item.Amount = Convert.ToDecimal(lsIngredient.Items[i].SubItems[1].Text);

                            item.IngredientID = ingredient.IngredientID;

                            item.Capacity = Convert.ToDecimal(ingredient.Amount);

                            int quantity = (int)(ingredient.Amount / Convert.ToDecimal(lsIngredient.Items[i].SubItems[1].Text));

                            if (quantity < min)
                            {

                                min = quantity;

                            }
                            EFDbContext.IngredientOrders.Update(item);
                            EFDbContext.SaveChanges();
                            i++;

                        }


                    }
                    else
                    {
                        updatedIngredientOrders.Add(item);

                    }
                }
                if (!updatedIngredientOrders.IsNullOrEmpty())
                {
                    foreach (var item in updatedIngredientOrders)
                    {
                        EFDbContext.IngredientOrders.Remove(item);
                        EFDbContext.SaveChanges();
                    }
                }
                IngredientOrder ingredientOrder = new IngredientOrder();
                if (lsIngredient.Items.Count > ingredientOrders.Count)
                {

                    for (int j = ingredientOrders.Count; j < lsIngredient.Items.Count; j++)
                    {
                        var ingredient = new Ingredient();
                        ingredientOrder.ProductID = Convert.ToInt32(lblID.Text);


                        ingredient = EFDbContext.Ingredients.Single(o => o.IngredientName.Contains(lsIngredient.Items[i].SubItems[0].Text));

                        ingredientOrder.Amount = Convert.ToDecimal(lsIngredient.Items[i].SubItems[1].Text);
                        ingredientOrder.IngredientID = ingredient.IngredientID;

                        ingredientOrder.Capacity = Convert.ToDecimal(ingredient.Amount);
                        int quantity = (int)(ingredientOrder.Amount / Convert.ToDecimal(lsIngredient.Items[i].SubItems[1].Text));
                        if (ingredientOrder.Amount < min)
                        {
                            min = (int)ingredientOrder.Amount;
                        }
                        using (var db = new EFDbContext())
                        {
                            db.IngredientOrders.Add(ingredientOrder);
                            db.SaveChanges();
                        }
                    }
                }


                if (min != int.MaxValue)
                {
                    product.Quantity = min;
                    EFDbContext.SaveChanges();
                    MessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK);

                    Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật số lượng sản phẩm", "Thông Báo", MessageBoxButtons.OK);
                }


            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Lưu Thất Bại: " + ex.InnerException.Message, "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu Thất Bại" + ex, "Thông Báo", MessageBoxButtons.OK);

            }

        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                toolTip1.Show("Bạn quên nhập!", txtAmount, 0, 0, 1000);
                return;
            }
            decimal number;
            if (!decimal.TryParse(txtAmount.Text, out number) && number < 0)
            {
                toolTip1.Show("Không hợp lệ", txtAmount, 0, 0, 1000);
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                toolTip1.Show("Bạn Quên Chọn Sản Phẩm!", comboBox1, 0, 0, 1000);
                return;
            }

            lsIngredient.Items[indexSelected].SubItems[0].Text = comboBox1.Text;
            lsIngredient.Items[indexSelected].SubItems[1].Text = txtAmount.Text;
            fEditrPeparationRecipe_Activated(sender, e);
            

        }

        private void lsIngredient_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }

        private void fEditrPeparationRecipe_Activated(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "IngredientName";
            comboBox1.ValueMember = "IngredientID";
            var ingredients = EFDbContext.Ingredients.Select(io => new { io.IngredientID, io.IngredientName }).ToList();
            var remainingIngredients = new List<object>();

            foreach (var i in ingredients)
            {
                bool isFound = false;

                for (int j = 0; j < lsIngredient.Items.Count; j++)
                {
                    if (string.Equals(i.IngredientName, lsIngredient.Items[j].SubItems[0].Text, StringComparison.OrdinalIgnoreCase))
                    {
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    remainingIngredients.Add(i);
                }
            }

            comboBox1.DataSource = remainingIngredients;
            btnDelete.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            btnAdd.Enabled = true;
        }


        private void lsIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsIngredient.SelectedItems.Count > 0)
            {
                indexSelected = (int)lsIngredient.SelectedItems[0].Index;
                txtAmount.Text = lsIngredient.SelectedItems[0].SubItems[1].Text;
                comboBox1.Text = lsIngredient.SelectedItems[0].SubItems[0].Text;
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
            }
            else
            {
                txtAmount.Text = string.Empty; // Xóa nội dung trong TextBox nếu không có item nào được chọn
                comboBox1.Text = string.Empty; // Xóa nội dung trong ComboBox nếu không có item nào được chọn
            }
        }
    }
}
