using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly EmsContext _context;

        public ManagerController(EmsContext context,List<Manager> managers)
        {
            _context = context;

            foreach (Manager manager in managers)
                _context._managers.Add(manager);
        }

        public ManagerController(EmsContext context)
        {
            _context = context;

            if (_context._managers.Count() == 0)
            {
                _context._managers.Add(new Manager { Name = "vighnesh", Salary = 600000 });
                _context._managers.Add(new Manager { Name = "shubham", Salary = 600000 });
                _context._managers.Add(new Manager { Name = "bhanu", Salary = 600000 });
                _context._managers.Add(new Manager { Name = "raunak", Salary = 600000 });
                _context._managers.Add(new Manager { Name = "omkar", Salary = 600000 });
                _context.SaveChanges();
            }
        }

        // GET: api/Manager
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manager>>> GetManagers()
        {
            return await _context._managers.ToListAsync();
        }

        // GET: api/Manager/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Manager>> GetManager(long id)
        {
            var manager = await _context._managers.FindAsync(id);

            if (manager == null)
            {
                return NotFound();
            }

            return manager;
        }

        //GET: api/manager/2/Employees
        [HttpGet("{id}/Employees")]
        public IEnumerable<Employee> GetEmployeesForManager(long id)
        {
            return _context._employees
                .Where(s=>s.ManagerId==id)
                .ToList();
        }
    }
}