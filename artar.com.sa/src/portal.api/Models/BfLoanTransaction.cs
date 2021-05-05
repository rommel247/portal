using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLoanTransaction
    {
        public int Id { get; set; }
        public int LoanMasterId { get; set; }
        public double? ReductionAmount { get; set; }
        public DateTime DateofReduction { get; set; }
        public string NotesReduction { get; set; }
        public string LettercopyReduction { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Creator { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Modifyby { get; set; }
        public string CompanySn { get; set; }
        public int? Actionid { get; set; }
        public bool? IsArchived { get; set; }
    }
}
