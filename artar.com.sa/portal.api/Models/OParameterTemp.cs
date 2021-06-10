using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OParameterTemp
    {
        public int? Parameterid { get; set; }
        public string Parameter { get; set; }
        public string ParameterDescription { get; set; }
        public DateTime? Datetimestamp { get; set; }
        public string Requestorcode { get; set; }
    }
}
