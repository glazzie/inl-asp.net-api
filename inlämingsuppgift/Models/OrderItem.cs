using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace inlämingsuppgift.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        [Required]
        public int Name { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public int Image { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

    }
}
