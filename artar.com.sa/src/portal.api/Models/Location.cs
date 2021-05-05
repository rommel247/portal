using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class Location
    {
        public Location()
        {
            AssetAccountabilities = new HashSet<AssetAccountability>();
            AssetTransferHistories = new HashSet<AssetTransferHistory>();
            Sims = new HashSet<Sim>();
        }

        public string LocationName { get; set; }

        public virtual ICollection<AssetAccountability> AssetAccountabilities { get; set; }
        public virtual ICollection<AssetTransferHistory> AssetTransferHistories { get; set; }
        public virtual ICollection<Sim> Sims { get; set; }
    }
}
