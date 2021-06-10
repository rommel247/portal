using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfPaymentSourceEntry
    {
        public int Id { get; set; }
        public int LoanmasterId { get; set; }
        public int Sourceid { get; set; }
        public double? Amount { get; set; }
        public DateTime Dateofpayment { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Modifiedby { get; set; }
        public double? Paymentamount { get; set; }
    }
}
