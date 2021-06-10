using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OApprovalHistoryV
    {
        public string Remarks { get; set; }
        public string Notes { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int? SeqNo { get; set; }
        public string Module { get; set; }
        public int? BuId { get; set; }
        public string Approvercode { get; set; }
        public string Employeecode { get; set; }
    }
}
