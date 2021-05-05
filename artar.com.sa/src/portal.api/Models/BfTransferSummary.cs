using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfTransferSummary
    {
        public int LoanmasterId { get; set; }
        public string Transactionname { get; set; }
        public double? LoanAmount { get; set; }
        public DateTime Startingdate { get; set; }
        public DateTime? EndingDate { get; set; }
        public double? SiborRate { get; set; }
        public string Sector { get; set; }
        public double? TotalInterest { get; set; }
        public double? Interestexp { get; set; }
        public DateTime? DateCreated { get; set; }
        public double? TreasuryProfitLoan { get; set; }
        public double? ProfitPercentage { get; set; }
    }
}
