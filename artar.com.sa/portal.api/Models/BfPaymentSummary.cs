using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfPaymentSummary
    {
        public int LoanmasterId { get; set; }
        public string Transactionname { get; set; }
        public double Loanamount { get; set; }
        public DateTime Startingdate { get; set; }
        public DateTime Endingdate { get; set; }
        public int Siborrate { get; set; }
        public double? TotalInterest { get; set; }
        public double? InterestExp { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Sector { get; set; }
        public int Id { get; set; }
    }
}
