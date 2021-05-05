using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardEmployeeInfo
    {
        public int ControlId { get; set; }
        public string EmpCode { get; set; }
        public string Ext { get; set; }
        public string Email { get; set; }
    }
}
