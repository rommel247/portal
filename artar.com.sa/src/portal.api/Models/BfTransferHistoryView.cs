using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfTransferHistoryView
    {
        public string CompanySn { get; set; }
        public int Bankid { get; set; }
        public int Id { get; set; }
        public double? LoanAmount { get; set; }
        public int LoanmasterId { get; set; }
        public DateTime DateofTransfer { get; set; }
        public int LoanPurposeId { get; set; }
        public string LoanPurpose { get; set; }
        public string TransfertoSector { get; set; }
        public int TransfertoSectorid { get; set; }
        public double? LifeTimedays { get; set; }
        public DateTime? GrantingDate { get; set; }
        public DateTime? RepaymentDate { get; set; }
        public int ProjectNameid { get; set; }
        public string Notes { get; set; }
        public string ProjectName { get; set; }
        public string LoanNo { get; set; }
        public string Creator { get; set; }
        public DateTime? DateCreated { get; set; }
        public string FromSector { get; set; }
        public int? FromSectorid { get; set; }
    }
}
