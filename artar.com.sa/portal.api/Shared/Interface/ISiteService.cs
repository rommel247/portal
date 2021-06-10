using Microsoft.AspNetCore.Mvc;
using portal.api.Shared.Parameters;
using portal.api.Shared.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace portal.api.Shared.Interface
{
   public interface ISiteService
    {
        Task<int> CreateAsync(CreateSiteParameter parameter);
        Task<IActionResult> UpdateAsync(UpdateSiteParameter parameter);
        Task<IActionResult> DeleteAsync(int id);
        Task<IEnumerable<SiteDto>> GetAllSiteAsync();
        Task<IEnumerable<SiteDto>> GetSiteByIdAsync(int Id);

    }
}
