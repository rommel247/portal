using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardOraclesubCategory
    {
        public int Id { get; set; }
        public int Categoryfkid { get; set; }
        public string Subcategoryname { get; set; }
    }
}
