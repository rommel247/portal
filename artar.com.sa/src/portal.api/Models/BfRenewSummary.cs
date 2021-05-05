using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfRenewSummary
    {
        public int LoanmasterId { get; set; }
        public string TransactionName { get; set; }
        public double? LoanAmount { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime Endingdate { get; set; }
        public double? SiborRate { get; set; }
        public string Sector { get; set; }
        public double? TotalInterest { get; set; }
        public double? InterestexpMaster { get; set; }
        public DateTime? DateCreated { get; set; }
        public int Id { get; set; }
        public double? Interestexp { get; set; }
        public double? TreasuryProfitLoan { get; set; }
    }
}
