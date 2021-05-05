using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLoanPurposeEntryView
    {
        public string Companysn { get; set; }
        public int Loanpurposeid { get; set; }
        public string Description { get; set; }
        public double? Amount { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public int? LoanCategoryId { get; set; }
        public string LoanCategory { get; set; }
    }
}
