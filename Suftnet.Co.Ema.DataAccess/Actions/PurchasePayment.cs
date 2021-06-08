using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class PurchasePayment
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Reference { get; set; }
        public byte[] TimeStamp { get; set; }
        public Guid PaymentMethodId { get; set; }
        public Guid TenantId { get; set; }
        public Guid PurchaseId { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDt { get; set; }
    }
}
