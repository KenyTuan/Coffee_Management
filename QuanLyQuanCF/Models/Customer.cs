using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Models
{
    internal class Customer
    {
        public long CustomerID { get; set; }

        [StringLength(255)]
        public string NameCustomer { get; set; }

        public bool? Gender { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? BirthDay { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(10, MinimumLength = 10), Column(TypeName = "nchar(10)")]
        public string Phone { get; set; }

        public int Point { get; set; }

        public bool Status { get; set; }

    }
}
