using EmployeesMicroServices.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeesMicroServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class EmployeesController : ControllerBase
    {
        static EmployeeBO context = new EmployeeBO();
        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<EmployeeModel> Get() => context.GetAllEmployees();

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public EmployeeModel Get(int id) => context.GetEmployeeByid(id);

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] EmployeeModel emp) => context.AddEmployee(emp);

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EmployeeModel emp) => context.EditEmployeeById(emp, id);

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) => context.DeleteEmployeeById(id);
    }
}
