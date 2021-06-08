using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Tenant
    {
        public Tenant()
        {
            Categories = new HashSet<Category>();
            Discounts = new HashSet<Discount>();
            Orders = new HashSet<Order>();
            Payments = new HashSet<Payment>();
            Suppliers = new HashSet<Supplier>();
            UserAccounts = new HashSet<UserAccount>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CustomerStripeId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int? CurrencyId { get; set; }
        public bool? Startup { get; set; }
        public string WebsiteUrl { get; set; }
        public bool? IsExpired { get; set; }
        public string PlanTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public string LogoUrl { get; set; }
        public bool? Publish { get; set; }
        public string StripePublishableKey { get; set; }
        public string StripeSecretKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public string SubscriptionId { get; set; }
        public string CurrencyCode { get; set; }
        public string BackgroundUrl { get; set; }
        public Guid AddressId { get; set; }
        public Guid StateId { get; set; }
        public decimal? DeliveryCost { get; set; }
        public string AppCode { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? DiscountRate { get; set; }

        public virtual TenantAddress Address { get; set; }
        public virtual TenantState State { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual ICollection<UserAccount> UserAccounts { get; set; }
    }
}
