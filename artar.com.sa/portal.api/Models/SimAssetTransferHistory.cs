using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SimAssetTransferHistory
    {
        public string Idno { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNo { get; set; }
        public string Category { get; set; }
        public string EmpId { get; set; }
    }
}
