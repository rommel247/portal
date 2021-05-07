using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portal.api.Shared.Dto;
using portal.api.Shared.Interface;
using portal.api.Shared.Commands;
using Microsoft.EntityFrameworkCore;
using portal.api.Models;

namespace portal.api.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly Art_AppDbContext _dbcontext;
        public DepartmentService(Art_AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<int> CreateAsync(CreateDepartmentParameter parameter)
        {
            var newdepartment = new SiteDepartment()
            {
                SiteCode = parameter.SiteCode,
                DepartmentName = parameter.DepartmentName,
                Mode = parameter.Mode,
                Title = parameter.Title,
                FullName = parameter.FullName,
                Email= parameter.Email,
                Cc = parameter.Cc,
                Bcc=parameter.Bcc

            };
            await _dbcontext.AddAsync(newdepartment);
            await _dbcontext.SaveChangesAsync();
            return newdepartment.DepartmentId;
        }

        public Task<ActionResult> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DepartmentDto>> GetAllDepartmentAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DepartmentDto>> GetDepartmentByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> UpdateAsync(UpdateDepartmentParameter parameter)
        {
            throw new NotImplementedException();
        }
    }
}
