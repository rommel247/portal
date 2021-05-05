using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfRenewTransaction
    {
        public int Id { get; set; }
        public int LoanmasterId { get; set; }
        public double? LoanAmount { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public double? SiborRate { get; set; }
        public double? FacilityRate { get; set; }
        public double? TotalInterest { get; set; }
        public double? InterestExp { get; set; }
        public int? Sectorid { get; set; }
        public string Sector { get; set; }
        public double? TreasuryMargin { get; set; }
        public double? TreasuryProfit { get; set; }
        public double? ChargedCost { get; set; }
        public DateTime? GrantingDate { get; set; }
        public DateTime? RepaymentDate { get; set; }
        public double? CreditLimit { get; set; }
        public string Notes { get; set; }
        public string LetterCopy { get; set; }
        public DateTime? DateCreation { get; set; }
        public string Creator { get; set; }
        public string Transaction { get; set; }
        public string Companysn { get; set; }
        public DateTime? EndingdateTemp { get; set; }
        public string LoanNoNew { get; set; }
    }
}
