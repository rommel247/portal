using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OUserAccess
    {
        public int Id { get; set; }
        public string EmpUsername { get; set; }
        public string EmpCode { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Createdby { get; set; }
        public string CreatorCode { get; set; }
        public DateTime? LastDateModify { get; set; }
        public string LastModify { get; set; }
        public int Fid { get; set; }
        public int BuId { get; set; }
        public string Module { get; set; }
        public int? NestedToLevel { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
    }
}
