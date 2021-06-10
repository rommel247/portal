using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardProblemrecordn
    {
        public int ControlId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeNameEng { get; set; }
        public string EmployeeNameArab { get; set; }
        public string DepartmentNameEng { get; set; }
        public string DepartmentNameArab { get; set; }
        public string ProblemType { get; set; }
        public string ProblemDesc { get; set; }
        public string Extension { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public string Ip { get; set; }
        public string HostName { get; set; }
        public int? Status { get; set; }
        public string Support { get; set; }
        public string AssignBy { get; set; }
        public bool? Rx { get; set; }
        public string NotesS { get; set; }
        public string NotesA { get; set; }
        public string RemarksS { get; set; }
        public string DateForwardedA { get; set; }
        public string DateForwardedS { get; set; }
        public string Email { get; set; }
        public string Attachment { get; set; }
        public int? Rating { get; set; }
        public int? RateIi { get; set; }
        public int? RateIii { get; set; }
        public string SupportIi { get; set; }
        public string SupportIii { get; set; }
        public string Priority { get; set; }
        public int? Problemtypefkid { get; set; }
        public int? Categoryfkid { get; set; }
        public int? Subcategoryfkid { get; set; }
    }
}
