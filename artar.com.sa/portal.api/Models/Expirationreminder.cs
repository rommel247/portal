using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class Expirationreminder
    {
        public int Id { get; set; }
        public string Empcode { get; set; }
        public string Description { get; set; }
        public DateTime Expirydate { get; set; }
        public string Sms { get; set; }
        public string Email { get; set; }
        public string Documentname { get; set; }
        public DateTime? Dateentry { get; set; }
        public int? CategoryKey { get; set; }
        public string Notes { get; set; }
        public int? AlertDayinterval { get; set; }
        public string AlerttimeTosend { get; set; }
        public string AmPm { get; set; }
        public int? Cancel { get; set; }
        public int? Xday { get; set; }
        public int? Xweek { get; set; }
        public int? Xmonth { get; set; }
        public int? Xyear { get; set; }
        public string Dw { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Mode { get; set; }
        public string Occurence { get; set; }
        public string Pattern1 { get; set; }
        public string Pattern2 { get; set; }
        public string Pattern3 { get; set; }
        public string Mobile2 { get; set; }
        public string Emailcc { get; set; }
    }
}
