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

        private void MenuCustomer_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManagerCustomer"))
                return;
            fManagerCustomer f = new fManagerCustomer();
            f.MdiParent = this;
            f.Show();
        }

        private void menuProduct_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageProduct"))
                return;
            fManageProduct f = new fManageProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuIngredient_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageIngredient"))
                return;
            fManageIngredient f = new fManageIngredient();
            f.MdiParent = this;
            f.Show();

        }

        private void menuPreparationRecipe_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManagePreparationRecipe"))
                return;
            fManagePreparationRecipe f = new fManagePreparationRecipe();
            f.MdiParent = this;
            f.Show();
        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageEmployee"))
                return;
            fManageEmployee f = new fManageEmployee();
            f.MdiParent = this;
            f.Show();
        }

        private void menuOrderDetail_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManagerOrderDetail"))
                return;
            fManageOrderDetail f = new fManageOrderDetail();
            f.MdiParent = this;
            f.Show();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManagerOrderDetail"))
                return;
            fManageOrderDetail f = new fManageOrderDetail();
            f.MdiParent = this;
            f.Show();
        }

        private void menuOrder_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageOrder"))
                return;
            fManageOrder f = new fManageOrder();
            f.MdiParent = this;
            f.Show();
        }
    }
}
