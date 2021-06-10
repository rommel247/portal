using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfAttachment
    {
        public int Id { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Tbl { get; set; }
        public string Path { get; set; }
        public string Linkedkey { get; set; }
        public string Filename { get; set; }
        public string Createdby { get; set; }
    }
}
