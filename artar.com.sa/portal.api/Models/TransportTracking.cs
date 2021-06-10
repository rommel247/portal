using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class TransportTracking
    {
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string CarCode { get; set; }
        public string CarPlateNo { get; set; }
        public string CarDesc { get; set; }
        public string DriverNameArabic { get; set; }
        public string DriverPostionArabic { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? JdTracking { get; set; }
        public string JtTracking { get; set; }
        public int? JobOrderNumber { get; set; }
        public string DriverCode { get; set; }
        public string Km { get; set; }
        public string Edistance { get; set; }
    }
}
