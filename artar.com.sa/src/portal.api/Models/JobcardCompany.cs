using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardCompany
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public int? Sequence { get; set; }
    }
}
