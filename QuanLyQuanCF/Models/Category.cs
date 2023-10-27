using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Models
{
    internal class Category
    {
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }

        public bool Status { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<Product> Products { get; set; }

        public Category() { 
            this.Products = new HashSet<Product>();
        }


    }
}
