using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcListofGood
    {
        public int Id { get; set; }
        public int Masterid { get; set; }
        public string Companysn { get; set; }
        public string Descriptionofgoods { get; set; }
        public int? Qty { get; set; }
        public double? Priceperunit { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Unitcode { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Lcno { get; set; }
    }
}
