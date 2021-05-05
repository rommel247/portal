using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class TransDriver
    {
        public int Id { get; set; }
        public string DriverCode { get; set; }
        public string DriverNameArabic { get; set; }
        public string DriverPostionArabic { get; set; }
    }
}
