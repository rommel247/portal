using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLoanEmail
    {
        public int Id { get; set; }
        public string Emailaddress { get; set; }
        public string Cc { get; set; }
        public string Link { get; set; }
        public string Mailbody { get; set; }
        public string Subject { get; set; }
        public string Module { get; set; }
        public int? Sectorid { get; set; }
    }
}
