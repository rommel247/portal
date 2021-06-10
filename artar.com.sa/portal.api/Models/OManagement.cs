using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OManagement
    {
        public int Id { get; set; }
        public string ManagementTitle { get; set; }
        public string ManagementDescription { get; set; }
        public string Code { get; set; }
    }
}
