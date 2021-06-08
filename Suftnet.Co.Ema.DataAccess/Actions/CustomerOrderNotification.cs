using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class CustomerOrderNotification
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string Messages { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
