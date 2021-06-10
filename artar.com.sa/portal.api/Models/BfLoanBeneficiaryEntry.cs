using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLoanBeneficiaryEntry
    {
        public int Id { get; set; }
        public string Companysn { get; set; }
        public int Bankid { get; set; }
        public int Loanbeneficiaryid { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datecreated { get; set; }
    }
}
