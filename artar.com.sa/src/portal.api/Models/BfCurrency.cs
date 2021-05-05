using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfCurrency
    {
        public int Id { get; set; }
        public string Currencycode { get; set; }
        public string Currencyfull { get; set; }
        public DateTime? Datecreated { get; set; }
    }
}
