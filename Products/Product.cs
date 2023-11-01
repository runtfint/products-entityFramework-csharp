using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Products
{
    public class Product
    {
        [Required]
        public Guid Guid { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
