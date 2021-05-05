using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class WorkflowEeDeptList
    {
        public string Idno { get; set; }
        public string DeptName { get; set; }
        public string DeptHead { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public string DeptEmail { get; set; }
        public string DeptHead1 { get; set; }
    }
}
