using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFcSectorEntry
    {
        public int Id { get; set; }
        public int Entryno { get; set; }
        public int BuId { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Tbl { get; set; }
    }
}
