using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteDuty
    {
        public int Id { get; set; }
        public string SiteCode { get; set; }
        public int DepartmentId { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime DutyDate { get; set; }
        public string DutyShift { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Createdby { get; set; }
        public string LastModify { get; set; }
        public DateTime? LastDateModify { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string DutyShiftDesc { get; set; }
    }
}
