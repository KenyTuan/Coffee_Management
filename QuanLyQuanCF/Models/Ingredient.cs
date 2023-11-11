using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Models
{

    internal class Ingredient
    {
        
        public int IngredientID { get; set; }
        
        [StringLength(255)]
        public string IngredientName { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<IngredientOrder> IngredientOrders { get; set; }
        public Ingredient() { 
            this.IngredientOrders = new HashSet<IngredientOrder>();
        } 
    }
}
