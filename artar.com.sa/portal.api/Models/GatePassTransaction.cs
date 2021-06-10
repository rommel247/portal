using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class GatePassTransaction
    {
        public int Tid { get; set; }
        public int? Gpn { get; set; }
        public string ItemDesc { get; set; }
        public string ItemQty { get; set; }
        public string Remarks { get; set; }
        public string Gpnseries { get; set; }
    }
}
