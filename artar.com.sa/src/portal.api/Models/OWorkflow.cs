using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OWorkflow
    {
        public int Id { get; set; }
        public int? Reportid { get; set; }
        public string Assignedto { get; set; }
        public DateTime? Datereceived { get; set; }
        public DateTime? Dateforwarded { get; set; }
        public string Notes { get; set; }
        public string Attachment { get; set; }
    }
}
