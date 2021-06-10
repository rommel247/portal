using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class AssetAttachment
    {
        public int Id { get; set; }
        public string Idno { get; set; }
        public string Filename { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Username { get; set; }
    }
}
