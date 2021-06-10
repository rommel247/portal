using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OSecurityProfileV
    {
        public string Module { get; set; }
        public int L1Id { get; set; }
        public string L1Title { get; set; }
        public int? L1AccessLevel { get; set; }
        public int? L2Id { get; set; }
        public string L2Title { get; set; }
        public int? L2AccessLevel { get; set; }
        public int? L3Id { get; set; }
        public string L3Title { get; set; }
        public int? L3AccessLevel { get; set; }
        public int? L4Id { get; set; }
        public string L4Title { get; set; }
        public int? L4AccessLevel { get; set; }
    }
}
