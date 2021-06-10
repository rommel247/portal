using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardBlockedsiteTicket
    {
        public int Id { get; set; }
        public DateTime? Dateentry { get; set; }
        public string ProblemtypeId { get; set; }
        public string Url { get; set; }
        public string Ip { get; set; }
        public string Host { get; set; }
    }
}
