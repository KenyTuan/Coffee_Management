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
    public partial class fManageIngredient : Form
    {
        EFDbContext db = new EFDbContext();
        Ingredient Ingredient;
        private int ingredientId;
        public fManageIngredient()
        {
            Ingredient = new Ingredient();
            InitializeComponent();
        }

        private void fManageIngredient_Activated(object sender, EventArgs e)
        {

            label2.Text = "Tạo Mới";
            txtAmount.ValidatingType = typeof(decimal);

            dataGridView1.DataSource = db.Ingredients.Select(
                i => new
                {
                    i.IngredientID,
                    i.IngredientName,
                    i.Amount,
                    i.Status
                }
                ).ToList();
            txtID.Text = null;
            txtName.Text = null;
            txtAmount.Text = null;
            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                ingredientId = Convert.ToInt32(txtID.Text);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {


                if (!string.IsNullOrWhiteSpace(txtID.Text))
                {
                    if (string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        toolTip1.Show("Không được để trống!", txtName, 0, 0, 1000);


                    }
                    if (txtName.Text.Length > 255)
                    {
                        toolTip1.Show("Không được quá 255?", txtName, 0, 0, 1000);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtAmount.Text))
                    {
                        toolTip1.Show("Không được để trống!", txtAmount, 0, 0, 1000);

                    }
                    if (!Regex.IsMatch(txtAmount.Text, @"^[-+]?[0-9]*.?[0-9]+$"))
                    {
                        toolTip1.Show("Không hợp lệ!", txtAmount, 0, 0, 1000);

                    }

                    Ingredient.IngredientName = txtName.Text;
                    Ingredient.Amount = Convert.ToDecimal(txtAmount.Text);
                    Ingredient.Status = cbStatus.Checked;
                    db.SaveChanges();
                    toolTip1.Show("Lưu thành công.", btnNew, 0, 0, 1000);

                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        toolTip1.Show("Không được để trống!", txtName, 0, 0, 1000);


                    }
                    if (txtName.Text.Length > 255)
                    {
                        toolTip1.Show("Không được quá 255?", txtName, 0, 0, 1000);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtAmount.Text))
                    {
                        toolTip1.Show("Không được để trống!", txtAmount, 0, 0, 1000);

                    }
                    if (!Regex.IsMatch(txtAmount.Text, @"^[-+]?[0-9]*.?[0-9]+$"))
                    {
                        toolTip1.Show("Không hợp lệ!", txtAmount, 0, 0, 1000);

                    }
                    using (EFDbContext db1 = new EFDbContext())
                    {
                        Ingredient.IngredientName = txtName.Text;
                        Ingredient.Amount = Convert.ToDecimal(txtAmount.Text);
                        Ingredient.Status = cbStatus.Checked;
                        db1.Ingredients.Add(Ingredient);
                        db1.SaveChanges();
                        toolTip1.Show("Lưu thành công.", btnNew, 0, 0, 1000);
                    }


                }
                fManageIngredient_Activated(sender, e);


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

                    Ingredient = db.Ingredients.Single(i => i.IngredientID == IngredientID);
                    if (MessageBox.Show("Bạn muốn xóa nguyển liệu " + Ingredient.IngredientName, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.Ingredients.Remove(Ingredient);
                        db.SaveChanges();
                        fManageIngredient_Activated(sender, e);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                label2.Text = "Chỉnh Sửa";
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IngredientID"].Value);

                Ingredient = db.Ingredients.Single(i => i.IngredientID == id);

                txtID.Text = Ingredient.IngredientID.ToString();
                txtName.Text = Ingredient.IngredientName.ToString();
                txtAmount.Text = Ingredient.Amount.ToString();
                cbStatus.Checked = Ingredient.Status;


            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fImportIngredient"))
                return;
            fImportIngredient f = new fImportIngredient();
            f.ShowDialog();
            fManageIngredient_Activated(sender, e);
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fExportIngredient"))
                return;
            fExportIngredient f = new fExportIngredient();
            f.ShowDialog();
            fManageIngredient_Activated(sender, e);
        }

        private void fManageIngredient_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fReportIngredient"))
                return;
            fReportIngredient f = new fReportIngredient();
            f.ShowDialog();
        }

        private void fManageIngredient_Load(object sender, EventArgs e)
        {
/*            if (Utility.employee.RoleID == 1)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;

            }*/
        }
    }
}
