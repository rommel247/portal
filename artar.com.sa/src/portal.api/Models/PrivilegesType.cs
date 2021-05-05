using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class PrivilegesType
    {
        public int PrivilegeId { get; set; }
        public string PrivilegeDescriptionEn { get; set; }
        public string PrivilegeDescriptionAr { get; set; }
    }
}
