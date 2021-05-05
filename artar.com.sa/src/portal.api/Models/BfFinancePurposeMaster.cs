using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFinancePurposeMaster
    {
        public int Id { get; set; }
        public string Purpose { get; set; }
        public int? Orderid { get; set; }
    }
}
