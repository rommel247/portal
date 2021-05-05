using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfBusinessUnitPermission
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int BuId { get; set; }
        public int Usergroupid { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Modifiedby { get; set; }
    }
}
