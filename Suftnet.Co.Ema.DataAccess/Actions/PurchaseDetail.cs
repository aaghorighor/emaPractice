using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class PurchaseDetail
    {
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public Guid PurchaseId { get; set; }
        public Guid StatusId { get; set; }

        public virtual Item Item { get; set; }
        public virtual Purchase Purchase { get; set; }
        public virtual OrderStatus Status { get; set; }
    }
}
