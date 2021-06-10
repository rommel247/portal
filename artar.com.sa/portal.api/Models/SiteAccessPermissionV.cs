using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteAccessPermissionV
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Sitecode { get; set; }
        public int Departmentid { get; set; }
        public string DepartmentName { get; set; }
        public string Createdby { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
