using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfGeneralLineUnion
    {
        public int? Bankid { get; set; }
        public int Categoryid { get; set; }
        public double? Creditlimit { get; set; }
        public double? Utilized { get; set; }
        public double? Rate { get; set; }
    }
}
