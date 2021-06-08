using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Editor
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public string ImageUrl { get; set; }
        public int ContentTypeid { get; set; }
        public bool Active { get; set; }
        public int TenantId { get; set; }
    }
}
