using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OracleSqlIntegrationLog
    {
        public int Id { get; set; }
        public DateTime? Timestamped { get; set; }
        public int? Updated { get; set; }
        public int? Inserted { get; set; }
        public int? Iteration { get; set; }
        public decimal? TimelapsedSec { get; set; }
    }
}
