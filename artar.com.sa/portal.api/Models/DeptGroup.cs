using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class DeptGroup
    {
        public int DepartmentId { get; set; }
        public string DirectManagerId { get; set; }
    }
}
