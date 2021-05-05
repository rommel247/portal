using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class InvMainTable
    {
        public int Id { get; set; }
        public decimal? Amount { get; set; }
        public int? SupplierId { get; set; }
        public int? RequestId { get; set; }
        public string InvoiceInfo { get; set; }
        public DateTime? ImportDate { get; set; }
        public DateTime? ExportDate { get; set; }
        public int? StatusId { get; set; }
        public int? AccountingId { get; set; }
        public string UserName { get; set; }
        public string InvoiceId { get; set; }
        public DateTime? DeleviryDate { get; set; }
        public bool? CheckedId { get; set; }
    }
}
