using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class PoUnitPermission
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Unit { get; set; }
        public int? Viewall { get; set; }
        public int? ViewPo { get; set; }
        public int? ViewPrepayment { get; set; }
    }
}
