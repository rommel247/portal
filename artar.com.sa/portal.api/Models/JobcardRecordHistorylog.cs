using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardRecordHistorylog
    {
        public int? Id { get; set; }
        public string Support { get; set; }
        public int? Status { get; set; }
        public string Remarks { get; set; }
        public string DateForwardA { get; set; }
        public string DateSubmitted { get; set; }
        public string Admin { get; set; }
        public int? Rate { get; set; }
        public string NotesA { get; set; }
        public string NotesS { get; set; }
        public int? Cid { get; set; }
        public int? ControlId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeNameEng { get; set; }
        public string DepartmentNameEng { get; set; }
        public string ProblemDesc { get; set; }
        public string Extension { get; set; }
        public DateTime? PrDataSubmitted { get; set; }
        public string Ip { get; set; }
        public string HostName { get; set; }
        public string Email { get; set; }
        public string ProblemType { get; set; }
        public string Supportfullname { get; set; }
    }
}
