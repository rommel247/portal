using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class XattIp
    {
        public int Id { get; set; }
        public string IpAddr { get; set; }
        public int Enabled { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Port { get; set; }
    }
}
