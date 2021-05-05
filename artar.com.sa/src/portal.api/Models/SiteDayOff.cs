using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteDayOff
    {
        public int Id { get; set; }
        public string Sitecode { get; set; }
        public int Departmentid { get; set; }
        public string Weekday { get; set; }
    }
}
