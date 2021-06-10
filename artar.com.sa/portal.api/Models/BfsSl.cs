using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfsSl
    {
        public string BankNames { get; set; }
        public int Bankid { get; set; }
        public DateTime Validfrom { get; set; }
        public DateTime Validto { get; set; }
        public bool? IsInactive { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? DateModified { get; set; }
        public string Modifyby { get; set; }
        public int Categoryid { get; set; }
        public string Category { get; set; }
        public double? Creditlimit { get; set; }
        public double? Utilized { get; set; }
        public double? Rate { get; set; }
        public int MasterId { get; set; }
        public double? Availableforuse { get; set; }
        public double? Percentage { get; set; }
        public string Line { get; set; }
        public string ProjectName { get; set; }
        public string AccNo { get; set; }
    }
}
