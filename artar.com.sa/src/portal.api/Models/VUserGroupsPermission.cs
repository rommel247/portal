using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class VUserGroupsPermission
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string GroupDescEn { get; set; }
        public string ModuleDescriptionEn { get; set; }
        public string ModuleDescEn { get; set; }
        public string PrivilegeDescriptionEn { get; set; }
        public bool HasPermission { get; set; }
    }
}
