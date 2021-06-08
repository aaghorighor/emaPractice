using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Payment
    {
        public Payment()
        {
            OrderPayments = new HashSet<OrderPayment>();
        }

        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public string Reference { get; set; }
        public byte[] TimeStamp { get; set; }
        public Guid PaymentMethodId { get; set; }
        public Guid TenantId { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDt { get; set; }
        public Guid AccountTypeId { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<OrderPayment> OrderPayments { get; set; }
    }
}
