using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Common
    {
        public Common()
        {
            AspNetUsers = new HashSet<AspNetUser>();
            MobilePermissions = new HashSet<MobilePermission>();
            Permissions = new HashSet<Permission>();
            Settings = new HashSet<Setting>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool Active { get; set; }
        public int? Indexno { get; set; }
        public string Code { get; set; }
        public int Settingid { get; set; }
        public string ImageUrl { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
        public virtual ICollection<MobilePermission> MobilePermissions { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<Setting> Settings { get; set; }
    }
}
