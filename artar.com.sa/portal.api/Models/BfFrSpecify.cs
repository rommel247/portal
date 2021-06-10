using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFrSpecify
    {
        public int Id { get; set; }
        public int? Requestid { get; set; }
        public string Specifypurpose { get; set; }
        public string Username { get; set; }
        public int? Purposeid { get; set; }
    }
}
