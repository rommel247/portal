using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteEmployeeInfo
    {
        public int Id { get; set; }
        public string SiteCode { get; set; }
        public int MachineUserId { get; set; }
        public string EmployeeCodeMena { get; set; }
        public int? DepartmentId { get; set; }
        public string Position { get; set; }
        public int Status { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string CreatedBy { get; set; }
        public string LastModify { get; set; }
        public DateTime? LastModifyDatetime { get; set; }
        public string EmployeeNameEng { get; set; }
        public string EmployeeNameArab { get; set; }
        public string DirectManagerCode { get; set; }
        public int? Relegion { get; set; }
    }
}
