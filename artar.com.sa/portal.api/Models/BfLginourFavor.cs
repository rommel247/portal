using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLginourFavor
    {
        public int Id { get; set; }
        public string Lgno { get; set; }
        public int? Bankid { get; set; }
        public string Applicant { get; set; }
        public DateTime? Datetoestab { get; set; }
        public int? Guaranteetypeid { get; set; }
        public double? Amount { get; set; }
        public DateTime? Dateofexpiry { get; set; }
        public int? BusinessunitId { get; set; }
        public int? Costcenterid { get; set; }
        public int? Projectid { get; set; }
        public string Respectof { get; set; }
        public string Notes { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Modifyby { get; set; }
        public DateTime? Datemodified { get; set; }
    }
}
