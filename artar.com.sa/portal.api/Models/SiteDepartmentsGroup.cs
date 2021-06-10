using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteDepartmentsGroup
    {
        public int Id { get; set; }
        public string Sitecode { get; set; }
        public int Departmentid { get; set; }
        public string DirectmanagerCode { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Creator { get; set; }
        public int? Mode { get; set; }
    }
}
