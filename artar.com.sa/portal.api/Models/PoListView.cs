using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class PoListView
    {
        public string Poid { get; set; }
        public string Requestno { get; set; }
        public DateTime? Purchasedate { get; set; }
        public string Suppliername { get; set; }
        public string Personname { get; set; }
        public string Pobox { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Respeng { get; set; }
        public string Orderby { get; set; }
        public string Projectnameid { get; set; }
        public string Authorizedby { get; set; }
        public int? Supplierid { get; set; }
        public decimal? Discount { get; set; }
        public string Currency { get; set; }
        public string Officialname { get; set; }
        public string Bankcode { get; set; }
        public string Accountno { get; set; }
        public string Iban { get; set; }
        public string Swift { get; set; }
        public string Username { get; set; }
        public double? Totalprice { get; set; }
        public decimal Vatamount { get; set; }
        public string Company { get; set; }
    }
}
