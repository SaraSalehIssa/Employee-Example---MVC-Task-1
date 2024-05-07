using Microsoft.AspNetCore.Mvc;
using MVCTask1.Data;

namespace MVCTask1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View("Index", employees);
        }
    }
}
