using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteBioTime
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string SiteCode { get; set; }
        public string Area { get; set; }
        public string LocalIp { get; set; }
    }
}
