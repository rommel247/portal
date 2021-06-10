using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using portal.api.Shared.Dto;

namespace portal.test.Repository
{
   public class GenericData
    {

        public List<SiteDto> Site()
        {
            //Arrange
            List<SiteDto> sitelist = new List<SiteDto>();
            sitelist.Add(new SiteDto
            {
                Id = 1,
                Etime = string.Empty,
                LoginMode = "",
                PayrollEmail = string.Empty,
                RequiredWorkedHrs = "",
                SiteCode = "HQ",
                SiteName = string.Empty,
                Stime = string.Empty,
                SiteNameAr = string.Empty
            });
            return sitelist;
        }
    }
}
