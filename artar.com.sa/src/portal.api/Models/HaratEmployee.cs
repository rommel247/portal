using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class HaratEmployee
    {
        public double Id { get; set; }
        public string Arabicname { get; set; }
        public string Englishname { get; set; }
        public string Dep { get; set; }
        public string Position { get; set; }
        public string Site { get; set; }
    }
}
