using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLgExtension
    {
        public int Id { get; set; }
        public string Lgno { get; set; }
        public DateTime Issuancedate { get; set; }
        public DateTime Expirydate { get; set; }
        public double? Lgamount { get; set; }
        public string Notes { get; set; }
        public string Swiftcopy { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Modifiedby { get; set; }
        public int Lgmasterid { get; set; }
    }
}
