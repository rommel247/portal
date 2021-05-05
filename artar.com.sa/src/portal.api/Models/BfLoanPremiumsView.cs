using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLoanPremiumsView
    {
        public int Id { get; set; }
        public int LoanmasterId { get; set; }
        public DateTime Premdate { get; set; }
        public double? Premamount { get; set; }
        public string Status { get; set; }
        public DateTime? Dateofpayment { get; set; }
        public int? Alertdays { get; set; }
        public DateTime Datecreated { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Createdby { get; set; }
        public string Modifyby { get; set; }
        public double? Loanbalance { get; set; }
        public string CompanySn { get; set; }
        public int ProjectNameId { get; set; }
        public string ProjectName { get; set; }
        public int? Year { get; set; }
        public DateTime? Datepaid { get; set; }
    }
}
