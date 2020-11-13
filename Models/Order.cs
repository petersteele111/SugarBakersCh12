using System;
using System.Collections.Generic;

#nullable disable

namespace SugarBakers.Models
{
    public partial class Order
    {
        public Order()
        {
            ItemsonOrders = new HashSet<ItemsonOrder>();
        }

        public int OrdersId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? FreightCharge { get; set; }
        public decimal? TotalDue { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<ItemsonOrder> ItemsonOrders { get; set; }
    }
}
