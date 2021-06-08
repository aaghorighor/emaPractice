using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class OfflineCustomerOrder
    {
        public Guid Id { get; set; }
        public Guid OfflineCustomerId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual OfflineCustomer OfflineCustomer { get; set; }
        public virtual Order Order { get; set; }
    }
}
