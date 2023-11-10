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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCF
{
    public partial class fManageIngredient : Form
    {
        Ingredient Ingredient;
        private int ingredientId;
        public fManageIngredient()
        {
            Ingredient = new Ingredient();
            InitializeComponent();
        }

        private void fManageIngredient_Activated(object sender, EventArgs e)
        {
            txtAmount.ValidatingType = typeof(decimal);
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Ingredients.Select(
                    i => new
                    {
                        i.IngredientID,
                        i.IngredientName,
                        i.Amount,
                        i.Status
                    }
                    ).ToList();
                txtID.Text = db.Ingredients.Select(i => new { i.IngredientID }).ToArray().Last().IngredientID + 1 + "";
                ingredientId = Convert.ToInt32(txtID.Text);
                txtName.Text = null;
                txtAmount.Text = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Ingredients.Where(i => i.IngredientName.Contains(textBox1.Text)).Select(
                    i => new
                    {
                        i.IngredientID,
                        i.IngredientName,
                        i.Amount,
                        i.Status
                    }
                    ).ToList();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    Ingredient.IngredientName = txtName.Text;
                    Ingredient.Amount = Convert.ToDecimal(txtAmount.Text);
                    Ingredient.Status = cbStatus.Checked;


                    db.Ingredients.Add(Ingredient);
                    db.SaveChanges();
                    toolTip1.Show("Lưu thành công.", btnNew, 0, 0, 1000);
                    fManageIngredient_Activated(sender, e);

                }
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại.", btnNew, 0, 0, 1000);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fManageIngredient_Activated(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    int IngredientID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IngredientID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Ingredient = db.Ingredients.Single(i => i.IngredientID == IngredientID);
                        if (MessageBox.Show("Bạn muốn xóa nguyển liệu " + Ingredient.IngredientName, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Ingredients.Remove(Ingredient);
                            db.SaveChanges();
                            fManageIngredient_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IngredientID"].Value);

                using (var db = new EFDbContext())
                {
                    Ingredient = db.Ingredients.Single(i => i.IngredientID == id);

                    txtID.Text = Ingredient.IngredientID.ToString();
                    txtName.Text = Ingredient.IngredientName.ToString();
                    txtAmount.Text = Ingredient.Amount.ToString();
                    cbStatus.Checked = Ingredient.Status;
                }

            }
        }
    }
}
