using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfUserAccessPermissionV
    {
        public string Username { get; set; }
        public int BuId { get; set; }
        public int Usergroupid { get; set; }
        public string UserGroup { get; set; }
        public int ModuleId { get; set; }
        public int SubModuleId { get; set; }
        public string SubModule { get; set; }
        public int PrivilegeId { get; set; }
        public string Priviledge { get; set; }
        public int Id { get; set; }
        public int Entryno { get; set; }
        public string Businessunit { get; set; }
    }
}
