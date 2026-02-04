namespace HovSedhep.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction()
        {
            Orders = new HashSet<Order>();
            TransactionDate = DateTime.Now;
        }

        public int TransactionID { get; set; }

        public int TableID { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        public DateTime? TransactionDate { get; set; }
        public string TransactionDateString => TransactionDate?.ToString("D") ?? "-";

        [StringLength(20)]
        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public decimal TotalPrice => Orders.Sum(o => o.OrderDetails.Sum(od => od.Price * od.Quantity));

        public string TotalPriceString => TotalPrice.ToString("Rp#,##0;(Rp#,##0);Rp0");
        public virtual RestaurantTable RestaurantTable { get; set; }
    }
}
