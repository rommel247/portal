using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class PoMaster
    {
        public int Id { get; set; }
        public string Poid { get; set; }
        public DateTime? Purchasedate { get; set; }
        public string Requestno { get; set; }
        public string Projectnameid { get; set; }
        public int? Supplierid { get; set; }
        public string Respeng { get; set; }
        public decimal? Discount { get; set; }
        public string Shippingterms { get; set; }
        public string Paymentterms { get; set; }
        public string Itemdesc { get; set; }
        public int? Qty { get; set; }
        public string Boq { get; set; }
        public double? Unitprice { get; set; }
        public string Authorizedby { get; set; }
        public string Orderby { get; set; }
        public string Comments { get; set; }
        public string Username { get; set; }
        public DateTime? Datetime { get; set; }
        public string Currency { get; set; }
        public string Lastmodify { get; set; }
        public DateTime? Lastdatemodified { get; set; }
        public string X { get; set; }
        public string Company { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? Totalvatamount { get; set; }
    }
}
