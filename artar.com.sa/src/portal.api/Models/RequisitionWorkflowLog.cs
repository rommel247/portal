using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class RequisitionWorkflowLog
    {
        public int Id { get; set; }
        public int? RequisitionFkid { get; set; }
        public string Status { get; set; }
        public string ApprovalEmployeeCode { get; set; }
        public string ApprovalUsername { get; set; }
        public string Remarks { get; set; }
        public DateTime? Dateofapproval { get; set; }
        public string Lastmodifyby { get; set; }
        public DateTime? Lastmodifydatetime { get; set; }
        public int ReqNo { get; set; }
        public string Forwardedto { get; set; }
    }
}
