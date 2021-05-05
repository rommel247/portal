using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfTransferHistory
    {
        public int Id { get; set; }
        public int LoanmasterId { get; set; }
        public double? LoanAmount { get; set; }
        public DateTime DateofTransfer { get; set; }
        public DateTime? EndingDate { get; set; }
        public int LoanPurposeId { get; set; }
        public string LoanPurpose { get; set; }
        public int? FromSectorid { get; set; }
        public string FromSector { get; set; }
        public int TransfertoSectorid { get; set; }
        public string TransfertoSector { get; set; }
        public double? LifeTimedays { get; set; }
        public DateTime? GrantingDate { get; set; }
        public DateTime? RepaymentDate { get; set; }
        public int ProjectNameid { get; set; }
        public string ProjectName { get; set; }
        public string Notes { get; set; }
        public string Creator { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CompanySn { get; set; }
        public double? SiborRate { get; set; }
        public double? TotalInterest { get; set; }
        public double? InterestExp { get; set; }
        public double? TotalInterestExp { get; set; }
        public string Transactionname { get; set; }
    }
}
