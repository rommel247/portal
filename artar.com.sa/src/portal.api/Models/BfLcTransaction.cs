using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcTransaction
    {
        public int Id { get; set; }
        public int MasterKey { get; set; }
        public string CompanySn { get; set; }
        public string Transactionname { get; set; }
        public string Lcno { get; set; }
        public DateTime PartialPaymentDate { get; set; }
        public double? AmountofPayment { get; set; }
        public string Notes { get; set; }
        public string SwiftCopy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string Modifyby { get; set; }
        public DateTime? ModifieDate { get; set; }
        public double? RemainingAmount { get; set; }
        public string Invoiceno { get; set; }
        public DateTime? Receivedate { get; set; }
    }
}
