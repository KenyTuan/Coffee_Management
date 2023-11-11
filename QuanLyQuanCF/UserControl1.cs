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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        #region Properties
        private String title;
        private ListViewItem list;
        private String image;

        [Category("Preparation Recipe Props")]
        public String Title
        {
            set { title = value; lblName.Text = value; }
            get { return title; }
        }

        [Category("Preparation Recipe Props")]
        public ListViewItem List
        {
            get { return list; }
            set { list = value; lsIngredient.Items.Add(value); }
        }

        [Category("Preparation Recipe Props")]
        public String Image
        {
            set { image = value; pbProduct.ImageLocation = value; }
            get { return image; }
        }



        #endregion
    }
}
