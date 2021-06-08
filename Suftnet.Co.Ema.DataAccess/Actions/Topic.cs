using System;
using System.Collections.Generic;

#nullable disable

namespace Suftnet.Co.Ema.DataAccess.Actions
{
    public partial class Topic
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public int TopicId { get; set; }
        public bool Publish { get; set; }
        public byte[] TimeStamp { get; set; }
        public string ImageUrl { get; set; }
        public int ChapterId { get; set; }
        public int IndexNo { get; set; }
        public string VideoId { get; set; }
        public string VideoUrl { get; set; }

        public virtual Chapter Chapter { get; set; }
    }
}
