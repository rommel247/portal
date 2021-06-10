using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class VisaTbl1
    {
        public int Id { get; set; }
        public int? VisaId { get; set; }
        public string Gdate { get; set; }
        public string Hdate { get; set; }
        public int? Vquantity { get; set; }
        public int? ReqId { get; set; }
    }
}
