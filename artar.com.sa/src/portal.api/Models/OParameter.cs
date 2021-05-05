using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OParameter
    {
        public int Parameterid { get; set; }
        public string Parameter { get; set; }
        public string ParameterDescription { get; set; }
        public int Reportid { get; set; }
    }
}
