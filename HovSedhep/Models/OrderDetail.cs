namespace HovSedhep.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        public int OrderDetailID { get; set; }

        public int OrderID { get; set; }

        public int MenuItemID { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
        public string PriceString => Price.ToString("Rp#,##0;(Rp#,##0);Rp0");

        public virtual MenuItem MenuItem { get; set; }
        public string MenuItemName => MenuItem?.Name ?? "-";

        public virtual Order Order { get; set; }
    }
}
