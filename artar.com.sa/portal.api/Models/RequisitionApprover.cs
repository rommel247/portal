using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class RequisitionApprover
    {
        public int Id { get; set; }
        public string ManagerCode { get; set; }
        public string RequisitionNo { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Entryby { get; set; }
        public DateTime? Lastmodificationdate { get; set; }
        public string Lastmodifiedby { get; set; }
        public string ApprovalAction { get; set; }
        public DateTime? DateofAction { get; set; }
        public string Actionby { get; set; }
    }
}
