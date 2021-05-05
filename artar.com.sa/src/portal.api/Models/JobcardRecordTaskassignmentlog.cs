using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardRecordTaskassignmentlog
    {
        public int ControlId { get; set; }
        public string EmployeeCode { get; set; }
        public string ProblemType { get; set; }
        public string DepartmentNameEng { get; set; }
        public string NotesS { get; set; }
        public string NotesA { get; set; }
        public int? Rate { get; set; }
        public string Admin { get; set; }
        public string DateSubmitted { get; set; }
        public string DateForwardA { get; set; }
        public int? Status { get; set; }
        public string Support { get; set; }
        public string Extension { get; set; }
        public string ProblemDesc { get; set; }
        public DateTime? PrDateSubmitted { get; set; }
        public string EmployeeNameEng { get; set; }
        public string Ip { get; set; }
        public string HostName { get; set; }
    }
}
