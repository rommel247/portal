using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcinourfavor
    {
        public int Id { get; set; }
        public string Lcno { get; set; }
        public string Beneficiarybankcode { get; set; }
        public string Applicantbankcode { get; set; }
        public string Customer { get; set; }
        public double? Lcvalue { get; set; }
        public double? Lcextensionvalue { get; set; }
        public double? Invoiceamount { get; set; }
        public DateTime? Invoicedate { get; set; }
        public string Paymentterm { get; set; }
        public int? Sectorid { get; set; }
        public int? Projectid { get; set; }
        public DateTime? Maturitydate { get; set; }
        public string Remarks { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Attachments { get; set; }
    }
}
