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
    public partial class fNewCustomer : Form
    {
        Customer customer;

        public fNewCustomer()
        {
            InitializeComponent();

        }

        private void fNewCustomer_Load(object sender, EventArgs e)
        {
            using (EFDbContext db = new EFDbContext())
            {
                txtID.Text = ++db.Customers.Single(c => c.CustomerID == db.Customers.ToArray().Last().CustomerID).CustomerID + "";
            }
        }


        private void fNewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên khách hàng?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            if (txtName.Text.Length > 255)
            {
                toolTip1.Show("Tên khách hàng đã dài hơn 255 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                toolTip1.Show("Hãy nhập số điện thoại?", txtPhone, 0, 0, 1000);
                e.Cancel = true;
            }

            if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length > 10)
            {
                toolTip1.Show("số điện thoại không hợp lệ?", txtPhone, 0, 0, 1000);
                e.Cancel = true;
            }

        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ?", txtAddress, 0, 0, 1000);
                e.Cancel = true;
            }
            if (txtAddress.Text.Length > 255)
            {
                toolTip1.Show("Địa chỉ đã dài hơn 255 ký tự?", txtAddress, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void dtpBirthday_Validating(object sender, CancelEventArgs e)
        {
            if (dtpBirthday.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày Sinh không hợp lệ?", dtpBirthday, 0, 0, 1000);
                e.Cancel = true;
            }
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

                if (dtpBirthday.Value.Date >= DateTime.Now.Date)
                {
                    toolTip1.Show("Ngày Sinh không hợp lệ?", dtpBirthday, 0, 0, 1000);
                    dtpBirthday.Focus();
                    return;
                }

                customer = new Customer();
                customer.NameCustomer = txtName.Text;
                customer.Phone = txtPhone.Text;
                customer.Address = txtAddress.Text;
                customer.BirthDay = dtpBirthday.Value.Date;
                customer.Gender = cbGender.CheckState == CheckState.Indeterminate ? (bool?)null : cbGender.Checked;
                customer.Status = cbStatus.Checked;

                using (EFDbContext db = new EFDbContext())
                {
                    db.Customers.Add(customer);
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
