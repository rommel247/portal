using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ORequestor
    {
        public int Id { get; set; }
        public string EmpCode { get; set; }
        public int BuId { get; set; }
    }
}
