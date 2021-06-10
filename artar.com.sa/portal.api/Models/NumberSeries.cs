using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class NumberSeries
    {
        public int Id { get; set; }
        public string Module { get; set; }
        public string Code { get; set; }
        public int? Startseries { get; set; }
        public int? Numberofzeros { get; set; }
        public int? Lastnumberused { get; set; }
    }
}
