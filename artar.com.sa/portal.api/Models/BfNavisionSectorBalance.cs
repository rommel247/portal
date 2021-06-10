using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfNavisionSectorBalance
    {
        public int Id { get; set; }
        public int? Sectorid { get; set; }
        public string Sector { get; set; }
        public decimal? Balance { get; set; }
        public DateTime Currentdate { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Rtble { get; set; }
    }
}
