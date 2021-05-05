using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class GetAllTicket
    {
        public int Cid { get; set; }
        public int? Id { get; set; }
        public string EmployeeCode { get; set; }
        public int? Xstatus { get; set; }
        public string Support { get; set; }
        public string XstatusDesc { get; set; }
        public string EmployeeNameEng { get; set; }
        public string DepartmentNameEng { get; set; }
        public string ProblemType { get; set; }
        public string ProblemDesc { get; set; }
        public string Extension { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public string Ip { get; set; }
        public string HostName { get; set; }
        public string Attachment { get; set; }
        public string Email { get; set; }
        public string EmployeeNameArab { get; set; }
        public string DepartmentNameArab { get; set; }
        public string NotesA { get; set; }
        public string NotesS { get; set; }
        public int? Rate { get; set; }
        public string DateForwardA { get; set; }
        public string Admin { get; set; }
    }
}
