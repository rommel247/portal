using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcGoodsinTransitView
    {
        public int Id { get; set; }
        public string Lcno { get; set; }
        public int Shipno { get; set; }
        public int Goodsid { get; set; }
        public string Descriptionofgoods { get; set; }
        public DateTime Shipmentdate { get; set; }
        public double? Qty { get; set; }
        public string Unitcode { get; set; }
        public double? Totalprice { get; set; }
    }
}
