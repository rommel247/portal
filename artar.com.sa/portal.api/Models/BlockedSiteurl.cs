using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BlockedSiteurl
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Datevisit { get; set; }
        public string Url { get; set; }
        public string Ip { get; set; }
        public string Host { get; set; }
    }
}
