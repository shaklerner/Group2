using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Workshop4.Models
{
    public partial class Package
    {
        public Package()
        {
            Bookings = new HashSet<Booking>();
            PackagesProductsSuppliers = new HashSet<PackagesProductsSupplier>();
        }

        [Key]
        public int PackageId { get; set; }
        [StringLength(50)]
        public string PkgName { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? PkgStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PkgEndDate { get; set; }
        [StringLength(50)]
        public string? PkgDesc { get; set; }
        [Column(TypeName = "money")]
        public decimal PkgBasePrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? PkgAgencyCommission { get; set; }

        [InverseProperty("Package")]
        public virtual ICollection<Booking> Bookings { get; set; }
        [InverseProperty("Package")]
        public virtual ICollection<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; }

		public override string ToString()
		{
			return $"{PackageId.ToString().PadRight(8)}{PkgName.PadRight(52)}{PkgStartDate?.ToString("yyyy-MM-dd").PadRight(15)}{PkgEndDate?.ToString("yyyy-MM-dd").PadRight(15)}{PkgDesc?.PadRight(52)}{PkgBasePrice.ToString("c").PadRight(12)}{PkgAgencyCommission?.ToString("c").PadRight(12)}";
		}


	}
}
