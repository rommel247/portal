using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class UserGroup
    {
        public int Id { get; set; }
        public string GroupDescEn { get; set; }
        public string GroupDescAr { get; set; }
    }
}
