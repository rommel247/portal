using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFacilityCardGeneralLineReport
    {
        public int? MasterId { get; set; }
        public string BankNames { get; set; }
        public int Bankid { get; set; }
        public DateTime? Validfrom { get; set; }
        public DateTime? Validto { get; set; }
        public bool? IsInactive { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? DateModified { get; set; }
        public string Modifyby { get; set; }
        public int? Categoryid { get; set; }
        public string Category { get; set; }
        public double? Creditlimit { get; set; }
        public double? Utilized { get; set; }
        public double? Rate { get; set; }
        public double Availableforuser { get; set; }
        public double? Percentage { get; set; }
        public bool? Def { get; set; }
        public string BankLetters { get; set; }
        public int? AccountNoid { get; set; }
    }
}
