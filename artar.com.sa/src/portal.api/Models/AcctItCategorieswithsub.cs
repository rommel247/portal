using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class AcctItCategorieswithsub
    {
        public int IdCategory { get; set; }
        public string Description { get; set; }
        public int IdCd { get; set; }
        public string SubcategoryDesc { get; set; }
    }
}
