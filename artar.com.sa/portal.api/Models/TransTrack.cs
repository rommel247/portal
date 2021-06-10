using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class TransTrack
    {
        public int Id { get; set; }
        public int? JobOrderNumber { get; set; }
        public int? Departure { get; set; }
        public int? Destination { get; set; }
        public DateTime? JobDate { get; set; }
        public string JobTime { get; set; }
    }
}
