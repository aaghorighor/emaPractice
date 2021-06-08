﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Supplier
    {
        public Supplier()
        {
            Purchases = new HashSet<Purchase>();
        }

        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool Active { get; set; }
        public Guid TenantId { get; set; }
        public string Address { get; set; }
        public Guid Id { get; set; }

        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
