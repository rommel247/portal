using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class AssetSupplier
    {
        public AssetSupplier()
        {
            AssetAccountabilities = new HashSet<AssetAccountability>();
        }

        public string SupplierName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public string Note { get; set; }

        public virtual ICollection<AssetAccountability> AssetAccountabilities { get; set; }
    }
}
