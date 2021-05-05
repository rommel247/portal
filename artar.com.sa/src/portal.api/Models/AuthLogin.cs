using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class AuthLogin
    {
        public int Id { get; set; }
        public string Authname { get; set; }
        public string Authpass { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Ip { get; set; }
    }
}
