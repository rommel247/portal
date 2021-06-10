using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfBank
    {
        public int Id { get; set; }
        public string BankLetters { get; set; }
        public string BankNames { get; set; }
        public string AccNo { get; set; }
        public string Iban { get; set; }
        public string SwiftCode { get; set; }
        public bool? Isarchived { get; set; }
        public string Accountname { get; set; }
        public string Currency { get; set; }
    }
}
