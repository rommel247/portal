using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcExtension
    {
        public int Id { get; set; }
        public int MasterKey { get; set; }
        public string Companysn { get; set; }
        public string LcNo { get; set; }
        public int? Categoryid { get; set; }
        public int? Purposeid { get; set; }
        public int? Bankid { get; set; }
        public string ContractnoPono { get; set; }
        public DateTime? Issuancedate { get; set; }
        public DateTime? Endingdate { get; set; }
        public DateTime? Shippingdate { get; set; }
        public double? Lcfullamount { get; set; }
        public double? Remainingamount { get; set; }
        public int? Lctypeid { get; set; }
        public int? Sectorid { get; set; }
        public string Swiftcopy { get; set; }
        public string Notes { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime IssuancedateNew { get; set; }
        public DateTime EndingdateNew { get; set; }
        public DateTime ShippingdateNew { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Datemodified { get; set; }
    }
}
