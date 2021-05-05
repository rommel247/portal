using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class VisaWork
    {
        public int Id { get; set; }
        public int? VisaId { get; set; }
        public int? StatusId { get; set; }
        public int? ProfId { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? Quantity { get; set; }
        public int? OfficeId { get; set; }
        public string Notes { get; set; }
    }
}
