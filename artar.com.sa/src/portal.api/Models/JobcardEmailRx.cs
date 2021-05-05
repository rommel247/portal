using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardEmailRx
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string Email { get; set; }
        public int? Rx { get; set; }
        public string EmployeeName { get; set; }
        public string Username { get; set; }
        public int? IsOracleSupport { get; set; }
    }
}
