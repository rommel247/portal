using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfReductionTransaction
    {
        public int Id { get; set; }
        public int LoanMasterId { get; set; }
        public double ReductionAmount { get; set; }
        public DateTime DateofReduction { get; set; }
        public DateTime? Endingdate { get; set; }
        public double? InterestExp { get; set; }
        public int? Sectorid { get; set; }
        public string Sector { get; set; }
        public DateTime? Grantingdate { get; set; }
        public DateTime? Repaymentdate { get; set; }
        public double? Creditlimit { get; set; }
        public string NotesReduction { get; set; }
        public string LettercopyReduction { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Creator { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Modifyby { get; set; }
        public string CompanySn { get; set; }
        public int? Actionid { get; set; }
        public bool? IsArchived { get; set; }
        public string Transaction { get; set; }
        public double? LoanBalance { get; set; }
        public double? LoanAmount { get; set; }
        public double? Siborrate { get; set; }
        public double? Facilityrate { get; set; }
        public double? TreasuryMargin { get; set; }
        public int? Sourceid { get; set; }
    }
}
