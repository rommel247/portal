using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class Late
    {
        public int? LateIn { get; set; }
        public DateTime? RamadanStartDate { get; set; }
        public DateTime? RamadanEndDate { get; set; }
        public int? RamadanStartTimeHour { get; set; }
        public int? RamadanStartTimeMinute { get; set; }
        public int? RamadanLateIn { get; set; }
    }
}
