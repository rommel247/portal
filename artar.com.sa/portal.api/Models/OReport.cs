using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OReport
    {
        public int Reportid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Daterequest { get; set; }
        public string Notes { get; set; }
        public string Requestorcode { get; set; }
        public string Attachment { get; set; }
    }
}
