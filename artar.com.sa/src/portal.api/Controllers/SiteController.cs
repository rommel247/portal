using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portal.api.Shared.Dto;
using portal.api.Shared.Interface;
using portal.api.Shared.Parameters;

namespace portal.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteController : ControllerBase
    {
        private readonly ISiteService _siteservice;
        public SiteController(ISiteService siteservice)
        {
            _siteservice = siteservice;
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateSiteParameter parameter)
        {
            return await _siteservice.CreateAsync(parameter);
        }

        [HttpGet]
        public async Task<IEnumerable<SiteDto>> GetAllSiteAsync()
        {
            return await _siteservice.GetAllSiteAsync();
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<SiteDto>> GetSiteIdAsync(int id)
        {
            return await _siteservice.GetSiteByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await _siteservice.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSiteParameter parameter)
        {
            return await _siteservice.UpdateAsync(parameter);
        }


    }
}
