using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfManageSectorView
    {
        public int Id { get; set; }
        public int Sectorid { get; set; }
        public double? Amount { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Username { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Modifiedby { get; set; }
        public double Utilized { get; set; }
        public double? Availableforuse { get; set; }
        public string Sector { get; set; }
        public DateTime? Validfrom { get; set; }
        public DateTime? Validto { get; set; }
        public double AmountinProgress { get; set; }
        public bool Openlimit { get; set; }
    }
}
