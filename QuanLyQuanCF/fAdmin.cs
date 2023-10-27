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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fManagerCustomer f = new fManagerCustomer();
            f.MdiParent = this;
            f.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fManageProduct f = new fManageProduct();
            f.MdiParent = this;
            f.Show();
        }
    }
}
