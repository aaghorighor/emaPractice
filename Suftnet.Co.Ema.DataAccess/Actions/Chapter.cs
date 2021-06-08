using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Chapter
    {
        public Chapter()
        {
            Topics = new HashSet<Topic>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public int SectionId { get; set; }
        public int SubSectionId { get; set; }
        public bool Publish { get; set; }
        public byte[] TimeStamp { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<Topic> Topics { get; set; }
    }
}
