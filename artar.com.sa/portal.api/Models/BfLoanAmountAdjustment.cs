using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLoanAmountAdjustment
    {
        public int Id { get; set; }
        public int BuId { get; set; }
        public int LoanmasterId { get; set; }
        public string Companysn { get; set; }
        public string Loanno { get; set; }
        public double LoanamountOld { get; set; }
        public double LoanamountNew { get; set; }
        public DateTime Dateofchange { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public string Modifiedby { get; set; }
        public string Notes { get; set; }
        public string Attachment { get; set; }
        public int? Sectorid { get; set; }
        public double? Siborrate { get; set; }
        public double? Totalinterest { get; set; }
        public double? Interestexp { get; set; }
    }
}
