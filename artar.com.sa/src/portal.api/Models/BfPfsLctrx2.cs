using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfPfsLctrx2
    {
        public int Projectid { get; set; }
        public string Categoryid { get; set; }
        public string Issuingbankid { get; set; }
        public DateTime Xdate { get; set; }
        public double? Xamount { get; set; }
        public string Transactionname { get; set; }
        public int Entryno { get; set; }
        public double? Lcamount { get; set; }
        public DateTime? Datecreated { get; set; }
    }
}
