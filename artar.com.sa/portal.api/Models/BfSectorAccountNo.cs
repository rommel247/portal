using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfSectorAccountNo
    {
        public int Id { get; set; }
        public int SectorFkey { get; set; }
        public string Accountno { get; set; }
        public string Accountname { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public string Modifyby { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Rtble { get; set; }
    }
}
