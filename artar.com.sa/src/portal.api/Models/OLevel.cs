using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OLevel
    {
        public int Id { get; set; }
        public int BuId { get; set; }
        public int? ModuleId { get; set; }
        public string Module { get; set; }
        public int? AccessLevel { get; set; }
        public int NestedToLevel { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Createdby { get; set; }
    }
}
