using System;
using System.Collections.Generic;

#nullable disable

namespace SugarBakers.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
            Payments = new HashSet<Payment>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string PhoneNumber { get; set; }
        public string Extension { get; set; }

        public virtual Zip ZipcodeNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
