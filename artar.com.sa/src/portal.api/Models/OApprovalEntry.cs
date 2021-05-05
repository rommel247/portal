using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OApprovalEntry
    {
        public int Id { get; set; }
        public string Employeecode { get; set; }
        public int BuId { get; set; }
        public string Module { get; set; }
        public string Approvercode { get; set; }
        public string Remarks { get; set; }
        public string Notes { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Username { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Lastupdateby { get; set; }
        public int? SeqNo { get; set; }
    }
}
