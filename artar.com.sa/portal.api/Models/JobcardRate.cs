using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardRate
    {
        public int Id { get; set; }
        public int Recordid { get; set; }
        public int? Rate { get; set; }
        public string Comment { get; set; }
        public DateTime? Timestamp { get; set; }
        public bool? Admin { get; set; }
        public int? Yesno { get; set; }
    }
}
