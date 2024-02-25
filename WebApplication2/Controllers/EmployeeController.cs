using Microsoft.AspNetCore.Mvc;
using WebApplication2.Contexts;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;
        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Models.Employee> employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}
