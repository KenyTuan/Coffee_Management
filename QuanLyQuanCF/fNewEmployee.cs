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
    
    public partial class fNewEmployee : Form
    {
        Employee employee;
        class Role
        {
            public byte Value { get; set; }
            public string NameRole { get; set; }
        }

        public fNewEmployee()
        {
            InitializeComponent();
        }
        

        private void fNewEmployee_Load(object sender, EventArgs e)
        {
            using (EFDbContext db = new EFDbContext())
            {
                txtID.Text = ++db.Employees.Single(c => c.EmployeeID == db.Employees.ToArray().Last().EmployeeID).EmployeeID + "";
            }

            cbRole.DisplayMember = "NameRole";
            cbRole.ValueMember = "Value";
            List<Role> roles = new List<Role>() ;
            roles.Add(  new Role { Value= 1, NameRole = "Nhân Viên"});
            roles.Add(new Role { Value = 2, NameRole = "Thu Ngân" });
            roles.Add(new Role { Value = 3, NameRole = "Quản Lý" });

            cbRole.DataSource = roles;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    toolTip1.Show("Hãy nhập tên khách hàng?", txtName, 0, 0, 1000);
                    txtName.Focus();
                    return;
                }
                if (txtName.Text.Length > 255)
                {
                    toolTip1.Show("Tên khách hàng đã dài hơn 255 ký tự?", txtName, 0, 0, 1000);
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    toolTip1.Show("Hãy nhập số điện thoại?", txtPhone, 0, 0, 1000);
                    txtPhone.Focus();
                    return;
                }

                if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length > 10)
                {
                    toolTip1.Show("số điện thoại không hợp lệ?", txtPhone, 0, 0, 1000);
                    txtPhone.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    toolTip1.Show("Hãy nhập địa chỉ?", txtAddress, 0, 0, 1000);
                    txtAddress.Focus();
                    return;
                }
                if (txtAddress.Text.Length > 255)
                {
                    toolTip1.Show("Địa chỉ đã dài hơn 255 ký tự?", txtAddress, 0, 0, 1000);
                    txtAddress.Focus();
                    return;
                }

                if (dtkBirthday.Value.Date >= DateTime.Now.Date)
                {
                    toolTip1.Show("Ngày Sinh không hợp lệ?", dtkBirthday, 0, 0, 1000);
                    dtkBirthday.Focus();
                    return;
                }
                if (cbRole.SelectedValue != null)
                {
                    toolTip1.Show("Bạn Chưa Chọn Quyền Hạn?", cbRole, 0, 0, 1000);
                    cbRole.Focus();
                    return;
                }
                
                employee = new Employee();
                employee.EmployeeName = txtName.Text;
                employee.Phone = txtPhone.Text;
                employee.Address = txtAddress.Text;
                employee.BirthDay = dtkBirthday.Value.Date;
                employee.RoleID = Convert.ToByte(cbRole.SelectedValue);
                employee.Email = txtEmail.Text;
                employee.Password = txtPassword.Text;
                employee.Gender = cbGender.CheckState == CheckState.Indeterminate ? (bool?)null : cbGender.Checked;
                employee.Status = cbStatus.Checked;

                using (EFDbContext db = new EFDbContext())
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                }

                toolTip1.Show("Saved Successfully", btnSave, 0, 0, 1000);
                btnClose_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Saved Failed! Error " + ex.Message, btnSave, 0, 0, 1000);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
