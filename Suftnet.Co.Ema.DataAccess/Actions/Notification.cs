using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Notification
    {
        public string Subject { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public string Body { get; set; }
        public int StatusId { get; set; }
        public Guid TenantId { get; set; }
        public Guid Id { get; set; }
    }
}
