using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class VisaCountryTbl
    {
        public int Cid { get; set; }
        public int? CountryId { get; set; }
        public string CountryDesc { get; set; }
        public string City { get; set; }
    }
}
