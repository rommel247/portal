using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ORemark
    {
        public int Id { get; set; }
        public int? RemarksId { get; set; }
        public string RemarksTitle { get; set; }
    }
}
