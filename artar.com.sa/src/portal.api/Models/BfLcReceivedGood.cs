using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcReceivedGood
    {
        public int Id { get; set; }
        public int Masterid { get; set; }
        public int Transactionid { get; set; }
        public int GoodsMasterkey { get; set; }
        public int? Qtyreceive { get; set; }
        public string Lcno { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public DateTime Receivedate { get; set; }
        public string Invoiceno { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Datemodified { get; set; }
        public int? Shipno { get; set; }
    }
}
