using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class TransView
    {
        public int JobOrderNum { get; set; }
        public DateTime? JobDate { get; set; }
        public DateTime? TransDate { get; set; }
        public string Km { get; set; }
        public string DriverCode { get; set; }
        public string DriverNameArabic { get; set; }
        public string CarCode { get; set; }
        public string CarPlateNo { get; set; }
        public string PlaceDesc { get; set; }
        public string Expr1 { get; set; }
        public string Edistance { get; set; }
    }
}
