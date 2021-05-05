using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcListofGoodsView
    {
        public int Id { get; set; }
        public int Masterid { get; set; }
        public string Descriptionofgoods { get; set; }
        public int? Qty { get; set; }
        public string Unitcode { get; set; }
        public double? Priceperunit { get; set; }
        public int? Receivedqty { get; set; }
        public double? Totalpricereceived { get; set; }
        public int? Remainingqty { get; set; }
        public double? Remainingamount { get; set; }
        public double? Totalprice { get; set; }
        public string Lcno { get; set; }
    }
}
