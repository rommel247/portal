using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SubModulesType
    {
        public int SubModuleId { get; set; }
        public int ModuleId { get; set; }
        public string ModuleDescEn { get; set; }
        public string ModuleDescAr { get; set; }
    }
}
