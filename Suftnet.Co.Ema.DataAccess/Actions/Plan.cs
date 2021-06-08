using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Plan
    {
        public Plan()
        {
            PlanFeatures = new HashSet<PlanFeature>();
        }

        public int Id { get; set; }
        public decimal? BasicPrice { get; set; }
        public decimal? AdvancePrice { get; set; }
        public decimal? ProfessionalPrice { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<PlanFeature> PlanFeatures { get; set; }
    }
}
