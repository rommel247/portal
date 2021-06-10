using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class WorkflowEeClearance
    {
        public WorkflowEeClearance()
        {
            WorkflowEeDepts = new HashSet<WorkflowEeDept>();
        }

        public string Idno { get; set; }
        public DateTime? DateEnd { get; set; }
        public string PrintedBy { get; set; }
        public DateTime? LastDatePrinted { get; set; }
        public string MobileNo { get; set; }

        public virtual ICollection<WorkflowEeDept> WorkflowEeDepts { get; set; }
    }
}
