using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLgMasterView
    {
        public int Id { get; set; }
        public string LgNo { get; set; }
        public int Issuingbankid { get; set; }
        public DateTime? Issuancedate { get; set; }
        public DateTime? Expirydate { get; set; }
        public double LgAmount { get; set; }
        public double? LgBalance { get; set; }
        public int? LgTypeid { get; set; }
        public string BeneficiaryName { get; set; }
        public int? ProjectNameid { get; set; }
        public int? Sectorid { get; set; }
        public double? ProjectAmount { get; set; }
        public string Notes { get; set; }
        public string LgCopy { get; set; }
        public string ScanSwift { get; set; }
        public string Sector { get; set; }
        public string LgType { get; set; }
        public string ProjectName { get; set; }
        public string BankLetters { get; set; }
        public string BankNames { get; set; }
        public string Category { get; set; }
        public int? Categoryid { get; set; }
        public int? Accountnoid { get; set; }
        public int? Operatingnoid { get; set; }
        public int? Lgcategoryid { get; set; }
        public string Operatingno { get; set; }
        public int Mstatus { get; set; }
        public string Msetstatusby { get; set; }
        public string Mstatustext { get; set; }
    }
}
