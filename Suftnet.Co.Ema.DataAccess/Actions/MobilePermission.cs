﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class MobilePermission
    {
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public byte[] TimeStamp { get; set; }
        public string UserId { get; set; }
        public Guid Id { get; set; }
        public int PermissionId { get; set; }

        public virtual Common Permission { get; set; }
    }
}
