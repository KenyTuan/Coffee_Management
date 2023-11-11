using QuanLyQuanCF.Models;
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
    public partial class itemPreparationRecipe : UserControl
    {


        public itemPreparationRecipe()
        {
            InitializeComponent();

        }


        #region Properties
        private ListView ingredientOrders;
        private Image image;
        private Button button;

        public Button Button
        {
            set { button = value; button = value; }
            get { return button; }
        }
        public ListView IngredientOrders
        {
            set { ingredientOrders = value; lsIngredient = value; }
            get { return ingredientOrders; }
        }

        public Image Image
        {
            set { image = value; imgProduct.Image = value; }
            get { return image; }
        }
        #endregion
    }
}
