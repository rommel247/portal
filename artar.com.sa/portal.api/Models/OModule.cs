using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OModule
    {
        public int Id { get; set; }
        public string Module { get; set; }
        public string ModuleDescription { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Createdby { get; set; }
        public DateTime? LastDateModify { get; set; }
        public string LastModify { get; set; }
        public int BusinessUnit { get; set; }
        public string ManagementCode { get; set; }
    }
}
