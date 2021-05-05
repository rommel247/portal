using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ModuleAndPrivilege
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ModuleId { get; set; }
        public int? PrivilegeId { get; set; }
        public int? SubModuleId { get; set; }
    }
}
