using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class PoView
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
        public string Personname { get; set; }
        public string Suppliername { get; set; }
        public string Pobox { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Currency { get; set; }
        public string Officialname { get; set; }
        public double? Subtotal { get; set; }
        public decimal Vatamount { get; set; }
        public string Company { get; set; }
        public decimal Totalvatamount { get; set; }
    }
}
