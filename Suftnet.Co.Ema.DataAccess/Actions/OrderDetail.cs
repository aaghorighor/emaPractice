using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class OrderDetail
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Guid ItemId { get; set; }
        public decimal Price { get; set; }
        public decimal LineTotal { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public Guid OrderId { get; set; }
        public bool? IsProcessed { get; set; }
        public string ItemName { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime? UpdateDt { get; set; }
        public string UpdateBy { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
