using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class VisaEnjaz
    {
        public int Id { get; set; }
        public string Place { get; set; }
        public string Profession { get; set; }
        public string Nationality { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string VisaNumber { get; set; }
        public string AgencyName { get; set; }
    }
}
