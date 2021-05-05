using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFacilityCardSummaryView
    {
        public int Id { get; set; }
        public int? Bankid { get; set; }
        public DateTime Validfrom { get; set; }
        public DateTime Validto { get; set; }
        public string Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Createdby { get; set; }
        public double TotalGlcreditLimit { get; set; }
        public double TotalSlcreditLimit { get; set; }
        public bool? Def { get; set; }
        public string BankNames { get; set; }
        public string BankLetters { get; set; }
    }
}
