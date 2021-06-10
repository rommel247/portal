using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFacilityCardView2
    {
        public int Categoryid { get; set; }
        public int? Bankid { get; set; }
        public double? Creditlimit { get; set; }
        public double? Utilized { get; set; }
        public DateTime Validfrom { get; set; }
        public DateTime Validto { get; set; }
        public double? Rate { get; set; }
        public double? Availableforuse { get; set; }
        public double? Percent { get; set; }
        public string CategoryName { get; set; }
        public string BankNames { get; set; }
        public bool? IsInactive { get; set; }
    }
}
