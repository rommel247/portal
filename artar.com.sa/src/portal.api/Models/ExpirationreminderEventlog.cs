using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ExpirationreminderEventlog
    {
        public int Id { get; set; }
        public string Empcode { get; set; }
        public string Event { get; set; }
        public DateTime? Dateentry { get; set; }
        public int? RecordKey { get; set; }
    }
}
