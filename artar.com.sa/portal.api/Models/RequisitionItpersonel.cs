using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class RequisitionItpersonel
    {
        public int Id { get; set; }
        public string Emailto { get; set; }
        public string Emailcc { get; set; }
        public string Emailbcc { get; set; }
        public string Name { get; set; }
    }
}
