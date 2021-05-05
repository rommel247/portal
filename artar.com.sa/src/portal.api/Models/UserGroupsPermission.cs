using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class UserGroupsPermission
    {
        public int UserGroupId { get; set; }
        public int ModuleId { get; set; }
        public int SubModuleId { get; set; }
        public int PrivilegeId { get; set; }
        public bool HasPermission { get; set; }
        public int Id { get; set; }
    }
}
