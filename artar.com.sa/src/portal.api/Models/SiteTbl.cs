using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteTbl
    {
        public int Id { get; set; }
        public string SiteCode { get; set; }
        public string SiteName { get; set; }
        public string LoginMode { get; set; }
        public string Stime { get; set; }
        public string RequiredWorkedHrs { get; set; }
        public string SiteNameAr { get; set; }
        public string PayrollEmail { get; set; }
        public string Etime { get; set; }
    }
}
