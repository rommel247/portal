using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfGeneralLineView2
    {
        public int? Id { get; set; }
        public string CategoryName { get; set; }
        public int? Categoryid { get; set; }
        public int? MasterId { get; set; }
        public double? Creditlimit { get; set; }
        public double? Utilized { get; set; }
        public double? Rate { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public string Modifyby { get; set; }
        public DateTime? Datemodified { get; set; }
        public double? Percentage { get; set; }
        public DateTime Validfrom { get; set; }
        public DateTime Validto { get; set; }
        public bool? IsInactive { get; set; }
        public bool? Def { get; set; }
        public string BankNames { get; set; }
        public int? Bankid { get; set; }
        public string BankLetters { get; set; }
        public string AccountNoold { get; set; }
        public string AccountNo { get; set; }
        public string Accountname { get; set; }
        public int? AccountNoid { get; set; }
        public int? Lgcategoryid { get; set; }
        public string Lgcategory { get; set; }
        public double? Lccreditlimit { get; set; }
        public double? Loancreditlimit { get; set; }
        public double? Subcreditlimit { get; set; }
        public int Groupid { get; set; }
        public double? Availableforuse { get; set; }
        public int? Lifetimedays { get; set; }
        public string Sector { get; set; }
    }
}
