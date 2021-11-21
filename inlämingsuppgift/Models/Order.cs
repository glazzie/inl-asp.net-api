using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace inlämingsuppgift.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        [DefaultValue(false)]
        public bool IsPaid { get; set; }

        [DefaultValue(false)]
        public bool IsDelivered { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
