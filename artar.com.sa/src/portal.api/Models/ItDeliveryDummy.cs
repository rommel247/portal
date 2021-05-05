using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ItDeliveryDummy
    {
        public int Id { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemQty { get; set; }
        public string Remarks { get; set; }
        public string Username { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
    }
}
