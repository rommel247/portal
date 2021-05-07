
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portal.api.Shared.Dto;
using portal.api.Shared.Commands;
namespace portal.api.Shared.Interface
{
    public interface IDepartmentService
    {
        Task<int> CreateAsync(CreateDepartmentParameter parameter);
        Task<ActionResult> UpdateAsync(UpdateDepartmentParameter parameter);
        Task<ActionResult> DeleteAsync(int Id);
        Task<IEnumerable<DepartmentDto>> GetAllDepartmentAsync();
        Task<IEnumerable<DepartmentDto>> GetDepartmentByIdAsync(int Id);
        
     }
}
