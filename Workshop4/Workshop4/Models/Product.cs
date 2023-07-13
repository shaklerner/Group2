using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Workshop4.Models
{
    [Index("ProductId", Name = "ProductId")]
    public partial class Product
    {
        public Product()
        {
            ProductsSuppliers = new HashSet<ProductsSupplier>();
        }

        [Key]
        public int ProductId { get; set; }
        [StringLength(50)]
        public string ProdName { get; set; } = null!;

        [InverseProperty("Product")]
        public virtual ICollection<ProductsSupplier> ProductsSuppliers { get; set; }

        public override string ToString()
        {
            return $"{ProductId.ToString().PadRight(12)}{ProdName}";
        }
    }
}
