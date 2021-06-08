using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class UserAccount
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public Guid TenantId { get; set; }
        public string AppCode { get; set; }
        public string EmailAddress { get; set; }
        public string UserCode { get; set; }

        public virtual Tenant Tenant { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
