using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class VisaDetail
    {
        public int Id { get; set; }
        public int? VisaId { get; set; }
        public int? ProfId { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? Quantity { get; set; }
        public string Notes { get; set; }
        public int? Canceled { get; set; }
        public int? Updated { get; set; }
        public int? Syrian { get; set; }
    }
}
