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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCF
{
    public partial class fExportIngredient : Form
    {
        EFDbContext db = new EFDbContext();
        Ingredient ingredient;
        public fExportIngredient()
        {
            InitializeComponent();
        }

        private void fExportIngredient_Load(object sender, EventArgs e)
        {

            cbIngredient.DisplayMember = "IngredientName";
            cbIngredient.ValueMember = "IngredientID";
            cbIngredient.DataSource = db.Ingredients.Select(a => new { a.IngredientID, a.IngredientName }).ToList(); 
            
            cbIngredient_SelectionChangeCommitted(sender, e);


        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsIngredient.Items.Count > 0)
                {
                    for (int i = 0; i < lsIngredient.Items.Count; i++)
                    {
                        ingredient = db.Ingredients.Single(a => a.IngredientID == Convert.ToInt32(lsIngredient.Items[i].SubItems[0].Text));
                        ingredient.IngredientName = lsIngredient.Items[i].SubItems[1].Text;
                        ingredient.Status = true;
                        ingredient.Amount -= Convert.ToInt32(lsIngredient.Items[i].SubItems[2].Text);
                        db.SaveChanges();
                    }
                    lsIngredient.Items.Clear();
                    MessageBox.Show("Lưu Thành Công!", "Lưu Lại", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại! " + ex.Message);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(numAmount.Text.Trim()))
            {
                toolTip1.Show("Bạn quên nhập số lượng", txtName, 0, 0, 1000);
                numAmount.Focus();
                return;
            }
            if (Convert.ToInt32(numAmount.Text) > numAmount.Maximum && Convert.ToInt32(numAmount.Text) < 0)
            {
                toolTip1.Show("Số lượng không hợp lệ", txtName, 0, 0, 1000);
                numAmount.Focus();
                return;
            }

            string[] result = { txtID.Text, txtName.Text, numAmount.Text };
            lsIngredient.Items.Add(new ListViewItem(result));

            fExportIngredient_Load(sender, e);

        }

        private void btnReset_Click(object sender, EventArgs e)
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

        private void cbIngredient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ingredient = db.Ingredients.Single(i => i.IngredientID.Equals(cbIngredient.SelectedValue));

            txtID.Text = ingredient.IngredientID.ToString();
            txtName.Text = ingredient.IngredientName.ToString();
            numAmount.Text = ingredient.Amount.ToString();
            numAmount.Maximum = ingredient.Amount;

            numAmount.Focus();
        }
    }
}
