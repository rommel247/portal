using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class PoBank
    {
        public int Id { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string Iban { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
    }
}
