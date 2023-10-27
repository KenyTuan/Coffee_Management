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
    public partial class fManagerCustomer : Form
    {
        public fManagerCustomer()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewCustomer"))
            {
                return;
            }
            fNewCustomer f = new fNewCustomer();
            f.ShowDialog();
            fManagerCustomer_Activated(sender, e);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (EFDbContext db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Customers.Where(c => c.NameCustomer.Contains(txtNameCustomer.Text)).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long CustomerID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value);
                    using (EFDbContext db = new EFDbContext())
                    {
                        Customer customer = db.Customers.Single(c => c.CustomerID == CustomerID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + customer.NameCustomer, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Customers.Remove(customer);
                            db.SaveChanges();
                            fManagerCustomer_Activated(sender, e);
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
                if (Utility.IsOpeningForm("fEditCustomer"))
                    return;
                fEditCustomer f = new fEditCustomer(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value));
                f.ShowDialog();
                fManagerCustomer_Activated(sender, e);
            }


        }

        private void fManagerCustomer_Activated(object sender, EventArgs e)
        {
            using (EFDbContext db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Customers.ToList();
            }
        }

    }
}
