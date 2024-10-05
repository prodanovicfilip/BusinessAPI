using BusinessAPI.DTOs;
using BusinessAPI.Entities;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace BusinessAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly BusinessDbContext _context;
        public EmployeeController(BusinessDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var employees = _context.Employees.ToList();
            var employeesDTO = employees.Adapt<IEnumerable<EmployeeDTO>>();
            return Ok(employeesDTO);
        }
    }
}
