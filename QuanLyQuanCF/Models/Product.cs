using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace QuanLyQuanCF.Models
{
    internal class Product
    {
        public long ProductID { get; set; }

        [StringLength(255)]
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [StringLength(3)]
        public string ProductSize { get; set; }

        [StringLength(255)]
        public string? ImageFile { get; set; }

        public bool Status { get; set; }

        [ForeignKey(nameof(Category))]
        public long CategoryID { get; set; }

        [InverseProperty("Products")]
        public virtual Category Category { get; set; }


    }
}