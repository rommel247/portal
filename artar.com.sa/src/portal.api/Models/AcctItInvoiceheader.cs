using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class AcctItInvoiceheader
    {
        public int Id { get; set; }
        public DateTime? InvDate { get; set; }
        public decimal? Amount { get; set; }
        public string RefNo { get; set; }
        public string InvCategory { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Supplier { get; set; }
        public bool? InvType { get; set; }
        public string EntryId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Attachments { get; set; }
        public string Note { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? InvDiscount { get; set; }
        public int? InvDiscountType { get; set; }
    }
}
