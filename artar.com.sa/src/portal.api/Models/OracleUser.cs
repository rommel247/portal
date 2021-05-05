using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OracleUser
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public int? Usercount { get; set; }
    }
}
