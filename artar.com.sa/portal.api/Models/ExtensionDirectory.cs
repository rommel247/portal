using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ExtensionDirectory
    {
        public string ExtNo { get; set; }
        public string Port { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Floor { get; set; }
        public string MenaId { get; set; }
        public bool? Hide { get; set; }
        public string DescriptionEn { get; set; }
        public string DepartmentEn { get; set; }
    }
}
