using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfNewSummary
    {
        public int LoanMasterId { get; set; }
        public string Transactionname { get; set; }
        public double? LoanAmount { get; set; }
        public DateTime? Startingdate { get; set; }
        public DateTime? Endingdate2 { get; set; }
        public double? SiborRate { get; set; }
        public string Sector { get; set; }
        public double? TotalInterest { get; set; }
        public double? InterestExp2 { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? Endingdate { get; set; }
        public double? InterestExp { get; set; }
        public double? TreasuryProfitLoan { get; set; }
        public double? TreasuryMargin { get; set; }
        public DateTime GrandtingDate { get; set; }
    }
}
