using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfCompanySn
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? StartSeries { get; set; }
        public int? Zeros { get; set; }
    }
}
