using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfSpecificLine
    {
        public int Id { get; set; }
        public int Masterid { get; set; }
        public int Projectid { get; set; }
        public int Categoryid { get; set; }
        public double? Creditlimit { get; set; }
        public double? Utilized { get; set; }
        public double? Rate { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Createdby { get; set; }
        public string Modifyby { get; set; }
        public DateTime? DateModified { get; set; }
        public string AccountNo { get; set; }
        public int Lgcategoryid { get; set; }
        public int Accountnoid { get; set; }
        public double? Lccreditlimit { get; set; }
        public double? Loancreditlimit { get; set; }
        public double? Subcreditlimit { get; set; }
        public int? Groupid { get; set; }
        public int? Lifetimedays { get; set; }
        public string Sector { get; set; }
    }
}
