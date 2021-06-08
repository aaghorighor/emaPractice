using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerOrderNotifications = new HashSet<CustomerOrderNotification>();
            CustomerOrders = new HashSet<CustomerOrder>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Serial { get; set; }
        public string DeviceId { get; set; }
        public Guid TenantId { get; set; }
        public string StripeCustomerId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<CustomerOrderNotification> CustomerOrderNotifications { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
    }
}
