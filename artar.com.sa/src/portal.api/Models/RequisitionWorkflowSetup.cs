using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class RequisitionWorkflowSetup
    {
        public int Id { get; set; }
        public string Branchcode { get; set; }
        public int Orderid { get; set; }
        public string ApprovalEmployeeid { get; set; }
        public int Type { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
    }
}
