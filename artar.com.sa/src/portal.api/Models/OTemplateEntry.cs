using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OTemplateEntry
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public string BuId { get; set; }
        public string Module { get; set; }
        public int Fid { get; set; }
        public int? NestedToLevel { get; set; }
    }
}
