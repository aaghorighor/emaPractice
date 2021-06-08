using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class CustomerAddress
    {
        public CustomerAddress()
        {
            CustomerOrderDeliveries = new HashSet<CustomerOrderDelivery>();
        }

        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string AddressLine { get; set; }
        public byte[] TimeStamp { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string CompleteAddress { get; set; }
        public string Postcode { get; set; }

        public virtual ICollection<CustomerOrderDelivery> CustomerOrderDeliveries { get; set; }
    }
}
