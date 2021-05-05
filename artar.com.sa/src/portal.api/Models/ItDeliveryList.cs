using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ItDeliveryList
    {
        public string Idno { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string Username { get; set; }
        public int? Entries { get; set; }
    }
}
