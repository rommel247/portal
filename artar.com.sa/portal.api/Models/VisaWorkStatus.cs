using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class VisaWorkStatus
    {
        public int? VisaId { get; set; }
        public string ProfDesc { get; set; }
        public string CountryDesc { get; set; }
        public string City { get; set; }
        public string StatusDesc { get; set; }
        public string OfficeDesc { get; set; }
        public int? Quantity { get; set; }
    }
}
