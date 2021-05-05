using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfPfsLoanTrx2
    {
        public int ProjectNameId { get; set; }
        public string Categoryid { get; set; }
        public int Bankid { get; set; }
        public DateTime Xdate { get; set; }
        public string Transactionname { get; set; }
        public int Entryno { get; set; }
        public double? LoanAmount { get; set; }
        public double? Xamount { get; set; }
        public DateTime? Datecreated { get; set; }
    }
}
