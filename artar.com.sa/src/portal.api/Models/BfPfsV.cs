using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfPfsV
    {
        public string Transactionname { get; set; }
        public string BankLetters { get; set; }
        public string Project { get; set; }
        public string Category { get; set; }
        public double? Creditlimit { get; set; }
        public DateTime? Xdate { get; set; }
        public double? Xamount { get; set; }
        public int Bankid { get; set; }
        public int? ProjectNameId { get; set; }
        public string Categoryid { get; set; }
        public int Groupid { get; set; }
        public int Entryno { get; set; }
        public double? Originalamount { get; set; }
        public DateTime? Datecreated { get; set; }
    }
}
