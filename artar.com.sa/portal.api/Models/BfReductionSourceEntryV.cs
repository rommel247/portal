using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfReductionSourceEntryV
    {
        public int LoanmasterId { get; set; }
        public int Sourceid { get; set; }
        public string Sourcename { get; set; }
        public double? Amount { get; set; }
        public DateTime Dateofreduction { get; set; }
        public string CategoryName { get; set; }
        public int? LoanCategoryId { get; set; }
    }
}
