using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class RequisitionApprovalCommittee
    {
        public int Id { get; set; }
        public string Branchcode { get; set; }
        public string Title { get; set; }
        public string Empcode { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? Lastmodify { get; set; }
        public string Modifyby { get; set; }
    }
}
