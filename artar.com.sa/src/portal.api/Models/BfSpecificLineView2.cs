using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfSpecificLineView2
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public double? Creditlimit { get; set; }
        public double? Utilized { get; set; }
        public double? Rate { get; set; }
        public string Category { get; set; }
        public double? Availableforuse { get; set; }
        public double? Percentage { get; set; }
        public DateTime Validfrom { get; set; }
        public DateTime Validto { get; set; }
        public int Projectid { get; set; }
        public int Categoryid { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Createdby { get; set; }
        public string Modifyby { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? IsInactive { get; set; }
        public string Project { get; set; }
        public string AccountNo { get; set; }
        public string BankNames { get; set; }
        public string BankLetters { get; set; }
        public int Bankid { get; set; }
        public int Accountnoid { get; set; }
        public string AccNo { get; set; }
        public string Accountname { get; set; }
        public int Lgcategoryid { get; set; }
        public string Lgcategory { get; set; }
        public double? Lccreditlimit { get; set; }
        public double? Loancreditlimit { get; set; }
        public double? Subcreditlimit { get; set; }
        public int Groupid { get; set; }
        public int? Lifetimedays { get; set; }
        public string Sector { get; set; }
    }
}
