using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Order
    {
        public Order()
        {
            CustomerDeliveryStatuses = new HashSet<CustomerDeliveryStatus>();
            CustomerOrders = new HashSet<CustomerOrder>();
            OfflineCustomerOrders = new HashSet<OfflineCustomerOrder>();
            OrderDetails = new HashSet<OrderDetail>();
            OrderPayments = new HashSet<OrderPayment>();
        }

        public Guid Id { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? GrandTotal { get; set; }
        public decimal? Payment { get; set; }
        public string Time { get; set; }
        public decimal? Balance { get; set; }
        public Guid StatusId { get; set; }
        public Guid OrderTypeId { get; set; }
        public Guid TenantId { get; set; }
        public DateTime? UpdateDt { get; set; }
        public string UpdateBy { get; set; }
        public string Note { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DeliveryCost { get; set; }
        public Guid? PaymentStatusId { get; set; }
        public string Driver { get; set; }

        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<CustomerDeliveryStatus> CustomerDeliveryStatuses { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
        public virtual ICollection<OfflineCustomerOrder> OfflineCustomerOrders { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderPayment> OrderPayments { get; set; }
    }
}
