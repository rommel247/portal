using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class GatePassMaster
    {
        public int Gpn { get; set; }
        public DateTime? Gpndate { get; set; }
        public string EmpName { get; set; }
        public string ResEmployee { get; set; }
        public string Gpnseries { get; set; }
        public string Empcode { get; set; }
    }
}
