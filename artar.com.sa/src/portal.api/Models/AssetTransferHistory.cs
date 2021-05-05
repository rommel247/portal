using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class AssetTransferHistory
    {
        public string Idno { get; set; }
        public string AssignedTo { get; set; }
        public DateTime TransferDate { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }
        public string AssignedFrom { get; set; }
        public DateTime? TransferDateFrom { get; set; }
        public int Id { get; set; }
        public string Createdby { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual Company CompanyNavigation { get; set; }
        public virtual SimDepartment DepartmentNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
    }
}
