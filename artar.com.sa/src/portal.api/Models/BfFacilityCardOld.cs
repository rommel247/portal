using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFacilityCardOld
    {
        public int Id { get; set; }
        public int? Bankid { get; set; }
        public int? Categoryid { get; set; }
        public double? CreditLimit { get; set; }
        public double? Utilized { get; set; }
        public DateTime? ValidityFrom { get; set; }
        public DateTime? ValidityTo { get; set; }
        public double? FacilityRate { get; set; }
        public string AttachmentFacility { get; set; }
        public int? Projectnameid { get; set; }
    }
}
