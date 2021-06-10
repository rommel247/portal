using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfGeneralLineUnion2
    {
        public int Categoryid { get; set; }
        public int? Bankid { get; set; }
        public double? Creditlimit { get; set; }
        public double? Utilized { get; set; }
        public double? Rate { get; set; }
        public string BankNames { get; set; }
        public string CategoryName { get; set; }
        public double? Availableforuse { get; set; }
        public double? Percentage { get; set; }
    }
}
