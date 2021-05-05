using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class Holiday
    {
        public DateTime HolidayEndDate { get; set; }
        public DateTime HolidayStartDate { get; set; }
        public string HolidayDescription { get; set; }
        public int Id { get; set; }
    }
}
