﻿using Microsoft.EntityFrameworkCore;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace QuanLyQuanCF
{
    public partial class fNewpreparationRecipe : Form
    {

        EFDbContext EFDbContext;


        public fNewpreparationRecipe()
        {
            InitializeComponent();
            EFDbContext = new EFDbContext();
        }

        private void fNewpreparationRecipe_Load(object sender, EventArgs e)
        {

            comboBox2.DisplayMember = "ProductID";
            comboBox2.ValueMember = "ProductName";
            var products = EFDbContext.Product.Select(p => new { p.ProductID, p.ProductName }).ToList();

            foreach (var item in products)
            {
                long id = item.ProductID;
                var ing = EFDbContext.IngredientOrders.Where(io => io.ProductID == id).ToList();

                if (ing.IsNullOrEmpty())
                {
                    comboBox2.Items.Add(new { item.ProductName, item.ProductID });
                }
            }
            var ingredient = EFDbContext.Ingredients.ToList();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var db = new EFDbContext())
            {
                Product product = db.Product.Single(p => p.ProductID == Convert.ToInt64(comboBox2.Text));

                lblProduct.Text = product.ProductName;
                label2.Text = product.ProductSize + "";
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                toolTip1.Show("Bạn quên nhập!", textBox2, 0, 0, 1000);
                return;
            }
            if (!Regex.IsMatch(textBox2.Text, @"^\d+$"))
            {
                toolTip1.Show("Bạn cần nhập số nguyên", textBox2, 0, 0, 1000);
                return;
            }
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                toolTip1.Show("Bạn Quên Chọn Sản Phẩm!", comboBox2, 0, 0, 1000);
                return;
            }

            string[] row = new string[] { comboBox1.Text, textBox2.Text };

            lsIngredient.Items.Add(new ListViewItem(row));

            fNewpreparationRecipe_Activated(sender, e);

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
                fNewpreparationRecipe_Activated(sender, e);

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
                    MessageBox.Show("Bạn chưa thêm lượng nguyên liệu pha chế", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    toolTip1.Show("Bạn quên nhập!", textBox2, 0, 0, 1000);
                    return;
                }
                if (!Regex.IsMatch(textBox2.Text, @"^\d+$"))
                {
                    toolTip1.Show("Bạn cần nhập số nguyên", textBox2, 0, 0, 1000);
                    return;
                }
                if (string.IsNullOrEmpty(comboBox2.Text))
                {
                    toolTip1.Show("Bạn Quên Chọn Sản Phẩm!", comboBox2, 0, 0, 1000);
                    return;
                }

                int min = 9999;


                IngredientOrder ingredientOrder = new IngredientOrder();

                ingredientOrder.ProductID = Convert.ToInt32(comboBox2.Text);

                for (int i = 0; i < lsIngredient.Items.Count; i++)
                {
                    var ingredient = new Ingredient();


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
                lsIngredient.Items.Clear();


                Product product = EFDbContext.Product.Single(p => p.ProductID == Convert.ToInt64(comboBox2.Text));
                product.Quantity = min;
                EFDbContext.SaveChanges();

                fNewpreparationRecipe_Load(sender, e);
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu Thất Bại" + ex, "Thông Báo", MessageBoxButtons.OK);
                Log.ReferenceEquals(this, ex);
            }
        }

        private void fNewpreparationRecipe_Activated(object sender, EventArgs e)
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
            button3.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void lsIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsIngredient.SelectedItems.Count > 0)
            {
                textBox2.Text = lsIngredient.SelectedItems[0].SubItems[1].Text;
                comboBox1.Text = lsIngredient.SelectedItems[0].SubItems[0].Text;
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                button3.Enabled = false;
            }
            else
            {
                textBox2.Text = string.Empty; // Xóa nội dung trong TextBox nếu không có item nào được chọn
                comboBox1.Text = string.Empty; // Xóa nội dung trong ComboBox nếu không có item nào được chọn
            }
        }
    }
}
