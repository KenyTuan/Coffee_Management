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
    public partial class fManageEmployee : Form
    {
        public fManageEmployee()
        {
            InitializeComponent();
        }

        private void fManageEmployee_Activated(object sender, EventArgs e)
        {
            using (EFDbContext db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Employees.ToList();
            }
        }

        private void txtNameEmployee_TextChanged(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Employees.Where(c => c.EmployeeName.Contains(txtNameEmployee.Text)).ToList();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewEmployee"))
            {
                return;
            }
            fNewEmployee f = new fNewEmployee();
            f.ShowDialog();
            fManageEmployee_Activated(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long EmployeeID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["EmployeeID"].Value);
                    using (EFDbContext db = new EFDbContext())
                    {
                        Employee employee = db.Employees.Single(c => c.EmployeeID == EmployeeID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + employee.EmployeeName, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Employees.Remove(employee);
                            db.SaveChanges();
                            fManageEmployee_Activated(sender, e);
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
                if (Utility.IsOpeningForm("fEditEmployee"))
                    return;
                fEditEmployee f = new fEditEmployee(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["EmployeeID"].Value));
                f.ShowDialog();
                fManageEmployee_Activated(sender, e);
            }
        }
    }
}
