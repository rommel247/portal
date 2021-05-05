using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class RequisitionAuditLog
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime? Datetimestamp { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Username { get; set; }
        public string TableOrigin { get; set; }
    }
}
