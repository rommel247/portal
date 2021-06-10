using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLoanReductionView
    {
        public int ProjectNameId { get; set; }
        public int LoanCategoryId { get; set; }
        public int Bankid { get; set; }
        public DateTime DateofReduction { get; set; }
        public double ReductionAmount { get; set; }
        public string Transactionname { get; set; }
        public int Entryno { get; set; }
        public double? LoanAmount { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
