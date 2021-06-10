using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfBankList
    {
        public int Id { get; set; }
        public string BankLetters { get; set; }
        public string BankNames { get; set; }
        public int? Tenure { get; set; }
    }
}
