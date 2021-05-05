using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public int? DepId { get; set; }
        public string DepNameDesc { get; set; }
    }
}
