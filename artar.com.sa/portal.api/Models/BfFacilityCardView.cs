using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFacilityCardView
    {
        public int Categoryid { get; set; }
        public int? Bankid { get; set; }
        public double? Creditlimit { get; set; }
        public double? Utilized { get; set; }
        public double? Facilityrate { get; set; }
        public double? AvailableforUse { get; set; }
        public double? Percent { get; set; }
        public string CategoryName { get; set; }
        public int? Expr1 { get; set; }
        public string BankNames { get; set; }
        public int Id { get; set; }
        public DateTime Validfrom { get; set; }
        public DateTime Validto { get; set; }
    }
}
