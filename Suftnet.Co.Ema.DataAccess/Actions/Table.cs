using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Table
    {
        public Guid Id { get; set; }
        public int Size { get; set; }
        public string Number { get; set; }
        public string TimeIn { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public Guid? OrderId { get; set; }
        public bool Active { get; set; }
        public byte[] TimeStamp { get; set; }
        public Guid TenantId { get; set; }
        public DateTime? UpdateDt { get; set; }
        public string UpdateBy { get; set; }
    }
}
