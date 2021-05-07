using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portal.api.Shared.Commands;
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
            _service =service;
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateDepartmentParameter parameter)
        {
          var response=  await _service.CreateAsync(parameter);
            return response;
        }

        // PUT api/<DepartmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
