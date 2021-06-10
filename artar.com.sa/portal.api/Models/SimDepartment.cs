using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SimDepartment
    {
        public SimDepartment()
        {
            AssetAccountabilities = new HashSet<AssetAccountability>();
            AssetTransferHistories = new HashSet<AssetTransferHistory>();
            Sims = new HashSet<Sim>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<AssetAccountability> AssetAccountabilities { get; set; }
        public virtual ICollection<AssetTransferHistory> AssetTransferHistories { get; set; }
        public virtual ICollection<Sim> Sims { get; set; }
    }
}
