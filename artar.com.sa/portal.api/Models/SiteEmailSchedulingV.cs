using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteEmailSchedulingV
    {
        public int Id { get; set; }
        public string SitecodeGroup { get; set; }
        public string SitecodeGroupName { get; set; }
        public string Timeofexecution { get; set; }
        public string ExecuteExemption { get; set; }
        public string Recurrence { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Creator { get; set; }
        public DateTime? Lastmodified { get; set; }
        public string Modifyby { get; set; }
        public int? Days { get; set; }
        public int? Isgrouped { get; set; }
        public int? Nthday { get; set; }
        public string NextExecution { get; set; }
    }
}
