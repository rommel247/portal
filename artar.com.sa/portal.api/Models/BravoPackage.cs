using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BravoPackage
    {
        public BravoPackage()
        {
            AssetAccountabilities = new HashSet<AssetAccountability>();
        }

        public string Code { get; set; }

        public virtual ICollection<AssetAccountability> AssetAccountabilities { get; set; }
    }
}
