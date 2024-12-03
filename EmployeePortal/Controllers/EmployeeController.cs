using EmployeePortal.Models;
using EmployeePortal.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository _employeeRepository;
        public EmployeeController(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> EmployeeList()
        {
            var allEmployee = await _employeeRepository.GetAllEmployees();
            return Ok(allEmployee);
        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee(Employee objEmployee)
        {
            await _employeeRepository.SaveEmployee(objEmployee);
            return Ok(objEmployee);
        }

    }
}
