using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using portal.api.Shared.Parameters;
using portal.api.Shared.Dto;
using portal.api.Shared.Interface;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portal.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _service;
        public DepartmentController(IDepartmentService service)
        {
            _service = service;
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        public async Task<IEnumerable<DepartmentDto>> Get()
        {          
            return await _service.GetAllDepartmentAsync();

        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id:int}")]
        public async Task<IEnumerable<DepartmentDto>> GetById(int id)
        {
            return await _service.GetDepartmentByIdAsync(id);
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{sitecode}")]
        public async Task<IEnumerable<DepartmentDto>> GetBySiteCode(string sitecode)
        {
            return await _service.GetDeparmentBySitecodeAsync(sitecode);
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateDepartmentParameter parameter)
        {
            var response = await _service.CreateAsync(parameter);
            return response;
        }

        // PUT api/<DepartmentController>/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //validate if exist if not then show error
            var response = await _service.DeleteAsync(id);
            return Ok(response);
        }
    }
}
