using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OProcessStep
    {
        public int Id { get; set; }
        public int BusinessUnitId { get; set; }
        public int ModuleId { get; set; }
        public string StepDescription { get; set; }
        public string EmployeeId { get; set; }
        public string ResponsiblePerson { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Createdby { get; set; }
        public DateTime? LastDateModify { get; set; }
        public string LastModify { get; set; }
    }
}
