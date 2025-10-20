using Demo.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
    public class DepartmentController(IDepartmentService _deparmentService) : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var departments = _deparmentService.GetAllDepartments();
            return View(departments);
        }
    }
}
