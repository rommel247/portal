using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcGoodsinTransit
    {
        public int Id { get; set; }
        public string Lcno { get; set; }
        public int? Draftfromid { get; set; }
        public int? Draft { get; set; }
        public int Shipno { get; set; }
        public int Goodsid { get; set; }
        public DateTime Shipmentdate { get; set; }
        public double? Qty { get; set; }
        public string Unit { get; set; }
        public double? Totalprice { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Modifyby { get; set; }
        public DateTime? Datemodified { get; set; }
    }
}
