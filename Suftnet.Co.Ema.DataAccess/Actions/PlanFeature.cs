using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class PlanFeature
    {
        public int Id { get; set; }
        public int FeatureId { get; set; }
        public int BasicId { get; set; }
        public int AdvanceId { get; set; }
        public int ProfessionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int PlanId { get; set; }
        public string BasicValue { get; set; }
        public string PremiumValue { get; set; }
        public string PremiumPlusValue { get; set; }
        public int? IndexNo { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual Plan Plan { get; set; }
    }
}
