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

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban that su muon thoat?","Thong Bao",MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }

        }
    }
}