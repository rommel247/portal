using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteDutiesSched
    {
        public int Id { get; set; }
        public string ShiftCode { get; set; }
        public string ShiftDesc { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string LastModify { get; set; }
        public DateTime? LastModifyDatetime { get; set; }
    }
}
