using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteNotificationErrorLog
    {
        public int Id { get; set; }
        public int? Rowindex { get; set; }
        public string Scriptstatement { get; set; }
        public int? Errornumber { get; set; }
        public int? Errorseverity { get; set; }
        public int? Errorstate { get; set; }
        public string Errorprocedure { get; set; }
        public int? Errorline { get; set; }
        public string Errormessage { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
