using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Models
{
    [PrimaryKey(nameof(IngredientOrderID))]
    internal class IngredientOrder
    {
        public long IngredientOrderID { get; set; } 

        public long ProductID { get; set; }

        public int IngredientID { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set;}

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Capacity { get; set;}

        public virtual Product Product { get; set; }

        public virtual Ingredient Ingredient { get; set; }

    }
}
