namespace HovSedhep.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderID { get; set; }

        public int TransactionID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime? OrderTime { get; set; }
        public string OrderTimeString => OrderTime?.ToString("T") ?? "-";

        public virtual Employee Employee { get; set; }
        public string EmployeeName => Employee?.Name ?? "-";

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public int TotalItems => OrderDetails?.Count ?? 0;

        public virtual Transaction Transaction { get; set; }
    }
}
