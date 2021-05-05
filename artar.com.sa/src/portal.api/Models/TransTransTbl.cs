using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class TransTransTbl
    {
        public int JobOrderNum { get; set; }
        public DateTime? JobDate { get; set; }
        public int? CarId { get; set; }
        public int? DriverId { get; set; }
        public int? DepartureId { get; set; }
        public int? Destination { get; set; }
        public DateTime? TransDate { get; set; }
        public string TimeT { get; set; }
        public string Km { get; set; }
        public string Edistance { get; set; }
    }
}
