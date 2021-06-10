using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFacilityCard
    {
        public int MasterId { get; set; }
        public int? Bankid { get; set; }
        public string BankNames { get; set; }
        public DateTime Validfrom { get; set; }
        public DateTime Validto { get; set; }
        public int Categoryid { get; set; }
        public string CategoryName { get; set; }
        public double? Creditlimit { get; set; }
        public double? Utilized { get; set; }
        public double? Rate { get; set; }
        public double? Availableforuse { get; set; }
        public double? Percent { get; set; }
        public bool? IsInactive { get; set; }
        public double? Facilityrate { get; set; }
        public bool? Def { get; set; }
        public string BankLetters { get; set; }
        public int AccountNoid { get; set; }
    }
}
