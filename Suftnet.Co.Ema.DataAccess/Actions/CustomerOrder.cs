using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class CustomerOrder
    {
        public CustomerOrder()
        {
            CustomerOrderDeliveries = new HashSet<CustomerOrderDelivery>();
        }

        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<CustomerOrderDelivery> CustomerOrderDeliveries { get; set; }
    }
}
