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
using System.Xml.Linq;

namespace QuanLyQuanCF
{
    public partial class fResestPass1 : Form
    {

        EFDbContext db = new EFDbContext();
        Employee employee = new Employee();
        public fResestPass1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    toolTip1.Show("Không Được để trống!", txtID, 0, 0, 1000);
                    txtID.Focus();
                    return;
                }
                if (txtID.Text.Length > 255)
                {
                    toolTip1.Show("Không được quá 255?", txtID, 0, 0, 1000);
                    txtID.Focus();
                    return;
                }


                    employee = db.Employees.Single(o => o.Email.Contains(txtID.Text));
                    if ( employee != null || txtNewPass.Text.Equals(txtPassConfirm.Text))
                    {
                        employee.Password = txtNewPass.Text;
                        db.SaveChanges();
                        MessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                else
                {

                    MessageBox.Show("Bạn kiểm tra lại id hoặc mật khẩu đã đúng chưa?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }


                    
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
