using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OApprovalList
    {
        public int Id { get; set; }
        public int BuId { get; set; }
        public string Module { get; set; }
        public string Employeecode { get; set; }
        public int SeqNo { get; set; }
        public DateTime? Datecreated { get; set; }
        public int? Inactive { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
    }
}
