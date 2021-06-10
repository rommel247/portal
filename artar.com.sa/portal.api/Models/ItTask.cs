using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ItTask
    {
        public int? Cid { get; set; }
        public string DateForwardA { get; set; }
        public string Support { get; set; }
        public int? Status { get; set; }
        public string ProblemType { get; set; }
    }
}
