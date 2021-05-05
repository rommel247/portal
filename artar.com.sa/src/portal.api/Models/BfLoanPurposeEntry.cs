using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLoanPurposeEntry
    {
        public int Id { get; set; }
        public string Companysn { get; set; }
        public int Bankid { get; set; }
        public int Loanpurposeid { get; set; }
        public double? Amount { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Modifyby { get; set; }
        public DateTime? Datemodified { get; set; }
        public int? Beneficiarysectorid { get; set; }
        public int? Sectorid { get; set; }
    }
}
