using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfPfsLctrx1
    {
        public int ProjectId { get; set; }
        public int Categoryid { get; set; }
        public string IssuingBankid { get; set; }
        public DateTime Xdate { get; set; }
        public double? Xamount { get; set; }
        public string Transactionname { get; set; }
        public int Entryno { get; set; }
        public double? Lcamount { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
