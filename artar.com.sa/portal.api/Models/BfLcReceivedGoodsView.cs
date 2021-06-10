using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcReceivedGoodsView
    {
        public int Id { get; set; }
        public int Masterid { get; set; }
        public string Companysn { get; set; }
        public string Lcno { get; set; }
        public int Transactionid { get; set; }
        public DateTime Receivedate { get; set; }
        public string Invoiceno { get; set; }
        public string Descriptionofgoods { get; set; }
        public int GoodsMasterkey { get; set; }
        public int? Qtyreceive { get; set; }
        public string Unitcode { get; set; }
        public double? Priceperunit { get; set; }
        public double? Totalpricereceived { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public int Descriptionofgoodsid { get; set; }
    }
}
