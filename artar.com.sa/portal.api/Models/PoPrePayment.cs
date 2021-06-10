using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class PoPrePayment
    {
        public int Id { get; set; }
        public string Poid { get; set; }
        public string Serialnumber { get; set; }
        public string Paymentto { get; set; }
        public double? Prepaymentamount { get; set; }
        public string Reason { get; set; }
        public double? Remainingamount { get; set; }
        public string Paymentmethod { get; set; }
        public string Authorizedby { get; set; }
        public string Orderby { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Lastmodified { get; set; }
        public DateTime? Lastmodifieddate { get; set; }
        public string Approvedrequest { get; set; }
        public string Bankcode { get; set; }
        public string Collectingchequeplace { get; set; }
        public string Lang { get; set; }
        public double? Totalamount { get; set; }
    }
}
