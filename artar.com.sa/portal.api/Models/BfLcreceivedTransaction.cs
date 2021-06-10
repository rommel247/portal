using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcreceivedTransaction
    {
        public int Masterid { get; set; }
        public string Lcno { get; set; }
        public DateTime Receivedate { get; set; }
        public double? AmountofPayment { get; set; }
        public string Datecreated { get; set; }
        public string Invoiceno { get; set; }
    }
}
