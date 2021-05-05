using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class AssetCategory
    {
        public AssetCategory()
        {
            AssetAccountabilities = new HashSet<AssetAccountability>();
        }

        public string Description { get; set; }

        public virtual ICollection<AssetAccountability> AssetAccountabilities { get; set; }
    }
}
