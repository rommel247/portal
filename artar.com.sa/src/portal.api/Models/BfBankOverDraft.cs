using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfBankOverDraft
    {
        public string Bankid { get; set; }
        public int Categoryid { get; set; }
        public DateTime Date { get; set; }
        public double? Overdraftbalance { get; set; }
        public double? Rate { get; set; }
        public double? Creditlimit { get; set; }
        public int OverDraftPurposeid { get; set; }
        public int Id { get; set; }
        public int? Accountnoid { get; set; }
        public int? Operatingnoid { get; set; }
        public int? Projectid { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Modifiedby { get; set; }
        public int Sectorid { get; set; }
    }
}
