using System;
using System.Collections.Generic;

#nullable disable

namespace SugarBakers.Models
{
    public partial class Product
    {
        public Product()
        {
            ItemsonOrders = new HashSet<ItemsonOrder>();
        }

        public int ProductsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ItemsonOrder> ItemsonOrders { get; set; }
    }
}
