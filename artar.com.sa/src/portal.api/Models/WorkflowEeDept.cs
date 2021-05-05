using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class WorkflowEeDept
    {
        public string Idno { get; set; }
        public string DeptName { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public int Id { get; set; }
        public string Notes { get; set; }
        public string ManagerName { get; set; }

        public virtual WorkflowEeClearance IdnoNavigation { get; set; }
    }
}
