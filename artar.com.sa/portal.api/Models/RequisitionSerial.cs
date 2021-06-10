using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class RequisitionSerial
    {
        public int Id { get; set; }
        public string Oracleserial { get; set; }
        public string Oraclecode { get; set; }
        public int Itemid { get; set; }
        public string Requisitionno { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Createdby { get; set; }
    }
}
