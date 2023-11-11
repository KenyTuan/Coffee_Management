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
    public partial class fEditEmployee : Form
    {
        EFDbContext db = new EFDbContext();
        Employee employee;
        long EmployeeID;
        class Role
        {
            public byte Value { get; set; }
            public string NameRole { get; set; }
        }
        public fEditEmployee(long EmployeeID)
        {
            InitializeComponent();
            this.EmployeeID = EmployeeID;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    toolTip1.Show("Hãy nhập tên khách hàng?", txtName, 0, 0, 1000);
                    return;
                }
                if (txtName.Text.Length > 255)
                {
                    toolTip1.Show("Tên khách hàng đã dài hơn 255 ký tự?", txtName, 0, 0, 1000);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    toolTip1.Show("Hãy nhập số điện thoại?", txtPhone, 0, 0, 1000);
                    return;
                }

                if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length > 10)
                {
                    toolTip1.Show("số điện thoại không hợp lệ?", txtPhone, 0, 0, 1000);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    toolTip1.Show("Hãy nhập địa chỉ?", txtAddress, 0, 0, 1000);
                    return;
                }
                if (txtAddress.Text.Length > 255)
                {
                    toolTip1.Show("Địa chỉ đã dài hơn 255 ký tự?", txtAddress, 0, 0, 1000);
                    return;
                }

                if (dtkBirthday.Value.Date >= DateTime.Now.Date)
                {
                    toolTip1.Show("Ngày Sinh không hợp lệ?", dtkBirthday, 0, 0, 1000);
                    return;
                }
                if (cbRole.SelectedValue != null)
                {
                    toolTip1.Show("Bạn Chưa Chọn Quyền Hạn?", cbRole, 0, 0, 1000);
                    cbRole.Focus();
                    return;
                }

                employee.EmployeeName = txtName.Text;
                employee.Phone = txtPhone.Text;
                employee.Address = txtAddress.Text;
                employee.BirthDay = dtkBirthday.Value.Date;
                employee.RoleID = Convert.ToByte(cbRole.SelectedValue);
                employee.Email = txtEmail.Text;
                employee.Password = txtPassword.Text;
                employee.Gender = cbGender.CheckState == CheckState.Indeterminate ? (bool?)null : cbGender.Checked;
                employee.Status = (cbStatus.CheckState == CheckState.Indeterminate) ? false : cbStatus.Checked;

                db.SaveChanges();

                toolTip1.Show("Saved Successfully", btnSave, 0, 0, 1000);
                Close();

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

        private void fEditEmployee_Load(object sender, EventArgs e)
        {
            cbRole.DisplayMember = "NameRole";
            cbRole.ValueMember = "Value";
            List<Role> roles = new List<Role>();
            roles.Add(new Role { Value = 1, NameRole = "Nhân Viên" });
            roles.Add(new Role { Value = 2, NameRole = "Thu Ngân" });
            roles.Add(new Role { Value = 3, NameRole = "Quản Lý" });

            cbRole.DataSource = roles;

            employee = db.Employees.Single(p => p.EmployeeID == EmployeeID);

            txtID.Text = employee.EmployeeID.ToString();
            txtName.Text = employee.EmployeeName;
            txtAddress.Text = employee.Address;
            txtPhone.Text = employee.Phone;
            txtEmail.Text = employee.Email;
            txtPassword.Text = employee.Password;
            cbRole.SelectedValue = employee.RoleID;
            dtkBirthday.Text = employee.BirthDay.ToString();
            cbGender.CheckState = employee.Gender == null ? CheckState.Indeterminate : (employee.Gender == true ? CheckState.Checked : CheckState.Unchecked);
            cbStatus.Checked = employee.Status;

        }
    }
}
