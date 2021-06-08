using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Faq
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public bool Publish { get; set; }
        public int? SortOrderId { get; set; }
    }
}
