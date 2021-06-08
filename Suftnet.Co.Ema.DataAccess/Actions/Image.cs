using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Image
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool Active { get; set; }
        public Guid TenantId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }

        public virtual Item Item { get; set; }
    }
}
