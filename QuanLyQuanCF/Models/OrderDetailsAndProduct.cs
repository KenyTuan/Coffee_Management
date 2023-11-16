using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Models
{
    internal class OrderDetailsAndProduct
    {
      
        public string ProductName { get; set; }
        public string ProductSize { get; set; }
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal Amount { get { return Quantity * Price; } }


    }
}
