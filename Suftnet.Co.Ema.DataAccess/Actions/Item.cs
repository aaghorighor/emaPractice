using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Item
    {
        public Item()
        {
            Images = new HashSet<Image>();
            OrderDetails = new HashSet<OrderDetail>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public Guid UnitId { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool Active { get; set; }
        public int Quantity { get; set; }
        public int SubstractId { get; set; }
        public int? CutOff { get; set; }
        public string ImageUrl { get; set; }
        public byte[] TimeStamp { get; set; }
        public Guid TenantId { get; set; }
        public decimal Cost { get; set; }
        public Guid BrandId { get; set; }
        public string BarCode { get; set; }
        public string Tags { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}
