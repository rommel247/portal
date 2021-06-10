using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfPaymentSourceEntryV
    {
        public int LoanmasterId { get; set; }
        public int Sourceid { get; set; }
        public string Sourcename { get; set; }
        public double? Amount { get; set; }
        public int Loancategoryid { get; set; }
        public string CategoryName { get; set; }
    }
}
