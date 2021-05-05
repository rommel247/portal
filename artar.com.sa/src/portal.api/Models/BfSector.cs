using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfSector
    {
        public int Id { get; set; }
        public string Sector { get; set; }
        public double? ProfitPercentage { get; set; }
    }
}
