using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class CustomerOrderDelivery
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public Guid CustomerOrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual CustomerAddress Address { get; set; }
        public virtual CustomerOrder CustomerOrder { get; set; }
    }
}
