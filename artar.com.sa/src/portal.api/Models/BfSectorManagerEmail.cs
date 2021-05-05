using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfSectorManagerEmail
    {
        public int Id { get; set; }
        public int Sectorid { get; set; }
        public string Username { get; set; }
        public string Position { get; set; }
        public string Emailaddress { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Modifyby { get; set; }
        public DateTime? Datemodifed { get; set; }
    }
}
