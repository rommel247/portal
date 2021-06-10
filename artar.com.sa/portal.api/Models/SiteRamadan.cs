using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteRamadan
    {
        public int Id { get; set; }
        public int Religion { get; set; }
        public DateTime Datefrom { get; set; }
        public DateTime Dateto { get; set; }
        public string Timein { get; set; }
        public string Timeout { get; set; }
        public string Sitecode { get; set; }
        public string Workinghours { get; set; }
    }
}
