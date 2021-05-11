using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portal.api.Models;
using portal.api.Shared.Dto;
using portal.api.Shared.Interface;
using portal.api.Shared.Parameters;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace portal.api.Service
{
    public class SiteService : ISiteService
    {
        private readonly Art_AppDbContext _dbContext;
        public SiteService(Art_AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> CreateAsync(CreateSiteParameter parameter)
        {
            var site = new SiteTbl
            {
                SiteCode = parameter.SiteCode,
                SiteName = parameter.SiteName,
                PayrollEmail = parameter.PayrollEmail,
                Etime = parameter.Etime,
                SiteNameAr = parameter.SiteNameAr,
                LoginMode = parameter.LoginMode,
                Stime = parameter.Stime,
                RequiredWorkedHrs = parameter.RequiredWorkedHrs
            };
            await _dbContext.AddAsync(site);
            await _dbContext.SaveChangesAsync();
            //we're just returning siteid after creation
            return site.Id;
        }

        public Task<IActionResult> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<SiteDto>> GetAllSiteAsync()
        {
            return await _dbContext.SiteTbls.Select(x => new SiteDto
            {
                Id=x.Id,
                SiteCode=x.SiteCode,
                SiteName=x.SiteName,
                SiteNameAr=x.SiteNameAr,
                PayrollEmail=x.PayrollEmail,
                Etime=x.Etime,
                LoginMode=x.LoginMode,
                RequiredWorkedHrs=x.RequiredWorkedHrs,
                Stime=x.Stime
            }).ToListAsync();
        }

        public async Task<IEnumerable<SiteDto>> GetSiteByIdAsync(int Id)
        {
            return await _dbContext.SiteTbls
                .Where(x=>x.Id==Id)
                .Select(x => new SiteDto
            {
                Id = x.Id,
                SiteCode = x.SiteCode,
                SiteName = x.SiteName,
                SiteNameAr = x.SiteNameAr,
                PayrollEmail = x.PayrollEmail,
                Etime = x.Etime,
                LoginMode = x.LoginMode,
                RequiredWorkedHrs = x.RequiredWorkedHrs,
                Stime = x.Stime
            }).ToListAsync();
        }

        public Task<IActionResult> UpdateAsync(UpdateSiteParameter parameter)
        {
            throw new System.NotImplementedException();
        }
    }
}
