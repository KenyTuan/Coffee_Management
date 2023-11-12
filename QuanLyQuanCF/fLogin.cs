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
            this.Hide();
            fAdmin f = new fAdmin();
            f.ShowDialog();
            this.Show();
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