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
    public partial class fEditCustomer : Form
    {
        EFDbContext db = new EFDbContext();
        Customer customer;
        long CustomerID;

        public fEditCustomer(long CustomerID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;

        }

        private void fEditCustomer_Load(object sender, EventArgs e)
        {
            customer = db.Customers.Single(p => p.CustomerID == CustomerID);

            txtID.Text += customer.CustomerID.ToString();
            txtName.Text = customer.NameCustomer;
            txtAddress.Text = customer.Address;
            txtPhone.Text = customer.Phone;
            dtpBirthday.Text = customer.BirthDay.ToString();
            cbGender.CheckState = customer.Gender == null ? CheckState.Indeterminate : (customer.Gender == true ? CheckState.Checked : CheckState.Unchecked);
            cbStatus.Checked = customer.Status;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    toolTip1.Show("Không Được để trống!", txtName, 0, 0, 1000);
                    return;
                }
                if (txtName.Text.Length > 255)
                {
                    toolTip1.Show("Không được quá 255?", txtName, 0, 0, 1000);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    toolTip1.Show("Hãy nhập số điện thoại?", txtPhone, 0, 0, 1000);
                    return;
                }

                if (!Regex.IsMatch(txtPhone.Text, "^(0|\\+84)(\\s|\\.)?((3[2-9])|(5[689])|(7[06-9])|(8[1-689])|(9[0-46-9]))(\\d)(\\s|\\.)?(\\d{3})(\\s|\\.)?(\\d{3})$"))
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

                if (dtpBirthday.Value.Date >= DateTime.Now.Date)
                {
                    toolTip1.Show("Ngày Sinh không hợp lệ?", dtpBirthday, 0, 0, 1000);
                    return;
                }

                customer.NameCustomer = txtName.Text;
                customer.Phone = txtPhone.Text;
                customer.Address = txtAddress.Text;
                customer.BirthDay = dtpBirthday.Value.Date;
                customer.Gender = cbGender.CheckState == CheckState.Indeterminate ? (bool?)null : cbGender.Checked;
                customer.Status = (cbStatus.CheckState == CheckState.Indeterminate) ? false : cbStatus.Checked;

                db.SaveChanges();

                MessageBox.Show("Lưu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClose_Click(sender, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại!", "Thông Báo", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);

            }


        }

        private void fEditCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;

        }
    }
}
