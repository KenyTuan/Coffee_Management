using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Models
{
    internal class Order
    {
        public long OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public TimeSpan OrderTime { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }
        public long CustomerID { get; set; }
        public long EmployeeID { get; set; } 
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual Employee Employee { get; set; }

        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

    }
}
