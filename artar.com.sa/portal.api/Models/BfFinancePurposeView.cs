using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFinancePurposeView
    {
        public int Id { get; set; }
        public int? Requestid { get; set; }
        public string Specify { get; set; }
        public string Username { get; set; }
        public DateTime? Dateofrequest { get; set; }
        public int? Purposeid { get; set; }
        public string Purpose { get; set; }
    }
}
