using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class Transtrack1
    {
        public int? JobOrderNumber { get; set; }
        public string PlaceDesc { get; set; }
        public string Expr1 { get; set; }
        public DateTime? JobDate { get; set; }
        public string JobTime { get; set; }
    }
}
