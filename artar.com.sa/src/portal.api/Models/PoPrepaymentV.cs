using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class PoPrepaymentV
    {
        public int Id { get; set; }
        public string Poid { get; set; }
        public string Serialnumber { get; set; }
        public string Paymentto { get; set; }
        public double? Prepaymentamount { get; set; }
        public string Reason { get; set; }
        public double? TotalAmount { get; set; }
        public double? Remainingamount { get; set; }
        public string Paymentmethod { get; set; }
        public string Authorizedby { get; set; }
        public string Orderby { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Lastmodified { get; set; }
        public DateTime? Lastmodifieddate { get; set; }
        public string Approvedrequest { get; set; }
        public int? Supplierid { get; set; }
        public string Suppliername { get; set; }
        public string Projectnameid { get; set; }
        public string Personname { get; set; }
        public string Address { get; set; }
        public string Currency { get; set; }
        public string Officialname { get; set; }
        public string Bankcode { get; set; }
        public string Accountno { get; set; }
        public string Iban { get; set; }
        public string Swift { get; set; }
        public string Collectingchequeplace { get; set; }
        public string Lang { get; set; }
        public string BankName { get; set; }
        public double? RemainingamountAftersave { get; set; }
        public decimal? Vatamount { get; set; }
        public string Company { get; set; }
    }
}
