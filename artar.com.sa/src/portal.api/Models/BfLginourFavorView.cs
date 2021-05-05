using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLginourFavorView
    {
        public int Id { get; set; }
        public string Lgno { get; set; }
        public int? Bankid { get; set; }
        public string Bankcode { get; set; }
        public string Bankname { get; set; }
        public string Applicant { get; set; }
        public DateTime? Datetoestab { get; set; }
        public int? Guaranteetypeid { get; set; }
        public string Guaranteetype { get; set; }
        public double? Amount { get; set; }
        public DateTime? Dateofexpiry { get; set; }
        public int? BusinessunitId { get; set; }
        public string Businessunit { get; set; }
        public int? Costcenterid { get; set; }
        public string CostCenter { get; set; }
        public int? Projectid { get; set; }
        public string Projects { get; set; }
        public string Respectof { get; set; }
        public string Notes { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Modifyby { get; set; }
        public DateTime? Datemodified { get; set; }
    }
}
