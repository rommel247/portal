using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteAttendanceLog
    {
        public int Id { get; set; }
        public int MachineUserId { get; set; }
        public DateTime Datelog { get; set; }
        public int? Method { get; set; }
        public string SiteCode { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Ip { get; set; }
    }
}
