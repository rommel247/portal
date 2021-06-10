using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ModulesType
    {
        public int ModuleId { get; set; }
        public string ModuleDescriptionEn { get; set; }
        public string ModuleDescriptionAr { get; set; }
        public string PageDescription { get; set; }
    }
}
