using Microsoft.AspNetCore.Mvc;
using WebApplication2.Contexts;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeContoller : Controller
    {
        private readonly AppDbContext _context;
        public EmployeeContoller(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}
