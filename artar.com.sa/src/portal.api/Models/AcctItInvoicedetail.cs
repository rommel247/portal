using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class AcctItInvoicedetail
    {
        public int? Id { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int? Qty { get; set; }
        public string Unit { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Discount { get; set; }
        public int Idsorting { get; set; }
        public string Note { get; set; }
        public decimal? ItemAmount { get; set; }
        public string UserId { get; set; }
    }
}
