using Microsoft.IdentityModel.Tokens;
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

namespace QuanLyQuanCF
{
    public partial class fManageOrder : Form
    {
        public fManageOrder()
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
            fManageOrder_Load(sender, e);

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtID.Text, @"^\d+$") || txtID.Text.IsNullOrEmpty())
            {
                using (var db = new EFDbContext())
                {
                    dataGridView1.DataSource = db.Orders.Where(c => c.OrderID.ToString().Contains(txtID.Text)).Select(o => new
                    {
                        o.OrderID,
                        o.Employee.EmployeeName,
                        o.Customer.NameCustomer,
                        o.OrderTime,
                        o.OrderDate,
                        o.Total
                    }
                        ).ToList();
                }
            }
            else
            {
                toolTip1.Show("Không hợp lệ", txtID, 0, 0, 1000);
                txtID.Focus();
            }

        }

        private void fManageOrder_Load(object sender, EventArgs e)
        {
            using (EFDbContext db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Orders.Select(o => new
                {
                    o.OrderID,
                    o.Employee.EmployeeName,
                    o.Customer.NameCustomer,
                    o.OrderTime,
                    o.OrderDate,
                    o.Total
                }).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long OrderID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);


                    if (MessageBox.Show("Bạn muốn xóa mã Hóa Đơn" + OrderID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (EFDbContext db = new EFDbContext())
                        {
                            Order order = db.Orders.Single(c => c.OrderID == OrderID);
                            List<OrderDetail> orderDetails = db.OrderDetails.Where(od => od.OrderID == order.OrderID).ToList();

                            db.OrderDetails.RemoveRange(orderDetails);
                            db.SaveChanges();
                        }

                        using (EFDbContext db = new EFDbContext())
                        {
                            Order order = db.Orders.Single(c => c.OrderID == OrderID);

                            db.Orders.Remove(order);
                            db.SaveChanges();
                        }
                        if (MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK) == DialogResult.OK)
                        {

                            fManageOrder_Load(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Select")
            {
                if (Utility.IsOpeningForm("fShowDetailOrder"))
                    return;
                fShowDetailOrder f = new fShowDetailOrder(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value));
                f.ShowDialog();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
