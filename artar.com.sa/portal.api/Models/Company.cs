using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class Company
    {
        public Company()
        {
            AssetTransferHistories = new HashSet<AssetTransferHistory>();
            Sims = new HashSet<Sim>();
        }

        public string CoName { get; set; }
        public string Code { get; set; }

        public virtual ICollection<AssetTransferHistory> AssetTransferHistories { get; set; }
        public virtual ICollection<Sim> Sims { get; set; }
    }
}
