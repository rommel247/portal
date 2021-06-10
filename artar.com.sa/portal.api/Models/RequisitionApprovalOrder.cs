using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class RequisitionApprovalOrder
    {
        public int Id { get; set; }
        public string Branchcode { get; set; }
        public int Sortid { get; set; }
        public int FkId { get; set; }
        public int? Onapproval { get; set; }
        public int? Onrejection { get; set; }
        public int? Onwithdraw { get; set; }
        public int? Onrecommendation { get; set; }
        public int? Onnotify { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Lastmodifyby { get; set; }
    }
}
