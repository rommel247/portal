using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfPfsHeaderV
    {
        public int MasterId { get; set; }
        public int Projectid { get; set; }
        public string Categoryid { get; set; }
        public double? Creditlimit { get; set; }
        public string Project { get; set; }
        public string Category { get; set; }
        public string BankLetters { get; set; }
        public int Groupid { get; set; }
    }
}
