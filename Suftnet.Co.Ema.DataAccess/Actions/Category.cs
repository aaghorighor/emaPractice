using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public int IndexNo { get; set; }
        public byte[] TimeStamp { get; set; }
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }
        public string Tags { get; set; }

        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
