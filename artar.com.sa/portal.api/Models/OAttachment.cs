using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OAttachment
    {
        public int Id { get; set; }
        public int? Reportid { get; set; }
        public string Attachment { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
