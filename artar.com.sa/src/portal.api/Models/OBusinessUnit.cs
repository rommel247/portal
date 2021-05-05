using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OBusinessUnit
    {
        public int Id { get; set; }
        public string BusinessUnit { get; set; }
        public int? OrganizationId { get; set; }
    }
}
