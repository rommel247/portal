using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfUtilizationLgV
    {
        public string TrxCard { get; set; }
        public string TrxName { get; set; }
        public int Entryno { get; set; }
        public int Categoryid { get; set; }
        public int? Lgcategoryid { get; set; }
        public int Bankid { get; set; }
        public int? Projectid { get; set; }
        public int? Accountnoid { get; set; }
        public double? TrxAmount { get; set; }
        public DateTime TrxDate { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
