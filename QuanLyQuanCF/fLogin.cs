using QuanLyQuanCF.Models;

namespace QuanLyQuanCF
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập id của bạn?";
                txtUsername.Select();
            }
            else
            if (txtPassword.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập mật khẩu?";
                txtPassword.Select();
            }
            else
            {
                try
                {
                    using (var db = new EFDbContext())
                    {
                        Utility.employee = db.Employees.SingleOrDefault(e => e.Email == txtUsername.Text && e.Password == txtPassword.Text);
                        if (Utility.employee != null)
                        {
                            DialogResult = DialogResult.OK;
                            this.Hide();
                            fAdmin f = new fAdmin();
                            f.ShowDialog();
                            this.Show();
                        }
                        else
                            lblMessage.Text = "Sai tên người dùng hoặc mật khẩu";
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Lỗi";
                }
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            if (Utility.IsOpeningForm("fManageProduct"))
                return;
            fResestPass1 f = new fResestPass1();
            f.ShowDialog();
            this.Show();
        }

    }
}