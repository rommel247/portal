using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ActiveNavUser
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string EmployeeCode { get; set; }
        public string Company { get; set; }
        public string Status { get; set; }
        public string Source { get; set; }
        public string Status1 { get; set; }
        public string ForVerification { get; set; }
        public DateTime? Datecreated { get; set; }
    }
}
