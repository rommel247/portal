using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfGeneralLine
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public int Categoryid { get; set; }
        public double? Creditlimit { get; set; }
        public double? Utilized { get; set; }
        public double? Rate { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public int? Bankid { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Modifyby { get; set; }
        public string AccountNo { get; set; }
        public string Bankletters { get; set; }
        public int AccountNoid { get; set; }
        public int Lgcategoryid { get; set; }
        public double? Lccreditlimit { get; set; }
        public double? Loancreditlimit { get; set; }
        public double? Subcreditlimit { get; set; }
        public int? Groupid { get; set; }
        public int? Lifetimedays { get; set; }
        public string Sector { get; set; }
    }
}
