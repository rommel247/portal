using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class PoSupplier
    {
        public int Supplierid { get; set; }
        public string Suppliername { get; set; }
        public string Personname { get; set; }
        public string Pobox { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Officialname { get; set; }
        public string Bankcode { get; set; }
        public string Accountno { get; set; }
        public string Iban { get; set; }
        public string Swift { get; set; }
    }
}
