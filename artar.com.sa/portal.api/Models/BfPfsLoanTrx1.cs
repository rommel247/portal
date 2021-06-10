using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfPfsLoanTrx1
    {
        public int LoanMasterId { get; set; }
        public string Transactionname { get; set; }
        public double? LoanAmount { get; set; }
        public DateTime Xdate { get; set; }
        public double? Xamount { get; set; }
        public DateTime? Datecreated { get; set; }
    }
}
