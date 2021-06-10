using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class Meeting
    {
        public int Id { get; set; }
        public string MettingNum { get; set; }
        public string Audience { get; set; }
        public string Tasks { get; set; }
    }
}
