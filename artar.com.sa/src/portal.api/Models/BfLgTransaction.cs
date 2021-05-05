using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLgTransaction
    {
        public int Id { get; set; }
        public string Companysn { get; set; }
        public string Transactionname { get; set; }
        public string Lgno { get; set; }
        public string Bankletter { get; set; }
        public int? Accountnoid { get; set; }
        public int? Operatingnoid { get; set; }
        public DateTime? Issuancedate { get; set; }
        public DateTime? Expirydate { get; set; }
        public double? Lgbalance { get; set; }
        public int? Lgtypeid { get; set; }
        public int? Lgcategoryid { get; set; }
        public string Beneficiaryname { get; set; }
        public int? Projectid { get; set; }
        public double? Projectamount { get; set; }
        public int? Sectorid { get; set; }
        public DateTime DateRir { get; set; }
        public double? AmountofRir { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Modifiedby { get; set; }
        public string Notes { get; set; }
        public string Swiftcopy { get; set; }
        public int Lgmasterid { get; set; }
    }
}
