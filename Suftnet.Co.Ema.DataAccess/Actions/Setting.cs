using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int? ClassId { get; set; }
        public string ImageUrl { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual Common Class { get; set; }
    }
}
