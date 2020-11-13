using System;
using System.Collections.Generic;

#nullable disable

namespace SugarBakers.Models
{
    public partial class Zip
    {
        public Zip()
        {
            Customers = new HashSet<Customer>();
        }

        public string Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
