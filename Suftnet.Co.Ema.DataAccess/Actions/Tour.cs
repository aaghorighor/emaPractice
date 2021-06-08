﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Tour
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StyleTypeId { get; set; }
        public int SortOrder { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool Active { get; set; }
        public string ImageUrl { get; set; }
    }
}
