using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int? UserGroup { get; set; }
    }
}
