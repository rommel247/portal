using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLgMaster
    {
        public int Id { get; set; }
        public string LgNo { get; set; }
        public int Issuingbankid { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double LgAmount { get; set; }
        public int? LgTypeid { get; set; }
        public int? Categoryid { get; set; }
        public int? LgPurposeid { get; set; }
        public string BeneficiaryName { get; set; }
        public int? ProjectNameid { get; set; }
        public int? Sectorid { get; set; }
        public double? ProjectAmount { get; set; }
        public string Notes { get; set; }
        public string LgCopy { get; set; }
        public string ScanSwift { get; set; }
        public int? Lgcategoryid { get; set; }
        public string Username { get; set; }
        public DateTime? Datecreated { get; set; }
        public int? Accountnoid { get; set; }
        public string Modifyby { get; set; }
        public DateTime? Datemodified { get; set; }
        public int? Operatingnoid { get; set; }
        public string Companysn { get; set; }
        public int? Mstatus { get; set; }
        public string Msetstatusby { get; set; }
        public DateTime? Mdate { get; set; }
    }
}
