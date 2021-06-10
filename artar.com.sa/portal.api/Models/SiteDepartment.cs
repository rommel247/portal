using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteDepartment
    {
        public int DepartmentId { get; set; }
        public string SiteCode { get; set; }
        public string DepartmentName { get; set; }
        public int? Mode { get; set; }
        public string Title { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Gperiod { get; set; }
        public string DayOff { get; set; }
        public string Subject { get; set; }
        public string BodyStyle { get; set; }
        public string HeaderText { get; set; }
        public string ThSummary { get; set; }
        public string TdSummary { get; set; }
        public string ThDetails { get; set; }
        public string TdDetails { get; set; }
        public string TotalingFooter { get; set; }
        public int? FkDepartmentId { get; set; }
        public string Language { get; set; }
        public string Oddrow { get; set; }
        public string Evenrow { get; set; }
        public string FullNameAr { get; set; }
        public string DepartmentNameAr { get; set; }
        public string PayrollEmail { get; set; }
    }
}
